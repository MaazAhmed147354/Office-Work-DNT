import { useState } from "react";
import KpiCarousel from "../components/KpiCarousel"; // Adjust path if needed
import { kpis } from "./../data/kips"; // Your KPI mock/data
import { kpiChartData } from "./../data/kips";
import LineChart from "../charts/LineChart";
import BarChart from "../charts/BarChart";
import PieChart from "../charts/PieChart";

export default function Dashboard() {
  const [selected, setSelected] = useState(0);
  const selectedKpi = kpiChartData[selected];

  const renderChart = (kpi) => {
    const commonProps = {
      data: {
        labels: kpi.labels,
        datasets: [
          {
            label: kpi.title,
            data: kpi.data,
            backgroundColor: [
              "rgba(96, 165, 250, 0.4)", // blue-400
              "rgba(255, 255, 255, 0.1)",
              "rgba(30, 41, 59, 0.3)", // slate-800
              "rgba(0, 0, 0, 0.2)",
            ],
            borderColor: "#60a5fa",
            borderWidth: 2,
          },
        ],
      },
      options: kpi.options,
    };

    switch (kpi.type) {
      case "line":
        return <LineChart {...commonProps} />;
      case "bar":
        return <BarChart {...commonProps} />;
      case "pie":
        return <PieChart {...commonProps} />;
      default:
        return null;
    }
  };

  return (
    <div className="p-0">
      <h2 className="text-2xl font-semibold mb-2 text-[#f8fafc]">KPIs</h2>

      {/* KPI Card Carousel */}
      <div className="flex gap-4 overflow-x-auto p-4">
        <KpiCarousel kpis={kpis} onSelect={setSelected} />
      </div>

      {/* Chart for selected KPI */}
      <div className="mt-2 p-8 bg-[#60a5fa]/20 text-[#f8fafc] rounded-2xl shadow-xl max-w-md mx-auto ring-2 ring-[#60a5fa] scale-[1.02]">
        <h3 className="text-lg font-semibold mb-2 text-black">
          {selectedKpi.title}
        </h3>
        <div className="min-w-full min-h-fit bg-white/5 p-3 shadow-xl rounded-xl">
          {renderChart(selectedKpi)}
        </div>
      </div>
    </div>
  );
}
