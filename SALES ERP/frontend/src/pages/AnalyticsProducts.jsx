import { useState } from "react";
import { SpinnerLoader, CustomTabs, FilterDataCard } from "../components";
import AnalyticsProductsAnalysis from "./AnalyticsProductsAnalysis";
import AnalyticsProductsComparison from "./AnalyticsProductsComparison";
import { dummyBrands } from "../data/analyticsData";
import analyticsService from "../services/analyticsService";

const AnalyticsProductsPage = () => {
  const [isLoading, setIsLoading] = useState(false);
  const [activeTab, setActiveTab] = useState("analysis"); // "analysis" | "comparison"

  // filters
  const [selectedTab, setSelectedTab] = useState("week");
  const [selectedValue, setSelectedValue] = useState(null);

  // brands/products
  const [brands, setBrands] = useState([]); // [{id, name, products:[...]}]
  const [selectedProductIds, setSelectedProductIds] = useState([]);

  // data state
  const [analysisData, setAnalysisData] = useState([]);

  return isLoading === true ? (
    <SpinnerLoader label="Loading product analytics..." />
  ) : (
    <div className="flex flex-col min-h-[84.6vh]">
      <div className="flex-1">
        {/* Sub Tabs */}
        <CustomTabs
          activeTab={activeTab}
          onTabChange={setActiveTab}
          tabs={[
            { id: "analysis", label: "Analysis", icon: "📊" },
            { id: "comparison", label: "Comparison", icon: "⚖️" },
          ]}
        />

        {/* Shared Filter Card */}
        <div className="mb-4">
          <FilterDataCard
            context="products"
            selectedTab={selectedTab}
            setSelectedTab={setSelectedTab}
            selectedValue={selectedValue}
            setSelectedValue={setSelectedValue}
            listData={dummyBrands}
            selectedIds={selectedProductIds}
            setSelectedIds={setSelectedProductIds}
          />
        </div>

        {/* Sub-Products Analytics pages */}
        {activeTab === "analysis" && (
          <AnalyticsProductsAnalysis
          // selectedTab={selectedTab}
          // selectedValue={selectedValue}
          // selectedProductIds={selectedProductIds}
          // analysisData={analysisData}
          // setAnalysisData={setAnalysisData}
          />
        )}

        {activeTab === "comparison" && (
          <AnalyticsProductsComparison
          // selectedTab={selectedTab}
          // selectedValue={selectedValue}
          // brands={dummyBrands}
          // selectedProductIds={selectedProductIds}
          // analysisData={analysisData}
          // setAnalysisData={setAnalysisData}
          />
        )}
      </div>
    </div>
  );
};

export default AnalyticsProductsPage;
