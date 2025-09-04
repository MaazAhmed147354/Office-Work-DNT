import GlobalChart from "./GlobalChart";
import { barChartBaseConfig } from "../../data/chartConfig";

const SalesPersonChartCard = ({ data }) => {
  // if (!data || data.length === 0) {
  //   return (
  //     <div className="bg-[#252538] rounded-xl p-6 border border-[#38384a] text-gray-400 text-sm">
  //       No salesperson sales data available
  //     </div>
  //   );
  // }

  // format labels + dataset
  const labels = data.map((item) => item.salesPersonName || "Unknown");
  const sales = data.map((item) => item.totalSales || 0);

  const chartData = {
    labels,
    datasets: [
      {
        label: "Total Sales",
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
        Sales by Salesperson
      </h3>
      <GlobalChart
        type="bar"
        labels={chartData.labels}
        datasets={chartData.datasets}
        options={{
          ...barChartBaseConfig.options,
          indexAxis: "y", // horizontal bars
          plugins: {
            ...barChartBaseConfig.options.plugins,
            legend: { display: false },
            tooltip: {
              ...barChartBaseConfig.options.plugins.tooltip,
              callbacks: {
                label: (context) =>
                  `${context.formattedValue.toLocaleString()} PKR`,
              },
            },
          },
          scales: {
            ...barChartBaseConfig.options.scales,
            x: {
              ...barChartBaseConfig.options.scales.x,
              ticks: {
                color: "#b0b0b0",
                callback: function (value) {
                  return value >= 1_000_000
                    ? value / 1_000_000 + "M"
                    : value >= 1_000
                    ? value / 1_000 + "K"
                    : value;
                },
              },
            },
            y: {
              ...barChartBaseConfig.options.scales.y,
              grid: { display: false },
            },
          },
        }}
      />
    </div>
  );
};

export default SalesPersonChartCard;
