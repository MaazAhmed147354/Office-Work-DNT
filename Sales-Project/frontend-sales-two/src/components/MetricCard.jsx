import React from "react";

const MetricCard = ({
  title,
  value,
  unit = "",
  period = "Current Month",
  isCurrency = false,
  textColor = "#E0DDFF",
  bgColor = "#16213e",
}) => {
  return (
    <div
      className={`h-full p-5 pt-1 rounded-xl flex flex-col backdrop-blur-md bg-[${bgColor}]/70 border border-[#4A4B5A]/30 transition-all duration-300 hover:backdrop-blur-lg hover:bg-[${bgColor}]/80 transform ease-in-out hover:-translate-y-2 hover:scale-[1.02] hover:shadow-xl`}
    >
      {/* Title and Period */}
      <div className="mb-2 pb-3 border-b border-[#BEB7DF]/10">
        <h3 className={`sm:text-xs lg:text-lg font-bold text-[${textColor}]`}>
          {title}
        </h3>
        <p className={`sm:text-xs lg:text-sm text-[${textColor}]/70 `}>
          {period}
        </p>
      </div>

      {/* Centered Value */}
      <div className="flex-grow flex items-center justify-center">
        <p className={`sm:text-2xl md:text-4xl font-bold text-[${textColor}]`}>
          {isCurrency ? `$${value}${unit}` : `${value}${unit}`}
        </p>
      </div>
    </div>
  );
};

MetricCard.defaultProps = {
  textColor: "#BEB7DF",
  bgColor: "#380036",
  borderColor: "#66635B",
};

export default MetricCard;
