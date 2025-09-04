import { ArrowUp, ArrowDown } from "lucide-react";
import { useState } from "react";

export const StatCard = ({
  title,
  value,
  change,
  icon: Icon,
  unit = "",
  trend = "neutral",
  subtitle = "",
  classname = "",
  curtainColor = "bg-blue-900/90", // Curtain color with transparency
}) => {
  const [isHovered, setIsHovered] = useState(false);
  const isPositive = change >= 0;
  const trendColors = {
    up: "text-green-400 bg-green-900",
    down: "text-red-400 bg-red-900",
    neutral: "text-gray-400 bg-gray-700",
  };

  return (
    <div
      className={`relative rounded-xl border border-[#38384a] overflow-hidden h-[180px] ${classname}`}
      onMouseEnter={() => setIsHovered(true)}
      onMouseLeave={() => setIsHovered(false)}
    >
      {/* Main Card Content (always present but hidden behind curtain) */}
      <div className="bg-[#252538] p-6 h-full flex flex-col justify-between">
        <div className="flex justify-between items-start">
          <div>
            <h3 className="text-2xl font-bold text-white">
              {value}{" "}
              {unit && (
                <span className="text-sm font-normal text-gray-300">
                  {unit}
                </span>
              )}
            </h3>
            {subtitle && (
              <p className="text-sm text-gray-400 mt-1">{subtitle}</p>
            )}
          </div>
          {Icon && (
            <div className={`p-2 rounded-full ${trendColors[trend]}`}>
              <Icon className="w-4 h-4" />
            </div>
          )}
        </div>

        {change !== undefined && (
          <div
            className={`flex items-center ${
              isPositive ? "text-green-400" : "text-red-400"
            }`}
          >
            {isPositive ? (
              <ArrowUp className="w-4 h-4 mr-1" />
            ) : (
              <ArrowDown className="w-4 h-4 mr-1" />
            )}
            <span className="text-sm font-medium">
              {Math.abs(change)}% {isPositive ? "increase" : "decrease"}
            </span>
          </div>
        )}
      </div>

      {/* Curtain that lifts on hover */}
      <div
        className={`
        absolute inset-0 ${curtainColor} p-4
        transition-all duration-500 ease-[cubic-bezier(0.33,1,0.68,1)]
        flex items-center justify-center
        ${
          isHovered ? "translate-y-full opacity-0" : "translate-y-0 opacity-100"
        }
      `}
      >
        {/* <p className="text-gray-200 text-lg font-medium text-center">{title}</p> */}
        <div className="text-center">
          <Icon className="w-6 h-6 mx-auto mb-2" />
          <p className="text-gray-200 text-lg font-medium">{title}</p>
        </div>
      </div>
    </div>
  );
};
