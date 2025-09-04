import { Doughnut } from "react-chartjs-2";
import { Chart as ChartJS, ArcElement, Tooltip, Legend } from "chart.js";

ChartJS.register(ArcElement, Tooltip, Legend);

export const SalesDistributionChart = () => {
  const data = {
    labels: ["Product A", "Product B", "Product C", "Product D", "Product E"],
    datasets: [
      {
        data: [75000, 46380, 30400, 28500, 35560],
        backgroundColor: [
          "rgba(79, 70, 229, 0.8)", // Indigo
          "rgba(109, 40, 217, 0.8)", // Purple
          "rgba(219, 39, 119, 0.8)", // Pink
          "rgba(234, 88, 12, 0.8)", // Orange
          "rgba(22, 163, 74, 0.8)", // Green
        ],
        borderColor: [
          "rgba(79, 70, 229, 1)",
          "rgba(109, 40, 217, 1)",
          "rgba(219, 39, 119, 1)",
          "rgba(234, 88, 12, 1)",
          "rgba(22, 163, 74, 1)",
        ],
        borderWidth: 1,
        cutout: "70%",
      },
    ],
  };

  const options = {
    responsive: true,
    plugins: {
      legend: {
        position: "right",
        labels: {
          color: "#e5e7eb",
          font: {
            size: 12,
          },
          padding: 20,
        },
      },
      tooltip: {
        callbacks: {
          label: (context) => {
            const label = context.label || "";
            const value = context.raw || 0;
            const total = context.dataset.data.reduce((a, b) => a + b, 0);
            const percentage = Math.round((value / total) * 100);
            return `${label}: $${value.toLocaleString()} (${percentage}%)`;
          },
        },
        backgroundColor: "#1f2937",
        titleColor: "#f3f4f6",
        bodyColor: "#f3f4f6",
      },
    },
    maintainAspectRatio: false,
  };

  return (
    <div className="bg-[#252538] rounded-xl p-6 border border-[#38384a] h-full hover:border-[#8a4fff]/50">
      <h3 className="text-lg font-semibold text-white mb-4">
        Sales Distribution
      </h3>
      <div className="h-64">
        <Doughnut data={data} options={options} />
      </div>
    </div>
  );
};
