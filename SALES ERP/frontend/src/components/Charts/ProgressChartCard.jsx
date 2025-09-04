import GlobalChart from "./GlobalChart";
import { barChartBaseConfig } from "../../data/chartConfig";
import { progressData } from "../../data/chartData";

const ProgressChartCard = ({ title = "Hours spent", className = "" }) => {
  return (
    <div
      className={`bg-[#252538] rounded-xl p-6 border border-[#38384a] hover:border-[#8a4fff]/50 transition-colors duration-300 ${className}`}
    >
      <div className="flex flex-col h-full">
        <div className="mb-4">
          <h3 className="text-sm font-medium text-gray-300 mb-1">{title}</h3>
          <div className="flex items-end gap-2">
            <p className="text-2xl font-bold">22h, 40mins</p>
            <p className="text-sm text-[#8a4fff]">1.0%</p>
          </div>
        </div>
        <div className="flex-1">
          <GlobalChart
            type="bar"
            labels={progressData.labels}
            datasets={progressData.datasets}
            options={{
              ...barChartBaseConfig.options,
              plugins: {
                ...barChartBaseConfig.options.plugins,
                legend: { display: false },
                tooltip: {
                  ...barChartBaseConfig.options.plugins.tooltip,
                  callbacks: {
                    label: (context) => `${context.parsed.y} hours`,
                  },
                },
              },
              scales: {
                ...barChartBaseConfig.options.scales,
                x: {
                  ...barChartBaseConfig.options.scales.x,
                  grid: { display: false, drawBorder: false },
                },
                y: {
                  ...barChartBaseConfig.options.scales.y,
                  ticks: {
                    color: "#b0b0b0",
                    callback: function (value) {
                      return `${value}h`;
                    },
                  },
                  suggestedMin: 0,
                  suggestedMax: 12,
                },
              },
            }}
          />
        </div>
      </div>
    </div>
  );
};

export default ProgressChartCard;
