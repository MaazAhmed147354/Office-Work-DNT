import React from "react";
import { Doughnut } from "react-chartjs-2";
import { Chart as ChartJS, ArcElement, Tooltip } from "chart.js";

ChartJS.register(ArcElement, Tooltip);

const MeterCard = ({
  title,
  value,
  max,
  unit = "",
  period = "Current Month",
  gaugeColor = "#BEB7DF", // Using your lavender color
}) => {
  const data = {
    datasets: [
      {
        data: [value, max - value],
        backgroundColor: [gaugeColor, "#66635B50"], // Lavender active + slate inactive
        borderWidth: 0,
        borderRadius: 10,
        circumference: 270,
        rotation: 225,
        cutout: "88%", // Slightly thicker than before
      },
    ],
  };

  const options = {
    plugins: {
      legend: { display: false },
      tooltip: { enabled: false },
    },
    maintainAspectRatio: false,
  };

  return (
    <div className="group p-5 pt-1 rounded-xl h-full flex flex-col backdrop-blur-md bg-[#1a1a2e]/70 border border-[#4A4B5A]/30 transition-all duration-300 hover:backdrop-blur-lg hover:bg-[#16213e]/80 transform ease-in-out hover:-translate-y-2 hover:scale-[1.02] hover:shadow-xl">
      {/* Title and Period */}
      <div className="mb-3 pb-3 border-b border-[#BEB7DF]/10">
        <h3 className="sm:text-sm lg:text-lg font-bold text-[#BEB7DF]">
          {title}
        </h3>
        <p className="sm:text-xs lg:text-sm text-[#BEB7DF]/70">{period}</p>
      </div>

      {/* Gauge Container */}
      <div className="relative flex-grow -mx-2">
        <div className="h-full w-full aspect-[2/1] relative">
          {/* Glow effect (visible on hover) */}
          <div
            className="absolute inset-0 rounded-full opacity-0 group-hover:opacity-100 transition-opacity duration-300"
            style={{
              background: `radial-gradient(circle at center, ${gaugeColor}30 0%, transparent 70%)`,
              filter: `blur(8px)`,
              transform: "scale(1.05)",
              zIndex: -1,
            }}
          />

          {/* Gauge with hover scaling */}
          <div className="h-full w-full transition-transform duration-300 group-hover:scale-105">
            <Doughnut data={data} options={options} />
          </div>
        </div>

        {/* Centered Value */}
        <div className="absolute inset-0 flex flex-col items-center justify-center pt-6">
          <p className="sm:text-lg lg:text-2xl font-bold text-[#BEB7DF] group-hover:text-white transition-colors duration-300">
            {value}
            {unit}
          </p>
          <p className="sm:text-lg lg:text-2xl text-[#BEB7DF]/70 mt-1 group-hover:text-[#BEB7DF]/90 transition-colors duration-300">
            {max}
            {unit}
          </p>
        </div>
      </div>
    </div>
  );
};

export default MeterCard;
