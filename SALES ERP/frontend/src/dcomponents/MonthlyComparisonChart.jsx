import { Bar } from "react-chartjs-2";
import {
  Chart as ChartJS,
  CategoryScale,
  LinearScale,
  BarElement,
  Title,
  Tooltip,
  Legend,
} from "chart.js";

ChartJS.register(
  CategoryScale,
  LinearScale,
  BarElement,
  Title,
  Tooltip,
  Legend
);

export const MonthlyComparisonChart = () => {
  const data = {
    labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun"],
    datasets: [
      {
        label: "2023",
        data: [65000, 59000, 80000, 81000, 125000, 105000],
        backgroundColor: "rgba(79, 70, 229, 0.8)",
        borderRadius: 4,
      },
      {
        label: "2022",
        data: [52000, 48000, 70000, 65000, 98000, 87000],
        backgroundColor: "rgba(109, 40, 217, 0.8)",
        borderRadius: 4,
      },
    ],
  };

  const options = {
    responsive: true,
    plugins: {
      legend: {
        position: "top",
        labels: {
          color: "#e5e7eb",
        },
      },
      tooltip: {
        backgroundColor: "#1f2937",
        titleColor: "#f3f4f6",
        bodyColor: "#f3f4f6",
      },
    },
    scales: {
      x: {
        grid: {
          color: "#374151",
          drawOnChartArea: false,
        },
        ticks: {
          color: "#9ca3af",
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
      <h3 className="text-lg font-semibold text-white mb-4">
        Monthly Comparison
      </h3>
      <div className="h-64">
        <Bar data={data} options={options} />
      </div>
    </div>
  );
};
