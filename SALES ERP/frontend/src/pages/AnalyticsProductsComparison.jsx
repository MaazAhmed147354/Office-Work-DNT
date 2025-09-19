import { startOfWeek, addWeeks, format } from "date-fns";
import { useState, useEffect, useMemo, useRef } from "react";
import { useToast } from "../context/ToastContext";
import {
  SpinnerLoader,
  CustomDropdown,
  ToggleSwitch,
  DownloadButton,
  ComparisonChartCard,
} from "../components";
import analyticsService from "../services/analyticsService";

const AnalyticsProductsComparison = ({
  selectedTab,
  selectedValue,
  brands,
  selectedBrandIds,
  selectedProductIds,
  analysisData,
  setAnalysisData,
}) => {
  const [isLoading, setIsLoading] = useState(false);
  const [compareMode, setCompareMode] = useState("brand"); // brand | product
  const [selected1, setSelected1] = useState(null);
  const [selected2, setSelected2] = useState(null);

  const comparisonChartRef = useRef(null);
  const { showToast } = useToast();
  const didMount = useRef(false);

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
        const rangeTypeMap = {
          year: "yearly",
          month: "monthly",
          week: "weekly",
          quarter: "quarterly",
        };
        const rangeType = rangeTypeMap[selectedTab];

        let referenceDate;
        if (selectedTab === "year") referenceDate = `${selectedValue}-01-01`;
        else if (selectedTab === "month") referenceDate = `${selectedValue}-01`;
        else if (selectedTab === "week") {
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

        const brandIds = selectedBrandIds;
        if (brandIds.length === 0) {
          setAnalysisData([]);
          return;
        }

        const data = await analyticsService.GetProductsAnalysis(
          brandIds,
          rangeType,
          referenceDate
        );
        setAnalysisData(data);
      } catch (err) {
        console.error(err);
      } finally {
        setIsLoading(false);
      }
    };
    fetchAnalytics();
  }, [selectedBrandIds, selectedTab, selectedValue]);

  // ✅ Restructure response once, with totals
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
          totalSales: 0,
          totalOrders: 0,
        };
      }

      brandMap[brandId].products[productId].breakdown.push({
        period: row.period,
        totalSales: row.totalSales,
        totalOrders: row.totalOrders,
        percentOfTotal: row.percentOfTotal,
      });

      // accumulate product totals
      brandMap[brandId].products[productId].totalSales += row.totalSales;
      brandMap[brandId].products[productId].totalOrders += row.totalOrders;
    });

    return Object.values(brandMap).map((brand) => {
      const products = Object.values(brand.products);
      const totalSales = products.reduce((sum, p) => sum + p.totalSales, 0);
      const totalOrders = products.reduce((sum, p) => sum + p.totalOrders, 0);

      return {
        brandId: brand.brandId,
        brandName: brand.brandName,
        totalSales,
        totalOrders,
        products,
      };
    });
  }, [analysisData, brands]);

  // filter options for comparison
  const brandOptions = structuredData.map((b) => ({
    value: b.brandId,
    label: b.brandName,
  }));

  const productOptions = structuredData
    .flatMap((b) => b.products)
    .filter((p) => selectedProductIds.includes(p.productId))
    .map((p) => ({ value: p.productId, label: p.productName }));

  // ✅ Chart Data depending on mode
  const chartData = useMemo(() => {
    if (!selected1 || !selected2) return null;
    if (selected1 === selected2) {
      showToast("Please select different items for comparison");
      return null;
    }

    if (compareMode === "brand") {
      const brand1 = structuredData.find((b) => b.brandId === selected1);
      const brand2 = structuredData.find((b) => b.brandId === selected2);

      if (!brand1 || !brand2) return null;

      return {
        labels: [brand1.brandName, brand2.brandName],
        datasets: [
          {
            label: "Sales",
            data: [brand1.totalSales, brand2.totalSales],
            backgroundColor: "rgba(0, 117, 149, 0.25)",
            borderColor: "#00b8db",
            borderWidth: 2,
            yAxisID: "y1",
          },
          {
            label: "Orders",
            data: [brand1.totalOrders, brand2.totalOrders],
            backgroundColor: "rgba(112, 8, 231, 0.5)",
            borderColor: "#8e51ff",
            borderWidth: 2,
            yAxisID: "y2",
          },
        ],
      };
    } else {
      const allProducts = structuredData.flatMap((b) => b.products);
      const prod1 = allProducts.find((p) => p.productId === selected1);
      const prod2 = allProducts.find((p) => p.productId === selected2);

      if (!prod1 || !prod2) return null;

      return {
        labels: [prod1.productName, prod2.productName],
        datasets: [
          {
            label: "Sales",
            data: [prod1.totalSales, prod2.totalSales],
            backgroundColor: "rgba(0, 117, 149, 0.25)",
            borderColor: "#00b8db",
            borderWidth: 2,
            yAxisID: "y1",
          },
          {
            label: "Orders",
            data: [prod1.totalOrders, prod2.totalOrders],
            backgroundColor: "rgba(112, 8, 231, 0.5)",
            borderColor: "#8e51ff",
            borderWidth: 2,
            yAxisID: "y2",
          },
        ],
      };
    }
  }, [selected1, selected2, compareMode, structuredData, showToast]);

  return isLoading ? (
    <SpinnerLoader label="Loading product comparison..." />
  ) : (
    <div className="space-y-6 min-h-full">
      <ToggleSwitch
        active={compareMode}
        onToggle={setCompareMode}
        options={[
          { id: "brand", label: "Brand Wise" },
          { id: "product", label: "Product Wise" },
        ]}
      />

      <div className="flex flex-col md:flex-row gap-4 items-center justify-center">
        <CustomDropdown
          selectedValue={
            compareMode === "brand"
              ? brandOptions.find((b) => b.value === selected1)?.label ||
                "Select Brand"
              : productOptions.find((p) => p.value === selected1)?.label ||
                "Select Product"
          }
          onSelect={setSelected1}
          options={compareMode === "brand" ? brandOptions : productOptions}
        />

        <CustomDropdown
          selectedValue={
            compareMode === "brand"
              ? brandOptions.find((b) => b.value === selected2)?.label ||
                "Select Brand"
              : productOptions.find((p) => p.value === selected2)?.label ||
                "Select Product"
          }
          onSelect={setSelected2}
          options={compareMode === "brand" ? brandOptions : productOptions}
        />
      </div>

      {chartData && (
        <div className="space-y-4">
          <div className="flex items-center justify-end">
            <DownloadButton
              type="pdf"
              title={`Products Comparison Report (${selectedTab}ly)`}
              chartRefs={[comparisonChartRef]}
            />
          </div>
          <div className="grid grid-cols-1 gap-6">
            <ComparisonChartCard
              ref={comparisonChartRef}
              tab={selectedTab}
              value={selectedValue}
              chartData={chartData}
            />
          </div>
        </div>
      )}
    </div>
  );
};

export default AnalyticsProductsComparison;
