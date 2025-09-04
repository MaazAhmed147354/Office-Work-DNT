import { Line } from "react-chartjs-2";
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

const LineChart = ({ data, options }) => {
  const lineOptions = {
    ...options,
    maintainAspectRatio: false, // Allow resizing
  };

  return (
    <div className="w-full min-h-fit mx-auto">
      <Line data={data} options={lineOptions} />
    </div>
  );
};

export default LineChart;
