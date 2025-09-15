import { useMemo, forwardRef } from "react";
import GlobalChart from "./GlobalChart";
import { barChartBaseConfig } from "../../data/chartConfig";

const SalesComparisonChartCard = forwardRef(
  ({ tab, value, chartData }, ref) => {
    // ✅ Memoized chart options
    const chartOptions = useMemo(
      () => ({
        ...barChartBaseConfig.options,
        scales: {
          ...barChartBaseConfig.options.scales,
          y: { display: false },
          y1: {
            type: "linear",
            position: "left",
            title: { display: true, text: "Sales (PKR)", color: "#BEB7DF" },
            ticks: { color: "#b0b0b0" },
            grid: { color: "#38384a" },
          },
          y2: {
            type: "linear",
            position: "right",
            title: { display: true, text: "Orders", color: "#BEB7DF" },
            ticks: { color: "#b0b0b0" },
            grid: { drawOnChartArea: false },
            alignTo: "y1",
          },
        },
      }),
      []
    );

    return (
      <div
        ref={ref}
        className="bg-[#252538] rounded-xl p-6 border border-[#38384a] hover:border-[#8a4fff]/50 transition-colors duration-300"
      >
        <h3 className="text-sm font-medium text-[#BEB7DF] mb-4">
          Sales vs Orders Comparison ({tab?.toUpperCase()} - {value || "All"})
        </h3>

        <GlobalChart
          type="bar"
          labels={chartData.labels}
          datasets={chartData.datasets}
          options={chartOptions}
        />
      </div>
    );
  }
);

export default SalesComparisonChartCard;
