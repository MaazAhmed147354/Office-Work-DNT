import GlobalChart from "./GlobalChart";
import { polarAreaChartBaseConfig } from "../../data/chartConfig";

const SalesContributionChartCard = ({ tab, value, data }) => {
  const labels = data.map((item) => item.label);
  const contribution = data.map((item) => item.totalContribution);

  // Customize the base config for polar area chart
  const customPolarConfig = {
    ...polarAreaChartBaseConfig,
    options: {
      ...polarAreaChartBaseConfig.options,
      scales: {
        r: {
          ...polarAreaChartBaseConfig.options.scales.r,
          ticks: {
            display: false, // This hides the numbers on the axis
            backdropColor: "transparent",
          },
          grid: {
            color: "#38384a", // Grid line color
          },
          angleLines: {
            color: "#38384a", // Angle line color
          },
          pointLabels: {
            color: "#BEB7DF", // Label color around the chart
            font: {
              size: 11, // Adjust font size if needed
            },
          },
        },
      },
      plugins: {
        ...polarAreaChartBaseConfig.options.plugins,
        legend: {
          ...polarAreaChartBaseConfig.options.plugins.legend,
          labels: {
            color: "#BEB7DF",
            font: {
              size: 12,
            },
            padding: 15,
          },
        },
      },
    },
  };

  const chartData = {
    labels,
    datasets: [
      {
        label: `Contribution %`,
        data: contribution,
        backgroundColor: [
          "rgb(173, 70, 255, 0.25)",
          "rgb(0, 117, 149, 0.25)",
          "rgb(112, 8, 231, 0.5)",
          "rgb(0, 132, 209, 0.6)",
        ],
        borderColor: ["#c27aff", "#00b8db", "#8e51ff", "#0084d1"],
        borderWidth: 2, // Thin border instead of glowing effect
      },
    ],
  };

  return (
    <div className="bg-[#252538] rounded-xl p-6 border border-[#38384a] hover:border-[#8a4fff]/50">
      <h3 className="text-sm font-medium text-[#BEB7DF] mb-4">
        Percentage Contribution ({tab?.toUpperCase()} - {value || "All"})
      </h3>
      <GlobalChart
        type="polarArea"
        labels={chartData.labels}
        datasets={chartData.datasets}
        options={customPolarConfig.options}
      />
    </div>
  );
};

export default SalesContributionChartCard;
