import { useMemo, useCallback, forwardRef } from "react";
import GlobalChart from "./GlobalChart";
import { barChartBaseConfig } from "../../data/chartConfig";

const AnalyticsChartCard = forwardRef(({ tab, value, data }, ref) => {
  // ✅ Memoized labels & sales
  const labels = useMemo(() => data.map((item) => item.label), [data]);
  const sales = useMemo(() => data.map((item) => item.totalSales), [data]);

  // ✅ Memoized chart data
  const chartData = useMemo(
    () => ({
      labels,
      datasets: [
        {
          label: `Sales (${tab} - ${value || "All"})`,
          data: sales,
          backgroundColor: [
            "rgba(173, 70, 255, 0.25)",
            "rgba(0, 117, 149, 0.25)",
            "rgba(112, 8, 231, 0.25)",
            "rgba(0, 132, 209, 0.25)",
          ],
          borderColor: ["#c27aff", "#00b8db", "#8e51ff", "#0084d1"],
          borderWidth: 2,
          borderRadius: 5,
        },
      ],
    }),
    [labels, sales, tab, value]
  );

  // ✅ Memoized tooltip
  const tooltipLabel = useCallback(
    (context) => `${context.raw.toLocaleString()} PKR`,
    []
  );

  // ✅ Memoized chart options
  const chartOptions = useMemo(
    () => ({
      ...barChartBaseConfig.options,
      plugins: {
        ...barChartBaseConfig.options.plugins,
        legend: { display: false },
        tooltip: {
          ...barChartBaseConfig.options.plugins.tooltip,
          callbacks: { label: tooltipLabel },
        },
      },
      scales: {
        ...barChartBaseConfig.options.scales,
        x: {
          ...barChartBaseConfig.options.scales.x,
          ticks: { color: "#b0b0b0" },
        },
        y: {
          ...barChartBaseConfig.options.scales.y,
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
      },
    }),
    [tooltipLabel]
  );

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
        customHeight="h-96"
        labels={chartData.labels}
        datasets={chartData.datasets}
        options={chartOptions}
      />
    </div>
  );
});

export default AnalyticsChartCard;
