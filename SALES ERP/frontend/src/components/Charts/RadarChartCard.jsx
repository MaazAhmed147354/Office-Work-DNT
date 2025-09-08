import GlobalChart from "./GlobalChart";
import { radarChartBaseConfig } from "../../data/chartConfig";
import { radarData } from "../../data/chartData";

const RadarChartCard = ({ className = "" }) => {
  return (
    <div
      className={`bg-[#252538] rounded-xl p-6 border border-[#38384a] hover:border-[#8a4fff]/50 ${className}`}
    >
      <h3 className="text-lg font-semibold text-[#BEB7DF] mb-4">
        Performance Comparison
      </h3>
        <div className="h-96">
          <GlobalChart
          type="radar"
          labels={radarData.labels}
          datasets={radarData.datasets}
          options={radarChartBaseConfig.options}
        />
        </div>
    </div>
  );
};

export default RadarChartCard;
