import { useMemo, useCallback } from "react";
import GlobalChart from "./GlobalChart";
import { barChartBaseConfig } from "../../data/chartConfig";

const ProductSalesChartCard = ({ data }) => {
  // Pick top 10 products (already sliced in Dashboard, but keep safe)
  const topProducts = useMemo(() => data.slice(0, 10), [data]);

  // Memoized labels & sales
  const labels = useMemo(
    () => topProducts.map((item) => item.productName),
    [topProducts]
  );
  const sales = useMemo(
    () => topProducts.map((item) => item.totalSales),
    [topProducts]
  );

  // Memoized chart data
  const chartData = useMemo(
    () => ({
      labels,
      datasets: [
        {
          label: "Total Sales",
          data: sales,
          backgroundColor: [
            "rgba(173, 70, 255, 0.25)",
            "rgba(0, 117, 149, 0.25)",
            "rgba(112, 8, 231, 0.5)",
          ],
          borderColor: ["#c27aff", "#00b8db", "#8e51ff"],
          borderWidth: 2,
          borderRadius: 5,
        },
      ],
    }),
    [labels, sales]
  );

  // Memoized tooltip label function
  const tooltipLabel = useCallback(
    (context) => `${context.raw.toLocaleString()} PKR`,
    []
  );

  // Memoized chart options
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
          ticks: {
            color: "#b0b0b0",
            callback: function (val, index) {
              const label = labels[index];
              return label.length > 10 ? label.substring(0, 10) + "..." : label;
            },
          },
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
    [tooltipLabel, labels]
  );

  return (
    <div className="bg-[#252538] rounded-xl p-6 border border-[#38384a] hover:border-[#4adeff]/50 transition-colors duration-300">
      <h3 className="text-sm font-medium text-[#BEB7DF] mb-4">
        Top 10 Products by Sales
      </h3>
      <GlobalChart
        type="bar"
        labels={chartData.labels}
        datasets={chartData.datasets}
        options={chartOptions}
      />
    </div>
  );
};

export default ProductSalesChartCard;
