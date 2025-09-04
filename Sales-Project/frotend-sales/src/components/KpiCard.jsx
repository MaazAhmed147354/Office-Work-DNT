import { ArrowUpRight, ArrowDownRight } from "lucide-react";

export default function KpiCard({
  title,
  value,
  change,
  icon: Icon,
  isPositive = true,
  isActive = false,
  onClick,
}) {
  return (
    <div
      onClick={onClick}
      className={`w-[240px] min-w-[240px] p-4 rounded-2xl backdrop-blur-md bg-white/5 hover:bg-white/10 hover:shadow-lg transition-all cursor-pointer text-[#e2e8f0] ${
        isActive ? "ring-2 ring-[#60a5fa] scale-[1.02]" : ""
      }`}
    >
      <div className="flex items-center justify-between mb-2">
        <h4 className="text-sm font-medium text-[#94a3b8] dark:text-gray-400">
          {title}
        </h4>
        {Icon && <Icon className="w-5 h-5 text-[#60af5a]" />}
      </div>

      <div className="text-2xl font-bold text-[#f8fafc] dark:text-white">
        {value}
      </div>

      <div className="flex items-center mt-1 text-sm">
        {isPositive ? (
          <ArrowUpRight className="w-4 h-4 text-green-500" />
        ) : (
          <ArrowDownRight className="w-4 h-4 text-red-500" />
        )}
        <span
          className={`ml-1 ${isPositive ? "text-green-500" : "text-red-500"}`}
        >
          {change}
        </span>
      </div>
    </div>
  );
}
