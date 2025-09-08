import { parseISO, format, startOfWeek, addWeeks } from "date-fns";
import { useState, useEffect, useMemo } from "react";
import {
  SpinnerLoader,
  FilterDataCard,
  SalesAnalyticsChartCard,
  Accordion,
  SalesContributionChartCard,
  RadarChartCard,
  CustomToast,
} from "../components";
import AnalyticsService from "../services/analyticsService";

const AnalyticsSales = () => {
  // State for date filters
  const [selectedTab, setSelectedTab] = useState("year");
  const [selectedValue, setSelectedValue] = useState(null);
  // State for salesperson filter
  const [salespersons, setSalespersons] = useState([]); // Fetched list from API
  const [selectedSalesIds, setSelectedSalesIds] = useState([]);
  // State for sales data
  const [analysisData, setAnalysisData] = useState([]); // Raw data from GetSalesAnalysis
  const [isLoading, setIsLoading] = useState(false);
  const [error, setError] = useState(null);

  const [showToast, setShowToast] = useState(false);
  const [toastMessage, setToastMessage] = useState("");
  const [toastType, setToastType] = useState("info");

  // Fetch salespersons on component mount
  useEffect(() => {
    const fetchSalespersons = async () => {
      try {
        setIsLoading(true);
        const data = await AnalyticsService.getSalespersonList();
        console.log("SalesPersonList: ", data);

        setSalespersons(data);

        // Initialize selection with all salespersons
        const initialIds = data.map((sp) => sp.id);
        setSelectedSalesIds(initialIds);
      } catch (err) {
        setError("Failed to load salespersons.");
        console.error(err);
      } finally {
        setIsLoading(false);
      }
    };

    fetchSalespersons();
  }, []);

  // Fetch analytics data when filters change
  useEffect(() => {
    const fetchAnalyticsData = async () => {
      // Don't fetch if no salespersons selected or filters are incomplete
      if (selectedSalesIds.length === 0 || !selectedTab || !selectedValue) {
        setToastMessage("Please select at least one salesperson.");
        setToastType("warning");
        setShowToast(true);
        setAnalysisData([]); // Clear previous data
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

        const data = await AnalyticsService.GetSalesAnalysis(
          selectedSalesIds,
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
  }, [selectedTab, selectedValue, selectedSalesIds]);

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
        {/* Filter Sections */}
        <div className="mb-6">
          <FilterDataCard
            selectedTab={selectedTab}
            setSelectedTab={setSelectedTab}
            selectedValue={selectedValue}
            setSelectedValue={setSelectedValue}
            salespersons={salespersons}
            selectedSalesIds={selectedSalesIds}
            setSelectedSalesIds={setSelectedSalesIds}
          />
        </div>

        {/* Chart Section */}
        <div className="grid grid-cols-2 grid-rows-2 md:grid-rows-1 gap-6 mb-6">
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
          <div>
            <RadarChartCard />
          </div>
        </div>

        {/* Accordions */}
        <div className="grid grid-cols-1 gap-6">
          <Accordion data={accordionData} />
        </div>
      </div>
      {/* Toast */}
      {showToast && (
        <CustomToast
          message={toastMessage}
          type={toastType}
          onClose={() => setShowToast(false)}
        />
      )}
    </div>
  );
};

export default AnalyticsSales;
