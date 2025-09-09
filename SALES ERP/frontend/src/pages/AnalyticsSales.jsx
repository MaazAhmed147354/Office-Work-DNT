import { format, startOfWeek, addWeeks } from "date-fns";
import { useState, useEffect, useMemo, useRef } from "react";
import { useToast } from "../context/ToastContext";
import {
  SpinnerLoader,
  ViewToggle,
  SalesAnalyticsChartCard,
  Accordion,
  SalesContributionChartCard,
} from "../components";
import analyticsService from "../services/analyticsService";

const AnalyticsSales = ({
  selectedTab,
  selectedValue,
  selectedSalespersonIds,
  analysisData,
  setAnalysisData,
}) => {
  // State for page load
  const [isLoading, setIsLoading] = useState(false);
  const [error, setError] = useState(null);

  const [viewMode, setViewMode] = useState("graphical");

  const { showToast } = useToast();

  const didMount = useRef(false);

  // Fetch analytics data when filters change
  useEffect(() => {
    // Skip first load - handled in parent
    if (!didMount.current) {
      didMount.current = true;
      return;
    }

    const fetchAnalyticsData = async () => {
      console.log("Initial fetch hi hai, you cant do anything");

      // Don't fetch if no salespersons selected or filters are incomplete
      if (
        selectedSalespersonIds.length === 0 ||
        !selectedTab ||
        !selectedValue
      ) {
        setAnalysisData([]);
        showToast("Please select all filters", "warning");
        return;
      }

      try {
        setIsLoading(true);
        setError(null);

        // Map UI tab values to API rangeType
        const rangeTypeMap = {
          year: "yearly",
          month: "monthly",
          week: "weekly",
          quarter: "quarterly",
        };
        const rangeType = rangeTypeMap[selectedTab];

        // Format referenceDate based on selectedTab and selectedValue
        let referenceDate;
        if (selectedTab === "year") {
          referenceDate = `${selectedValue}-01-01`; // YYYY-01-01
        } else if (selectedTab === "month") {
          referenceDate = `${selectedValue}-01`; // YYYY-MM-01
        } else if (selectedTab === "week") {
          console.log("Week Date ", selectedValue);
          // Using date-fns library
          const year = selectedValue.substring(0, 4);
          const weekNum = parseInt(selectedValue.substring(6));
          // Create date for first week of the year
          const firstWeek = startOfWeek(new Date(parseInt(year), 0, 1));
          const targetDate = addWeeks(firstWeek, weekNum - 1);
          referenceDate = format(targetDate, "yyyy-MM-dd");
        } else if (selectedTab === "quarter") {
          // Mapping to first date of selected quarter
          const quarterMap = { Q1: "01", Q2: "04", Q3: "07", Q4: "10" };
          const year = new Date().getFullYear(); // You might need to get year from somewhere
          referenceDate = `${year}-${quarterMap[selectedValue]}-01`;
        }

        const data = await analyticsService.GetSalesAnalysis(
          selectedSalespersonIds,
          rangeType,
          referenceDate
        );

        setAnalysisData(data);
      } catch (err) {
        setError("Failed to load analytics data.");
        console.error(err);
      } finally {
        setIsLoading(false);
      }
    };

    fetchAnalyticsData();
  }, [selectedTab, selectedValue, selectedSalespersonIds]);

  // Transform raw API data for the chart (grouped by salesperson)
  const chartData = useMemo(() => {
    if (!analysisData || analysisData.length === 0) return [];

    const groupedData = Object.values(
      analysisData.reduce((acc, curr) => {
        if (!acc[curr.salesPersonId]) {
          acc[curr.salesPersonId] = {
            salesPersonId: curr.salesPersonId,
            salesPersonName: curr.salesPersonName,
            totalSales: 0,
            totalOrders: 0,
            totalContribution: 0,
          };
        }
        acc[curr.salesPersonId].totalSales += curr.totalSales;
        acc[curr.salesPersonId].totalOrders += curr.totalOrders;
        acc[curr.salesPersonId].totalContribution += curr.percentOfTotal;
        return acc;
      }, {})
    );

    // Format for the chart component
    return groupedData.map((person) => ({
      label: person.salesPersonName,
      totalSales: person.totalSales,
      totalOrders: person.totalOrders,
      totalContribution: person.totalContribution,
      // Add other properties if needed by your chart
    }));
  }, [analysisData]);

  // Group data for accordions (each salesperson's detailed records)
  const accordionData = useMemo(() => {
    if (!analysisData || analysisData.length === 0) return [];

    // Group by salesPersonId but keep all individual records
    const grouped = analysisData.reduce((acc, curr) => {
      const key = curr.salesPersonId;
      if (!acc[key]) {
        acc[key] = {
          salesperson: curr.salesPersonName,
          sales: [],
        };
      }
      acc[key].sales.push(curr);
      return acc;
    }, {});

    console.log("Combined Data: ", Object.values(grouped));

    return Object.values(grouped);
  }, [analysisData]);

  if (error) {
    return <div>Error: {error}</div>;
  }

  return isLoading == true ? (
    <SpinnerLoader label="Loading analytics..." />
  ) : (
    <div className="flex flex-col min-h-full">
      <div className="flex-1">
        {/* View Toggle */}
        <ViewToggle onToggle={setViewMode} viewMode={viewMode} />

        {viewMode === "graphical" ? (
          /* Graphical Section */
          <div className="grid grid-cols-2 grid-rows-2 md:grid-rows-1 gap-6">
            <div className="col-span-2 lg:col-span-1">
              <SalesAnalyticsChartCard
                tab={selectedTab}
                value={selectedValue}
                data={chartData}
              />
            </div>
            <div className="col-span-2 lg:col-span-1">
              <SalesContributionChartCard
                tab={selectedTab}
                value={selectedValue}
                data={chartData}
              />
            </div>
          </div>
        ) : (
          /* Tabular Section */
          <div className="grid grid-cols-1 gap-6">
            <Accordion data={accordionData} />
          </div>
        )}
      </div>
    </div>
  );
};

export default AnalyticsSales;
