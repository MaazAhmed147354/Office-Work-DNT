import GlobalChart from "./GlobalChart";

const SalesAnalyticsChartCard = ({ tab, value, data }) => {
  //   if (!data || data.length === 0) {
  //     return (
  //       <div className="bg-[#252538] rounded-xl p-6 border border-[#38384a] text-gray-400 text-sm">
  //         No sales data available
  //       </div>
  //     );
  //   }
  console.log("Chart Data: ", data);
  
  const labels = data.map((item) => item.label);
  const sales = data.map((item) => item.totalSales);
  console.log("Sales Tab: ", tab);

  const chartData = {
    labels,
    datasets: [
      {
        label: `Sales (${tab} - ${value || "All"})`,
        data: sales,
        backgroundColor: [
          "rgb(173, 70, 255, 0.25)",
          "rgb(0, 117, 149, 0.25)",
          "rgb(112, 8, 231, 0.5)",
        ],
        borderColor: ["#c27aff", "#00b8db", "#8e51ff"],
        borderWidth: 2,
        borderRadius: 5,
      },
    ],
  };

  return (
    <div className="bg-[#252538] rounded-xl p-6 border border-[#38384a] hover:border-[#8a4fff]/50 transition-colors duration-300">
      <h3 className="text-sm font-medium text-[#BEB7DF] mb-4">
        Sales Analytics ({tab?.toUpperCase()} - {value || "All"})
      </h3>
      <GlobalChart
        type="bar"
        labels={chartData.labels}
        datasets={chartData.datasets}
      />
    </div>
  );
};

export default SalesAnalyticsChartCard;
