import { Line } from "react-chartjs-2";
import {
  Chart as ChartJS,
  CategoryScale,
  LinearScale,
  PointElement,
  LineElement,
  Title,
  Tooltip,
  Legend,
  Filler,
} from "chart.js";

ChartJS.register(
  CategoryScale,
  LinearScale,
  PointElement,
  LineElement,
  Title,
  Tooltip,
  Legend,
  Filler
);

export const RevenueTrendChart = () => {
  const data = {
    labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun"],
    datasets: [
      {
        label: "Revenue",
        data: [65000, 59000, 80000, 81000, 125000, 105000],
        borderColor: "#4f46e5", // Indigo-600
        backgroundColor: "rgba(79, 70, 229, 0.1)",
        tension: 0.3,
        fill: true,
        pointBackgroundColor: "#fff",
        pointBorderColor: "#4f46e5",
        pointRadius: 4,
        pointHoverRadius: 6,
      },
    ],
  };

  const options = {
    responsive: true,
    plugins: {
      legend: {
        position: "top",
        labels: {
          color: "#e5e7eb", // Light gray for text
        },
      },
      tooltip: {
        mode: "index",
        intersect: false,
        backgroundColor: "#1f2937", // Dark tooltip
        titleColor: "#f3f4f6",
        bodyColor: "#f3f4f6",
        borderColor: "#374151",
        borderWidth: 1,
      },
    },
    scales: {
      x: {
        grid: {
          color: "#374151", // Grid line color
        },
        ticks: {
          color: "#9ca3af", // Tick text color
        },
      },
      y: {
        grid: {
          color: "#374151",
        },
        ticks: {
          color: "#9ca3af",
          callback: (value) => `$${(value / 1000).toFixed(0)}K`,
        },
      },
    },
    maintainAspectRatio: false,
  };

  return (
    <div className="bg-[#252538] rounded-xl p-6 border border-[#38384a] h-full hover:border-[#8a4fff]/50">
      <h3 className="text-lg font-semibold text-white mb-4">Revenue Trend</h3>
      <div className="h-64">
        <Line data={data} options={options} />
      </div>
    </div>
  );
};
