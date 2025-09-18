import { format } from "date-fns";
import { useState, useEffect } from "react";
import { useToast } from "../context/ToastContext";
import { SpinnerLoader, CustomTabs, FilterDataCard } from "../components";
import AnalyticsProductsAnalysis from "./AnalyticsProductsAnalysis";
import AnalyticsProductsComparison from "./AnalyticsProductsComparison";
import analyticsService from "../services/analyticsService";

const AnalyticsProducts = () => {
  const [isLoading, setIsLoading] = useState(false);
  const [activeTab, setActiveTab] = useState("analysis");

  // ✅ Shared filter states
  const [selectedTab, setSelectedTab] = useState("week");
  const [selectedValue, setSelectedValue] = useState(null);

  const [brands, setBrands] = useState([]); // [{id, name, products:[...]}]
  const [selectedBrandIds, setSelectedBrandIds] = useState([]); // ✅ add this
  const [selectedProductIds, setSelectedProductIds] = useState([]); // passed from ProductsModal
  const [analysisData, setAnalysisData] = useState([]);

  const { showToast } = useToast();

  useEffect(() => {
    // Fetch products list and prepare grouped brands
    const fetchInitialData = async () => {
      try {
        setIsLoading(true);

        const productsList = await analyticsService.getProductsList();

        // group products by brand
        const groupedBrands = productsList.reduce((acc, curr) => {
          if (!acc[curr.brandId]) {
            acc[curr.brandId] = {
              id: curr.brandId,
              name: curr.brandName,
              products: [],
            };
          }
          acc[curr.brandId].products.push({
            id: curr.productId,
            name: curr.productName,
          });
          return acc;
        }, {});
        setBrands(Object.values(groupedBrands));

        // by default select all brands
        const allbrandIds = Object.keys(groupedBrands).map((id) => parseInt(id));
        setSelectedBrandIds(allbrandIds);

        // by default select all products
        const allProductIds = productsList.map((p) => p.productId);
        setSelectedProductIds(allProductIds);

        // set default reference date (week)
        const today = new Date();
        const referenceDate = format(today, "yyyy-MM-dd");
        const weekValue = format(today, "yyyy-'W'II");
        setSelectedValue(weekValue);

        const data = await analyticsService.GetProductsAnalysis(
          allbrandIds,
          "weekly",
          referenceDate
        );
        setAnalysisData(data);

        showToast("Products Analytics data fetched", "success");
      } catch (err) {
        console.error("Failed to load products list:", err);
      } finally {
        setIsLoading(false);
      }
    };
    fetchInitialData();
  }, []);

  return isLoading ? (
    <SpinnerLoader label="Loading product analytics..." />
  ) : (
    <div className="flex flex-col min-h-[84.6vh]">
      <div className="flex-1">
        {/* Tabs only control state */}
        <CustomTabs
          activeTab={activeTab}
          onTabChange={setActiveTab}
          tabs={[
            { id: "analysis", label: "Analysis", icon: "📊" },
            { id: "comparison", label: "Comparison", icon: "⚖️" },
          ]}
        />

        {/* ✅ Shared Filter Card */}
        <div className="mb-4">
          <FilterDataCard
            context="products"
            selectedTab={selectedTab}
            setSelectedTab={setSelectedTab}
            selectedValue={selectedValue}
            setSelectedValue={setSelectedValue}
            listData={brands}
            selectedIds={selectedProductIds}
            setSelectedIds={setSelectedProductIds}
            selectedBrandIds={selectedBrandIds}
            setSelectedBrandIds={setSelectedBrandIds}
          />
        </div>

        {/* Sub-Products Analytics pages */}
        {activeTab === "analysis" && (
          <AnalyticsProductsAnalysis
            selectedTab={selectedTab}
            selectedValue={selectedValue}
            brands={brands}
            selectedBrandIds={selectedBrandIds}
            selectedProductIds={selectedProductIds}
            analysisData={analysisData}
            setAnalysisData={setAnalysisData}
          />
        )}
        {activeTab === "comparison" && (
          <AnalyticsProductsComparison
            selectedTab={selectedTab}
            selectedValue={selectedValue}
            brands={brands}
            selectedBrandIds={selectedBrandIds}
            selectedProductIds={selectedProductIds}
            analysisData={analysisData}
            setAnalysisData={setAnalysisData}
          />
        )}
      </div>
    </div>
  );
};

export default AnalyticsProducts;
