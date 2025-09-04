import React from "react";
import "./../charts/chart"
import "./ChartCard"
import { Bar, Line } from "react-chartjs-2";

const ChartCard = ({ title, statement, update, type, chartBgColor, data, options }) => {
  return (
    <div className="flex flex-col justify-center bg-white pt-16 h-fit pb-4 px-4 rounded-lg shadow-md relative overflow-visible transition-all duration-300 hover:-translate-y-1 hover:scale-105">
      {/* Floating Chart */}
      <div id="floating-chart" className={`absolute -top-5 right-3 p-3 w-fit rounded-lg ${chartBgColor}`}>
        {type === "bar" && <Bar data={data} options={options} />}
        {type === "line" && <Line data={data} options={options} />}
      </div>

      {/* Title and subtitle */}
      <div className="flex flex-col mt-28">
        <h3 className="font-semibold text-sm mb-1">{title}</h3>
        <p className="text-[10px] text-gray-500">{statement}</p>
        <p className="text-[10px] text-gray-400 mt-4">⏲ {update}</p>
      </div>
    </div>
  );
};

export default ChartCard;
