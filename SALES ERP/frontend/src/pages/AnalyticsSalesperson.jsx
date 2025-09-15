// import { startOfWeek, addWeeks, format } from "date-fns";
// import { useState, useEffect, useMemo, useRef } from "react";
// import { useToast } from "../context/ToastContext";
// import {
//   SpinnerLoader,
//   CustomDropdown,
//   DownloadButton,
//   SalesComparisonChartCard,
// } from "../components";
// import analyticsService from "../services/analyticsService";

// const AnalyticsSalesperson = ({
//   selectedTab,
//   selectedValue,
//   salespersons,
//   selectedSalespersonIds,
//   analysisData,
//   setAnalysisData,
// }) => {
//   // State for page load
//   const [isLoading, setIsLoading] = useState(false);
//   const [error, setError] = useState(null);

//   const [selectedSalesperson1, setSelectedSalesperson1] = useState("");
//   const [selectedSalesperson2, setSelectedSalesperson2] = useState("");

//   // create refs for charts
//   const comparisonChartRef = useRef(null);

//   const { showToast } = useToast();

//   const didMount = useRef(false);

//   useEffect(() => {
//     // Skip first load - fetched in parent
//     if (!didMount.current) {
//       didMount.current = true;
//       return;
//     }

//     const fetchAnalyticsData = async () => {
//       // Don't fetch if no salespersons selected or filters are incomplete
//       if (
//         selectedSalespersonIds.length === 0 ||
//         !selectedTab ||
//         !selectedValue
//       ) {
//         setAnalysisData([]);
//         showToast("Please select all filters", "warning");
//         return;
//       }

//       try {
//         setIsLoading(true);
//         setError(null);

//         // Map UI tab values to API rangeType
//         const rangeTypeMap = {
//           year: "yearly",
//           month: "monthly",
//           week: "weekly",
//           quarter: "quarterly",
//         };
//         const rangeType = rangeTypeMap[selectedTab];

//         // Format referenceDate based on selectedTab and selectedValue
//         let referenceDate;
//         if (selectedTab === "year") {
//           referenceDate = `${selectedValue}-01-01`; // YYYY-01-01
//         } else if (selectedTab === "month") {
//           referenceDate = `${selectedValue}-01`; // YYYY-MM-01
//         } else if (selectedTab === "week") {
//           console.log("Week Date ", selectedValue);
//           // Using date-fns library
//           const year = selectedValue.substring(0, 4);
//           const weekNum = parseInt(selectedValue.substring(6));
//           // Create date for first week of the year
//           const firstWeek = startOfWeek(new Date(parseInt(year), 0, 1));
//           const targetDate = addWeeks(firstWeek, weekNum - 1);
//           referenceDate = format(targetDate, "yyyy-MM-dd");
//         } else if (selectedTab === "quarter") {
//           // Mapping to first date of selected quarter
//           const quarterMap = { Q1: "01", Q2: "04", Q3: "07", Q4: "10" };
//           const year = new Date().getFullYear(); // You might need to get year from somewhere
//           referenceDate = `${year}-${quarterMap[selectedValue]}-01`;
//         }

//         const data = await analyticsService.GetSalesAnalysis(
//           selectedSalespersonIds,
//           rangeType,
//           referenceDate
//         );

//         if (!data || data.length === 0) {
//           setAnalysisData([]);
//           showToast(
//             "No sales data available for the selected period.",
//             "warning"
//           );
//         } else {
//           setAnalysisData(data);
//           showToast("Sales Analytics data fetched", "success");
//         }
//       } catch (err) {
//         setError("Failed to load analytics data.");
//         console.error(err);
//       } finally {
//         setIsLoading(false);
//       }
//     };
//     fetchAnalyticsData();
//   }, [selectedSalespersonIds, selectedTab, selectedValue]);

//   // Group data by salesperson
//   const groupedData = useMemo(() => {
//     if (!analysisData || analysisData.length === 0) return {};

//     return analysisData.reduce((acc, curr) => {
//       if (!acc[curr.salesPersonId]) {
//         acc[curr.salesPersonId] = {
//           id: curr.salesPersonId,
//           name: curr.salesPersonName,
//           totalSales: 0,
//           totalOrders: 0,
//           totalContribution: 0,
//         };
//       }
//       acc[curr.salesPersonId].totalSales += curr.totalSales;
//       acc[curr.salesPersonId].totalOrders += curr.totalOrders;
//       acc[curr.salesPersonId].totalContribution += curr.percentOfTotal;
//       return acc;
//     }, {});
//   }, [analysisData]);

//   // Compare two salespersons
//   const chartData = useMemo(() => {
//     if (!selectedSalesperson1 || !selectedSalesperson2) return null;
//     if (selectedSalesperson1 === selectedSalesperson2) return null;

//     const sp1 = groupedData[selectedSalesperson1];
//     const sp2 = groupedData[selectedSalesperson2];

//     if (!sp1 || !sp2) return null;

//     return {
//       labels: [sp1.name, sp2.name],
//       datasets: [
//         {
//           label: "Sales (PKR)",
//           data: [sp1.totalSales, sp2.totalSales],
//           backgroundColor: "rgba(0, 117, 149, 0.25)",
//           borderColor: "#00b8db",
//           borderWidth: 2,
//           yAxisID: "y1",
//         },
//         {
//           label: "Orders",
//           data: [sp1.totalOrders, sp2.totalOrders],
//           backgroundColor: "rgba(112, 8, 231, 0.5)",
//           borderColor: "#8e51ff",
//           borderWidth: 2,
//           yAxisID: "y2",
//         },
//       ],
//     };
//   }, [selectedSalesperson1, selectedSalesperson2, groupedData]);

//   // ✅ Dropdown options restricted to selectedSalespersonIds only
//   const filteredSalespersons = salespersons.filter((sp) =>
//     selectedSalespersonIds.includes(sp.id)
//   );

//   return isLoading == true ? (
//     <SpinnerLoader label="Loading analytics..." />
//   ) : (
//     <div className="space-y-6 min-h-full">
//       {/* Selection Row */}
//       <div className="flex flex-col md:flex-row gap-4 items-center justify-center">
//         {/* Salesperson 1 dropdown */}
//         <CustomDropdown
//           selectedValue={
//             filteredSalespersons.find((sp) => sp.id === selectedSalesperson1)
//               ?.username || "Select Salesperson 1"
//           }
//           onSelect={(value) => setSelectedSalesperson1(value)}
//           options={filteredSalespersons.map((sp) => ({
//             value: sp.id,
//             label: sp.username || sp.name,
//           }))}
//           placeholder="Select Salesperson 1"
//         />

//         {/* Salesperson 2 dropdown */}
//         <CustomDropdown
//           selectedValue={
//             filteredSalespersons.find((sp) => sp.id === selectedSalesperson2)
//               ?.username || "Select Salesperson 2"
//           }
//           onSelect={(value) => setSelectedSalesperson2(value)}
//           options={filteredSalespersons.map((sp) => ({
//             value: sp.id,
//             label: sp.username || sp.name,
//           }))}
//           placeholder="Select Salesperson 2"
//         />

//         <button
//           className="bg-[#8a4fff] text-white px-4 py-2 rounded-lg hover:bg-[#7935e0] transition-colors"
//           onClick={() => {
//             if (!selectedSalesperson1 || !selectedSalesperson2) {
//               showToast("Please select both salespersons to compare.", "info");
//               return;
//             }
//             if (selectedSalesperson1 === selectedSalesperson2) {
//               showToast(
//                 "Please select two different salespersons to compare.",
//                 "info"
//               );
//               return;
//             }
//             // ✅ no setChartData anymore, just rely on memo
//             showToast("Comparison updated", "success");
//           }}
//         >
//           Compare
//         </button>
//       </div>

//       {/* Chart Section */}
//       {chartData && (
//         <div className="space-y-4">
//           <div className="flex items-center justify-end">
//             <DownloadButton
//               type="pdf"
//               title={`Sales Comparison Report (${selectedTab}ly)`}
//               chartRefs={[comparisonChartRef]}
//             />
//           </div>
//           <div className="grid grid-cols-1 gap-6">
//             <SalesComparisonChartCard
//               ref={comparisonChartRef}
//               tab={selectedTab}
//               value={selectedValue}
//               chartData={chartData}
//             />
//           </div>
//         </div>
//       )}
//     </div>
//   );
// };

// export default AnalyticsSalesperson;

import { startOfWeek, addWeeks, format } from "date-fns";
import { useState, useEffect, useMemo, useRef } from "react";
import { useToast } from "../context/ToastContext";
import {
  SpinnerLoader,
  CustomDropdown,
  DownloadButton,
  SalesComparisonChartCard,
} from "../components";
import analyticsService from "../services/analyticsService";

const AnalyticsSalesperson = ({
  selectedTab,
  selectedValue,
  salespersons,
  selectedSalespersonIds,
  analysisData,
  setAnalysisData,
}) => {
  const [isLoading, setIsLoading] = useState(false);
  const [error, setError] = useState(null);

  // ✅ Salesperson 1 defaults to first in filtered list
  const [selectedSalesperson1, setSelectedSalesperson1] = useState(null);
  const [selectedSalesperson2, setSelectedSalesperson2] = useState(null);

  const comparisonChartRef = useRef(null);
  const { showToast } = useToast();
  const didMount = useRef(false);

  useEffect(() => {
    if (!didMount.current) {
      didMount.current = true;
      return;
    }

    const fetchAnalyticsData = async () => {
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

        const data = await analyticsService.GetSalesAnalysis(
          selectedSalespersonIds,
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
          showToast("Sales Analytics data fetched", "success");
        }
      } catch (err) {
        setError("Failed to load analytics data.");
        console.error(err);
      } finally {
        setIsLoading(false);
      }
    };
    fetchAnalyticsData();
  }, [selectedSalespersonIds, selectedTab, selectedValue]);

  // ✅ Restrict to selectedSalespersonIds only
  const filteredSalespersons = useMemo(
    () => salespersons.filter((sp) => selectedSalespersonIds.includes(sp.id)),
    [salespersons, selectedSalespersonIds]
  );

  // ✅ Default Salesperson1 when data is ready
  useEffect(() => {
    if (filteredSalespersons.length > 0 && !selectedSalesperson1) {
      setSelectedSalesperson1(filteredSalespersons[0].id);
    }
  }, [filteredSalespersons, selectedSalesperson1]);

  // Group data by salesperson
  const groupedData = useMemo(() => {
    if (!analysisData || analysisData.length === 0) return {};
    return analysisData.reduce((acc, curr) => {
      if (!acc[curr.salesPersonId]) {
        acc[curr.salesPersonId] = {
          id: curr.salesPersonId,
          name: curr.salesPersonName,
          totalSales: 0,
          totalOrders: 0,
          totalContribution: 0,
        };
      }
      acc[curr.salesPersonId].totalSales += curr.totalSales;
      acc[curr.salesPersonId].totalOrders += curr.totalOrders;
      acc[curr.salesPersonId].totalContribution += curr.percentOfTotal;
      return acc;
    }, {});
  }, [analysisData]);

  // Build chart data automatically
  const chartData = useMemo(() => {
    if (!selectedSalesperson1 || !selectedSalesperson2) {
      showToast("Please Select both salespersons to compare");
      return null;
    }
    if (selectedSalesperson1 === selectedSalesperson2) {
      showToast("Please select different salesperson for comaprison");
      return null;
    }

    const sp1 = groupedData[selectedSalesperson1];
    const sp2 = groupedData[selectedSalesperson2];
    if (!sp1 || !sp2) return null;

    showToast("Comparison Updated", "success");
    return {
      labels: [sp1.name, sp2.name],
      datasets: [
        {
          label: "Sales (PKR)",
          data: [sp1.totalSales, sp2.totalSales],
          backgroundColor: "rgba(0, 117, 149, 0.25)",
          borderColor: "#00b8db",
          borderWidth: 2,
          yAxisID: "y1",
        },
        {
          label: "Orders",
          data: [sp1.totalOrders, sp2.totalOrders],
          backgroundColor: "rgba(112, 8, 231, 0.5)",
          borderColor: "#8e51ff",
          borderWidth: 2,
          yAxisID: "y2",
        },
      ],
    };
  }, [selectedSalesperson1, selectedSalesperson2, groupedData]);

  return isLoading ? (
    <SpinnerLoader label="Loading analytics..." />
  ) : (
    <div className="space-y-6 min-h-full">
      {/* Selection Row */}
      <div className="flex flex-col md:flex-row gap-4 items-center justify-center">
        {/* Salesperson 1 dropdown - defaulted */}
        <CustomDropdown
          selectedValue={
            filteredSalespersons.find((sp) => sp.id === selectedSalesperson1)
              ?.username || "Select Salesperson"
          }
          onSelect={(value) => setSelectedSalesperson1(value)}
          options={filteredSalespersons.map((sp) => ({
            value: sp.id,
            label: sp.username || sp.name,
          }))}
        />

        {/* Salesperson 2 dropdown - placeholder */}
        <CustomDropdown
          selectedValue={
            filteredSalespersons.find((sp) => sp.id === selectedSalesperson2)
              ?.username || "Select Salesperson to compare"
          }
          onSelect={(value) => setSelectedSalesperson2(value)}
          options={filteredSalespersons.map((sp) => ({
            value: sp.id,
            label: sp.username || sp.name,
          }))}
          placeholder="Select Salesperson to Compare"
        />
      </div>

      {/* Chart Section */}
      {chartData && (
        <div className="space-y-4">
          <div className="flex items-center justify-end">
            <DownloadButton
              type="pdf"
              title={`Sales Comparison Report (${selectedTab}ly)`}
              chartRefs={[comparisonChartRef]}
            />
          </div>
          <div className="grid grid-cols-1 gap-6">
            <SalesComparisonChartCard
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

export default AnalyticsSalesperson;
