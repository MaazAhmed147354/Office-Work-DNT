import { Pie } from "react-chartjs-2";
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

const PieChart = ({ data, options }) => {
  const pieOptions = {
    ...options,
    maintainAspectRatio: false, // Allow resizing
  };

  return (
    <div className="w-full min-h-fit mx-auto">
      <Pie data={data} options={pieOptions} />
    </div>
  );
};

export default PieChart;
