import GlobalChart from "./GlobalChart";
import { barChartBaseConfig } from "../../data/chartConfig";

const MonthlySalesChartCard = ({ data }) => {
  // if (!data || data.length === 0) {
  //   return (
  //     <div className="bg-[#252538] rounded-xl p-6 border border-[#38384a] text-gray-400 text-sm">
  //       No monthly sales data available
  //     </div>
  //   );
  // }

  const labels = data.map((item) => item.monthName);
  const sales = data.map((item) => item.totalSales);
  // const orders = data.map((item) => item.totalOrders);

  const chartData = {
    labels,
    datasets: [
      {
        label: "Sales (PKR)",
        data: sales,
        backgroundColor: [
          "rgb(173, 70, 255, 0.25)",
          "rgb(0, 117, 149, 0.25)",
          "rgb(112, 8, 231, 0.5)",
        ],
        borderColor: ["#c27aff", "#00b8db", "#8e51ff"],
        borderWidth: 2,
        borderRadius: 5,
        // yAxisID: "y", // left axis
      },
      // {
      //   label: "Orders",
      //   data: orders,
      //   backgroundColor: "#4adeff", // Cyan
      //   borderColor: "#0891b2",
      //   borderWidth: 1,
      //   yAxisID: "y1", // right axis
      // },
    ],
  };

  return (
    <div className="bg-[#252538] rounded-xl p-6 border border-[#38384a] hover:border-[#8a4fff]/50 transition-colors duration-300">
      <h3 className="text-sm font-medium text-[#BEB7DF] mb-4">
        Monthly Sales Trend (2025)
      </h3>
      <GlobalChart
        type="bar"
        labels={chartData.labels}
        datasets={chartData.datasets}
        options={{
          ...barChartBaseConfig.options,
          responsive: true,
          plugins: {
            ...barChartBaseConfig.options.plugins,
            legend: { display: false },
            tooltip: {
              ...barChartBaseConfig.options.plugins.tooltip,
              callbacks: {
                label: function (context) {
                  if (context.dataset.label.includes("Sales")) {
                    return `${context.raw.toLocaleString()} PKR`;
                  }
                  return `${context.raw} Orders`;
                },
              },
            },
          },
          scales: {
            x: {
              stacked: false,
              ticks: { color: "#b0b0b0" },
            },
            y: {
              type: "linear",
              position: "left",
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
            // y1: {
            //   type: "linear",
            //   position: "right",
            //   grid: { drawOnChartArea: false }, // prevent overlap
            //   ticks: {
            //     color: "#4adeff",
            //     callback: function (value) {
            //       return value;
            //     },
            //   },
            // },
          },
        }}
      />
    </div>
  );
};

export default MonthlySalesChartCard;

// import GlobalChart from "./GlobalChart";
// import { lineChartBaseConfig } from "../../data/chartConfig";

// const MonthlySalesChartCard = ({ data }) => {
//   const labels = data.map((item) => item.monthName);
//   const sales = data.map((item) => item.totalSales);
//   const orders = data.map((item) => item.totalOrders);

//   return (
//     <div className="bg-[#252538] rounded-xl p-6 border border-[#38384a] hover:border-[#22c55e]/50 transition-colors duration-300">
//       <h3 className="text-sm font-medium text-gray-300 mb-4">
//         Monthly Sales & Orders Trend (2025)
//       </h3>

//       <GlobalChart
//         type="line"
//         labels={labels}
//         datasets={[
//           {
//             label: "Total Sales (PKR)",
//             data: sales,
//             borderColor: "#22c55e",
//             backgroundColor: "rgba(34, 197, 94, 0.2)",
//             tension: 0.4,
//             fill: true,
//             pointBackgroundColor: "#22c55e",
//             pointBorderColor: "#fff",
//             pointRadius: 5,
//             yAxisID: "y", // left axis
//           },
//           {
//             label: "Total Orders",
//             data: orders,
//             borderColor: "#3b82f6",
//             backgroundColor: "rgba(59, 130, 246, 0.2)",
//             tension: 0.4,
//             fill: true,
//             pointBackgroundColor: "#3b82f6",
//             pointBorderColor: "#fff",
//             pointRadius: 5,
//             yAxisID: "y1", // right axis
//           },
//         ]}
//         options={{
//           ...lineChartBaseConfig.options,
//           interaction: {
//             mode: "index",
//             intersect: false,
//           },
//           stacked: false,
//           plugins: {
//             ...lineChartBaseConfig.options.plugins,
//             tooltip: {
//               ...lineChartBaseConfig.options.plugins.tooltip,
//               callbacks: {
//                 label: (context) => {
//                   if (context.dataset.label.includes("Sales")) {
//                     return `${context.raw.toLocaleString()} PKR`;
//                   }
//                   return `${context.raw.toLocaleString()} Orders`;
//                 },
//               },
//             },
//           },
//           scales: {
//             x: {
//               ...lineChartBaseConfig.options.scales?.x,
//               ticks: { color: "#b0b0b0" },
//               grid: { display: false },
//             },
//             y: {
//               type: "linear",
//               position: "left",
//               ticks: {
//                 color: "#22c55e",
//                 callback: function (value) {
//                   return value >= 1_000_000
//                     ? value / 1_000_000 + "M"
//                     : value >= 1_000
//                     ? value / 1_000 + "K"
//                     : value;
//                 },
//               },
//               grid: { drawOnChartArea: true },
//             },
//             y1: {
//               type: "linear",
//               position: "right",
//               ticks: {
//                 color: "#3b82f6",
//               },
//               grid: { drawOnChartArea: false },
//             },
//           },
//         }}
//       />
//     </div>
//   );
// };

// export default MonthlySalesChartCard;
