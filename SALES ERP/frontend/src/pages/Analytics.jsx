import { format } from "date-fns";
import { useState, useEffect } from "react";
import { useToast } from "../context/ToastContext";
import { SpinnerLoader, AnalyticsTabs, FilterDataCard } from "../components";
import AnalyticsSales from "./AnalyticsSales";
import AnalyticsProducts from "./AnalyticsProducts";
import AnalyticsSalesperson from "./AnalyticsSalesperson";
import analyticsService from "../services/analyticsService";

const Analytics = () => {
  const [isLoading, setIsLoading] = useState(false);
  const [activeTab, setActiveTab] = useState("sales");
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
    <SpinnerLoader label="Loading analytics..." />
  ) : (
    <div className="flex flex-col min-h-[84.6vh]">
      <div className="flex-1">
        {/* Tabs only control state */}
        <AnalyticsTabs activeTab={activeTab} onTabChange={setActiveTab} />

        {/* ✅ Shared Filter Card */}
        <div className="mb-4">
          <FilterDataCard
            selectedTab={selectedTab}
            setSelectedTab={setSelectedTab}
            selectedValue={selectedValue}
            setSelectedValue={setSelectedValue}
            salespersons={salespersons}
            selectedSalespersonIds={selectedSalespersonIds}
            setSelectedSalespersonIds={setSelectedSalespersonIds}
          />
        </div>

        {/* Analytics decides what to render */}
        {activeTab === "sales" && (
          <AnalyticsSales
            selectedTab={selectedTab}
            selectedValue={selectedValue}
            selectedSalespersonIds={selectedSalespersonIds}
            analysisData={analysisData}
            setAnalysisData={setAnalysisData}
          />
        )}
        {activeTab === "salespersons" && (
          <AnalyticsSalesperson
            selectedTab={selectedTab}
            selectedValue={selectedValue}
            salespersons={salespersons}
            selectedSalespersonIds={selectedSalespersonIds}
            analysisData={analysisData}
            setAnalysisData={setAnalysisData}
          />
        )}
        {activeTab === "products" && (
          <AnalyticsProducts
            selectedTab={selectedTab}
            // setSelectedTab={setSelectedTab}
            selectedValue={selectedValue}
            // setSelectedValue={setSelectedValue}
            // salespersons={salespersons}
            selectedSalespersonIds={selectedSalespersonIds}
            setSelectedSalesIds={setSelectedSalespersonIds}
            setSalespersons={setSalespersons}
          />
        )}
      </div>
    </div>
  );
};

export default Analytics;
