import { useMemo, forwardRef } from "react";
import GlobalChart from "./GlobalChart";
import { polarAreaChartBaseConfig } from "../../data/chartConfig";

const SalesContributionChartCard = forwardRef(({ tab, value, data }, ref) => {
  // ✅ Memoized labels & contributions
  const labels = useMemo(() => data.map((item) => item.label), [data]);
  const contribution = useMemo(
    () => data.map((item) => item.totalContribution),
    [data]
  );

  // ✅ Memoized chart data
  const chartData = useMemo(
    () => ({
      labels,
      datasets: [
        {
          label: `Contribution %`,
          data: contribution,
          backgroundColor: [
            "rgba(173, 70, 255, 0.25)",
            "rgba(0, 117, 149, 0.25)",
            "rgba(112, 8, 231, 0.5)",
            "rgba(0, 132, 209, 0.6)",
          ],
          borderColor: ["#c27aff", "#00b8db", "#8e51ff", "#0084d1"],
          borderWidth: 2,
        },
      ],
    }),
    [labels, contribution]
  );

  // ✅ Memoized chart options
  const chartOptions = useMemo(
    () => ({
      ...polarAreaChartBaseConfig.options,
      scales: {
        r: {
          ...polarAreaChartBaseConfig.options.scales.r,
          ticks: { display: false, backdropColor: "transparent" },
          grid: { color: "#38384a" },
          angleLines: { color: "#38384a" },
          pointLabels: {
            color: "#BEB7DF",
            font: { size: 11 },
          },
        },
      },
      plugins: {
        ...polarAreaChartBaseConfig.options.plugins,
        legend: {
          ...polarAreaChartBaseConfig.options.plugins.legend,
          labels: {
            color: "#BEB7DF",
            font: { size: 12 },
            padding: 15,
          },
        },
      },
    }),
    []
  );

  return (
    <div
      ref={ref}
      className="bg-[#252538] rounded-xl p-6 border border-[#38384a] hover:border-[#8a4fff]/50"
    >
      <h3 className="text-sm font-medium text-[#BEB7DF] mb-4">
        Percentage Contribution ({tab?.toUpperCase()} - {value || "All"})
      </h3>
      <GlobalChart
        type="polarArea"
        labels={chartData.labels}
        datasets={chartData.datasets}
        options={chartOptions}
      />
    </div>
  );
});

export default SalesContributionChartCard;
