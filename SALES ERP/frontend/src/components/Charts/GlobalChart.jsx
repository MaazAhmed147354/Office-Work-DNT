import { useEffect, useRef } from "react";
import { Chart } from "chart.js/auto";

const GlobalChart = ({ type, labels, datasets, options = {} }) => {
  const chartRef = useRef(null);
  const chartInstance = useRef(null);

  useEffect(() => {
    const ctx = chartRef.current.getContext("2d");

    // If no chart instance, create one
    if (!chartInstance.current) {
      chartInstance.current = new Chart(ctx, {
        type,
        data: { labels, datasets },
        options: { responsive: true, maintainAspectRatio: false, ...options },
      });
      return () => {
        if (chartInstance.current) {
          chartInstance.current.destroy();
          chartInstance.current = null;
        }
      };
    }

    // If type changed, recreate chart
    if (chartInstance.current.config.type !== type) {
      chartInstance.current.destroy();
      chartInstance.current = new Chart(ctx, {
        type,
        data: { labels, datasets },
        options: { responsive: true, maintainAspectRatio: false, ...options },
      });
      return () => {
        if (chartInstance.current) {
          chartInstance.current.destroy();
          chartInstance.current = null;
        }
      };
    }

    // Otherwise update data & options in place
    try {
      chartInstance.current.options = {
        ...chartInstance.current.options,
        ...options,
      };
      chartInstance.current.data.labels = labels;
      chartInstance.current.data.datasets = datasets;
      // 'none' avoids animation if you want instant updates. change to 'default' if you want animations.
      chartInstance.current.update("none");
    } catch (err) {
      // fallback: if update fails, recreate chart
      chartInstance.current.destroy();
      chartInstance.current = new Chart(ctx, {
        type,
        data: { labels, datasets },
        options: { responsive: true, maintainAspectRatio: false, ...options },
      });
    }

    // cleanup on unmount handled by earlier return when instance was not present or type changed
  }, [type, labels, datasets, options]);

  return (
    <div className="h-64">
      <canvas ref={chartRef} />
    </div>
  );
};

export default GlobalChart;
