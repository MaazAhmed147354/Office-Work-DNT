import { format } from "date-fns";
import { useState, useEffect } from "react";
import { useToast } from "../context/ToastContext";
import { SpinnerLoader, CustomTabs, FilterDataCard } from "../components";
import AnalyticsSalespersonAnalysis from "./AnalyticsSalespersonAnalysis";
import AnalyticsSalespersonComparison from "./AnalyticsSalespersonComparison";
import analyticsService from "../services/analyticsService";

const AnalyticsSalesperson = () => {
  const [isLoading, setIsLoading] = useState(false);
  const [activeTab, setActiveTab] = useState("analysis");
  // ✅ Shared filter states
  const [selectedTab, setSelectedTab] = useState("week");
  const [selectedValue, setSelectedValue] = useState(null);
  const [salespersons, setSalespersons] = useState([]);
  const [selectedSalespersonIds, setSelectedSalespersonIds] = useState([]);
  const [analysisData, setAnalysisData] = useState([]);

  const { showToast } = useToast();

  useEffect(() => {
    // Fetch salespersons list and initial data
    const fetchInitialData = async () => {
      try {
        setIsLoading(true);

        const list = await analyticsService.getSalespersonList();
        setSalespersons(list);

        const initialIds = list.map((sp) => sp.id);
        setSelectedSalespersonIds(initialIds);

        const today = new Date();
        const referenceDate = format(today, "yyyy-MM-dd");
        // Converting todays date to week format for later fetch
        const weekValue = format(today, "yyyy-'W'II");
        setSelectedValue(weekValue);

        const data = await analyticsService.GetSalesAnalysis(
          initialIds,
          "weekly",
          referenceDate
        );
        setAnalysisData(data);

        showToast("Sales Analytics data fetched", "success");
      } catch (err) {
        console.error("Failed to load salespersons list:", err);
      } finally {
        setIsLoading(false);
      }
    };
    fetchInitialData();
  }, []);

  return isLoading == true ? (
    <SpinnerLoader label="Loading sales analytics..." />
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
            context="sales"
            selectedTab={selectedTab}
            setSelectedTab={setSelectedTab}
            selectedValue={selectedValue}
            setSelectedValue={setSelectedValue}
            listData={salespersons}
            selectedIds={selectedSalespersonIds}
            setSelectedIds={setSelectedSalespersonIds}
          />
        </div>

        {/* Sub-Sales Analytics pages */}
        {activeTab === "analysis" && (
          <AnalyticsSalespersonAnalysis
            selectedTab={selectedTab}
            selectedValue={selectedValue}
            selectedSalespersonIds={selectedSalespersonIds}
            analysisData={analysisData}
            setAnalysisData={setAnalysisData}
          />
        )}
        {activeTab === "comparison" && (
          <AnalyticsSalespersonComparison
            selectedTab={selectedTab}
            selectedValue={selectedValue}
            salespersons={salespersons}
            selectedSalespersonIds={selectedSalespersonIds}
            analysisData={analysisData}
            setAnalysisData={setAnalysisData}
          />
        )}
      </div>
    </div>
  );
};

export default AnalyticsSalesperson;
