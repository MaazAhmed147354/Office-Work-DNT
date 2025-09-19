import { format, startOfWeek, addWeeks } from "date-fns";
import { useState, useEffect, useMemo, useRef } from "react";
import { PieChart, Table, ChevronDown, ChevronUp } from "lucide-react";
import { useToast } from "../context/ToastContext";
import {
  SpinnerLoader,
  ToggleSwitch,
  DownloadButton,
  AnalyticsChartCard,
  ContributionChartCard,
  Accordion,
} from "../components";
import analyticsService from "../services/analyticsService";

const AnalyticsProductsAnalysis = ({
  selectedTab,
  selectedValue,
  brands,
  selectedBrandIds,
  selectedProductIds,
  analysisData,
  setAnalysisData,
}) => {
  const [isLoading, setIsLoading] = useState(false);
  const [error, setError] = useState(null);
  const [viewMode, setViewMode] = useState("graphical");
  const [openBrandIndex, setOpenBrandIndex] = useState(null);

  // create refs for charts
  const analysisChartRef = useRef(null);
  const contributionChartRef = useRef(null);

  const { showToast } = useToast();
  const didMount = useRef(false);

  // fetch product analytics when filters change
  useEffect(() => {
    if (!didMount.current) {
      didMount.current = true;
      return;
    }
    const fetchAnalytics = async () => {
      if (!brands || brands.length === 0 || !selectedTab || !selectedValue) {
        setAnalysisData([]);
        return;
      }
      try {
        setIsLoading(true);
        setError(null);

        const rangeTypeMap = {
          year: "yearly",
          month: "monthly",
          week: "weekly",
          quarter: "quarterly",
        };
        const rangeType = rangeTypeMap[selectedTab];

        let referenceDate;
        if (selectedTab === "year") {
          referenceDate = `${selectedValue}-01-01`;
        } else if (selectedTab === "month") {
          referenceDate = `${selectedValue}-01`;
        } else if (selectedTab === "week") {
          const year = selectedValue.substring(0, 4);
          const weekNum = parseInt(selectedValue.substring(6));
          const firstWeek = startOfWeek(new Date(parseInt(year), 0, 1));
          const targetDate = addWeeks(firstWeek, weekNum - 1);
          referenceDate = format(targetDate, "yyyy-MM-dd");
        } else if (selectedTab === "quarter") {
          const quarterMap = { Q1: "01", Q2: "04", Q3: "07", Q4: "10" };
          const year = new Date().getFullYear();
          referenceDate = `${year}-${quarterMap[selectedValue]}-01`;
        }

        if (selectedBrandIds.length === 0) {
          setAnalysisData([]);
          showToast("Please select at least one brand.", "warning");
          return;
        }

        const data = await analyticsService.GetProductsAnalysis(
          selectedBrandIds,
          rangeType,
          referenceDate
        );

        if (!data || data.length === 0) {
          setAnalysisData([]);
          showToast(
            "No sales data available for the selected period.",
            "warning"
          );
        } else {
          setAnalysisData(data);
          showToast("Products Analytics data fetched", "success");
        }
      } catch (err) {
        setError("Failed to fetch products analytics");
        console.error(err);
      } finally {
        setIsLoading(false);
      }
    };
    fetchAnalytics();
  }, [selectedBrandIds, selectedTab, selectedValue]);

  // ✅ Restructure response once
  const structuredData = useMemo(() => {
    if (!analysisData || analysisData.length === 0) return [];

    const brandMap = {};

    analysisData.forEach((row) => {
      const { brandId, productId } = row;

      if (!brandMap[brandId]) {
        const brandName = brands.find((b) => b.id === brandId)?.name || "";
        brandMap[brandId] = {
          brandId,
          brandName,
          products: {},
        };
      }

      if (!brandMap[brandId].products[productId]) {
        brandMap[brandId].products[productId] = {
          productId,
          productName: row.productName,
          breakdown: [],
        };
      }

      brandMap[brandId].products[productId].breakdown.push({
        period: row.period,
        totalSales: row.totalSales,
        totalOrders: row.totalOrders,
        percentOfTotal: row.percentOfTotal,
      });
    });

    return Object.values(brandMap).map((brand) => ({
      brandId: brand.brandId,
      brandName: brand.brandName,
      products: Object.values(brand.products),
    }));
  }, [analysisData, brands]);

  // ✅ Chart Data → brand totals
  const chartData = useMemo(() => {
    if (!structuredData || structuredData.length === 0) return [];

    return structuredData.map((brand) => {
      const totalSales = brand.products.reduce(
        (sum, p) => sum + p.breakdown.reduce((s, b) => s + b.totalSales, 0),
        0
      );
      const totalOrders = brand.products.reduce(
        (sum, p) => sum + p.breakdown.reduce((s, b) => s + b.totalOrders, 0),
        0
      );
      const totalContribution = brand.products.reduce(
        (sum, p) => sum + p.breakdown.reduce((s, b) => s + b.percentOfTotal, 0),
        0
      );
      return {
        label: brand.brandName,
        totalSales,
        totalOrders,
        totalContribution,
      };
    });
  }, [structuredData]);

  // ✅ Accordion Data → products grouped under each brand
  const accordionData = useMemo(() => {
    if (!structuredData || structuredData.length === 0) return [];

    return structuredData.map((brand) => ({
      brand: brand.brandName,
      products: brand.products.filter((p) =>
        selectedProductIds.includes(p.productId)
      ),
    }));
  }, [structuredData, selectedProductIds]);

  if (error) return <div>{error}</div>;

  return isLoading ? (
    <SpinnerLoader label="Loading product analytics..." />
  ) : (
    <div className="flex flex-col min-h-full">
      <ToggleSwitch
        active={viewMode}
        onToggle={setViewMode}
        options={[
          { id: "graphical", label: "Graphical", icon: <PieChart size={18} /> },
          { id: "tabular", label: "Tabular", icon: <Table size={18} /> },
        ]}
      />

      {viewMode === "graphical" ? (
        <div className="space-y-4">
          <div className="flex items-center justify-end">
            <DownloadButton
              type="pdf"
              title={`Products Analysis Report (${selectedTab}ly)`}
              chartRefs={[analysisChartRef, contributionChartRef]}
            />
          </div>
          {/* Graphical Section */}
          <div className="grid grid-cols-1 grid-rows-2 md:grid-rows-1 gap-6">
            <div className="col-span-1 lg:col-span-1">
              <AnalyticsChartCard
                ref={analysisChartRef}
                tab={selectedTab}
                value={selectedValue}
                data={chartData}
              />
            </div>
            <div className="col-span-1 lg:col-span-1">
              <ContributionChartCard
                ref={contributionChartRef}
                tab={selectedTab}
                value={selectedValue}
                data={chartData}
              />
            </div>
          </div>
        </div>
      ) : (
        // ✅ Tabular Section
        <div className="space-y-4">
          {accordionData.map((brand, index) => (
            <div
              key={brand.brandId || index}
              className="bg-[#252538] border border-[#38384a] rounded-xl overflow-hidden"
            >
              {/* Brand Accordion Header */}
              <button
                onClick={() =>
                  setOpenBrandIndex(openBrandIndex === index ? null : index)
                }
                className="w-full text-left p-4 flex justify-between items-center hover:bg-[#38384a]"
              >
                <span className="font-medium text-[#BEB7DF]">
                  {brand.brand}
                </span>
                <span className="text-gray-400">
                  {openBrandIndex === index ? <ChevronUp /> : <ChevronDown />}
                </span>
              </button>

              {/* Brand Content */}
              {openBrandIndex === index && (
                <div className="p-3 space-y-3">
                  <Accordion
                    data={brand.products.map((product) => ({
                      name: product.productName,
                      sales: product.breakdown,
                    }))}
                  />
                </div>
              )}
            </div>
          ))}
        </div>
      )}
    </div>
  );
};

export default AnalyticsProductsAnalysis;
