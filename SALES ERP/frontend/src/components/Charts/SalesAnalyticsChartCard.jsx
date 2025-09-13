import GlobalChart from "./GlobalChart";
import { forwardRef } from "react";

const SalesAnalyticsChartCard = forwardRef(({ tab, value, data }, ref) => {
  const labels = data.map((item) => item.label);
  const sales = data.map((item) => item.totalSales);

  const chartData = {
    labels,
    datasets: [
      {
        label: `Sales (${tab} - ${value || "All"})`,
        data: sales,
        backgroundColor: [
          "rgb(173, 70, 255, 0.25)",
          "rgb(0, 117, 149, 0.25)",
          "rgb(112, 8, 231, 0.25)",
          "rgb(0, 132, 209, 0.25)",
        ],
        borderColor: ["#c27aff", "#00b8db", "#8e51ff", "#0084d1"],
        borderWidth: 2,
        borderRadius: 5,
      },
    ],
  };

  return (
    <div
      ref={ref}
      className="bg-[#252538] rounded-xl p-6 border border-[#38384a] hover:border-[#8a4fff]/50 transition-colors duration-300"
    >
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
});

export default SalesAnalyticsChartCard;
