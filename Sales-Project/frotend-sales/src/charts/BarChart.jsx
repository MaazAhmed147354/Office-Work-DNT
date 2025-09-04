import { Bar } from "react-chartjs-2";
import {
  Chart as ChartJS,
  LineElement,
  BarElement,
  ArcElement,
  PointElement,
  CategoryScale,
  LinearScale,
  Title,
  Tooltip,
  Legend,
} from "chart.js";

ChartJS.register(
  LineElement,
  BarElement,
  ArcElement,
  PointElement,
  CategoryScale,
  LinearScale,
  Title,
  Tooltip,
  Legend
);

const BarChart = ({ data, options }) => {
  const barOptions = {
    ...options,
    maintainAspectRatio: false, // Allow resizing
  };

  return (
    <div className="w-full min-h-fit mx-auto">
      <Bar data={data} options={barOptions} />
    </div>
  );
};

export default BarChart;
