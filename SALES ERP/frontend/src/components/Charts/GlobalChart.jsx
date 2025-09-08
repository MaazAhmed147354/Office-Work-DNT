import { useEffect, useRef } from "react";
import { Chart } from "chart.js/auto";

const GlobalChart = ({ type, labels, datasets, options = {} }) => {
  const chartRef = useRef(null);
  const chartInstance = useRef(null);

  useEffect(() => {
    const ctx = chartRef.current.getContext("2d");

    if (chartInstance.current) {
      chartInstance.current.destroy(); // cleanup old chart
    }

    chartInstance.current = new Chart(ctx, {
      type,
      data: {
        labels,
        datasets,
      },
      options: {
        responsive: true,
        maintainAspectRatio: false,
        ...options,
      },
    });

    return () => {
      if (chartInstance.current) {
        chartInstance.current.destroy();
      }
    };
  }, [type, labels, datasets, options]);

  return (
    <div className="h-96">
      <canvas ref={chartRef} />
    </div>
  );
};

export default GlobalChart;
