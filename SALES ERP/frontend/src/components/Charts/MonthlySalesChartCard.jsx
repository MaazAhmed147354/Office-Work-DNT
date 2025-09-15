import GlobalChart from "./GlobalChart";
import { barChartBaseConfig } from "../../data/chartConfig";
import { useMemo, useCallback } from "react";

const MonthlySalesChartCard = ({ data }) => {
  const labels = useMemo(() => data.map((item) => item.monthName), [data]);
  const sales = useMemo(() => data.map((item) => item.totalSales), [data]);

  const chartData = useMemo(
    () => ({
      labels,
      datasets: [
        {
          label: "Sales (PKR)",
          data: sales,
          backgroundColor: [
            "rgba(173,70,255,0.25)",
            "rgba(0,117,149,0.25)",
            "rgba(112,8,231,0.5)",
          ],
          borderColor: ["#c27aff", "#00b8db", "#8e51ff"],
          borderWidth: 2,
          borderRadius: 5,
        },
      ],
    }),
    [labels, sales]
  );

  // stable tooltip callback
  const tooltipLabel = useCallback((context) => {
    if (context.dataset.label && context.dataset.label.includes("Sales")) {
      return `${context.raw.toLocaleString()} PKR`;
    }
    return `${context.raw} Orders`;
  }, []);

  const chartOptions = useMemo(
    () => ({
      ...barChartBaseConfig.options,
      responsive: true,
      plugins: {
        ...barChartBaseConfig.options.plugins,
        legend: { display: false },
        tooltip: {
          ...barChartBaseConfig.options.plugins.tooltip,
          callbacks: {
            label: tooltipLabel,
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
      },
    }),
    [tooltipLabel]
  );

  return (
    <div className="bg-[#252538] rounded-xl p-6 border border-[#38384a] hover:border-[#8a4fff]/50 transition-colors duration-300">
      <h3 className="text-sm font-medium text-[#BEB7DF] mb-4">
        Monthly Sales Trend (2025)
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

export default MonthlySalesChartCard;
