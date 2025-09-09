import { useState } from "react";
import { GlobalChart } from "../components";

const AnalyticsSalesperson = ({
  selectedTab,
  selectedValue,
  selectedSalesIds,
  setSelectedSalesIds,
  setSalespersons,
}) => {
  const [selectedSalesperson1, setSelectedSalesperson1] = useState("");
  const [selectedSalesperson2, setSelectedSalesperson2] = useState("");
  const [chartData, setChartData] = useState(null);

  const handleCompare = async () => {
    if (!selectedSalesperson1 || !selectedSalesperson2) return;

    // Prepare chart data
    setChartData({
      labels: response.map((r) => r.name),
      datasets: [
        {
          label: "Sales (PKR)",
          data: response.map((r) => r.sales),
          backgroundColor: "rgba(54, 162, 235, 0.6)",
          yAxisID: "y1",
        },
        {
          label: "Orders",
          data: response.map((r) => r.orders),
          backgroundColor: "rgba(255, 99, 132, 0.6)",
          yAxisID: "y2",
        },
      ],
    });
  };

  return (
    <div className="space-y-6">
      {/* Selection Row */}
      <div className="flex flex-col md:flex-row gap-4 items-center">
        <select
          className="border p-2 rounded w-full md:w-1/3"
          value={selectedSalesperson1}
          onChange={(e) => setSelectedSalesperson1(e.target.value)}
        >
          <option value="">Select Salesperson 1</option>
          {salespersons.map((sp) => (
            <option key={sp.id} value={sp.id}>
              {sp.name}
            </option>
          ))}
        </select>

        <select
          className="border p-2 rounded w-full md:w-1/3"
          value={selectedSalesperson2}
          onChange={(e) => setSelectedSalesperson2(e.target.value)}
        >
          <option value="">Select Salesperson 2</option>
          {salespersons.map((sp) => (
            <option key={sp.id} value={sp.id}>
              {sp.name}
            </option>
          ))}
        </select>

        <button
          className="bg-blue-600 text-white px-4 py-2 rounded hover:bg-blue-700"
          onClick={handleCompare}
        >
          Compare
        </button>
      </div>

      {/* Chart Section */}
      {chartData ? (
        <GlobalChart
          type="bar"
          labels={chartData.labels}
          datasets={chartData.datasets}
          options={{
            scales: {
              y1: {
                type: "linear",
                position: "left",
                title: { display: true, text: "Sales (PKR)" },
              },
              y2: {
                type: "linear",
                position: "right",
                grid: { drawOnChartArea: false },
                title: { display: true, text: "Orders" },
              },
            },
          }}
        />
      ) : (
        <p className="text-gray-500">Select two salespersons to compare.</p>
      )}
    </div>
  );
};

export default AnalyticsSalesperson;
