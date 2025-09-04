import GlobalChart from "./GlobalChart";
import { polarAreaChartBaseConfig } from "../../data/chartConfig";
import { polarAreaData } from "../../data/chartData";

const PolarAreaChartCard = ({ className = "" }) => {
  return (
    <div
      className={`bg-[#252538] rounded-xl p-6 border border-[#38384a] hover:border-[#8a4fff]/50 ${className}`}
    >
      <h3 className="text-lg font-semibold text-[#BEB7DF] mb-4">
        Technology Usage
      </h3>
      <div className="h-64">
        <GlobalChart
          type="polarArea"
          labels={polarAreaData.labels}
          datasets={polarAreaData.datasets}
          options={polarAreaChartBaseConfig.options}
        />
      </div>
    </div>
  );
};

export default PolarAreaChartCard;
