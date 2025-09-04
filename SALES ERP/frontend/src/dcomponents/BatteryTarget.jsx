import { BatteryFull } from "lucide-react";

export const BatteryTarget = ({ percentage = 25 }) => {
  const clampedPercentage = Math.min(100, Math.max(0, percentage));
  const fillHeight = `${clampedPercentage}%`;

  const batteryColor =
    clampedPercentage < 20
      ? "bg-red-500"
      : clampedPercentage < 60
      ? "bg-yellow-500"
      : "bg-green-500";

  return (
    <div className="relative bg-[#252538] rounded-xl border border-[#38384a] hover:border-[#8a4fff]/50 p-0 overflow-hidden w-full h-full transition-all duration-300">
      {/* Battery Tip */}
      <div className="absolute -top-3 left-1/2 transform -translate-x-1/2 w-6 h-2 bg-gray-400 rounded-t-sm"></div>

      {/* Header inside battery */}
      <div className="absolute top-4 left-0 right-0 z-10 px-4">
        <div className="flex items-center justify-between">
          <h3 className="text-lg font-semibold text-white">Sales Target</h3>
          {/* <BatteryFull className="w-5 h-5 text-purple-400" /> */}
        </div>
      </div>

      {/* Battery Fill with Wave Effect */}
      <div
        className={`absolute bottom-0 left-0 right-0 ${batteryColor} transition-all duration-1000 ease-out`}
        style={{ height: fillHeight }}
      >
        {/* Wave effect on hover */}
        <div className="absolute -top-4 left-0 right-0 h-8 bg-gradient-to-b from-white/20 to-transparent opacity-0 hover:opacity-100 transition-opacity duration-300"></div>

        {/* Percentage Text */}
        <div className="absolute top-1/2 left-1/2 transform -translate-x-1/2 -translate-y-1/2 text-white font-bold text-lg">
          {clampedPercentage}%
        </div>
      </div>

      {/* Target Info */}
      <div className="absolute bottom-4 left-0 right-0 text-center z-10">
        <p className="text-gray-300 text-sm">
          {clampedPercentage >= 100 ? (
            <span className="text-green-400">Target Achieved!</span>
          ) : (
            `${100 - clampedPercentage}% remaining`
          )}
        </p>
      </div>
    </div>
  );
};
