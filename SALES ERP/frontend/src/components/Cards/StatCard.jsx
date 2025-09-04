import { Trophy, Award, Star, DollarSign } from "lucide-react";

const iconComponents = {
  dollar: DollarSign,
  star: Star,
  certificate: Award,
  trophy: Trophy,
};

const StatCard = ({
  title = "default title",
  value = "default value",
  subtitle = "default subtitle",
  icon = "star",
  classname,
  period = "This Month",
}) => {
  // if (!subtitle || subtitle.length === 0 || !value || value.length === 0) {
  //   console.log("meow");
  //   return (
  //     <div className="bg-[#252538] rounded-xl p-6 border border-[#38384a] text-gray-400 text-sm">
  //       No stat card data available
  //     </div>
  //   );
  // }
  console.log("Woof");

  const IconComponent = iconComponents[icon] || Star;

  return (
    <div
      className={`${classname} rounded-xl p-6 border border-[#38384a] flex flex-col justify-between transition-all duration-300 transform hover:scale-102 hover:shadow-[0_0_20px_rgba(124,58,237,0.28)]`}
    >
      {/* Top content */}
      <div className="flex justify-between items-start">
        <div>
          <h3 className="text-sm font-medium text-gray-300 mb-1">{title}</h3>
          <p className="text-2xl font-bold">{value}</p>
          <p className="text-xs text-white mt-1">{subtitle}</p>
        </div>
        <div className="p-2 rounded-lg bg-[#8a4fff]/30 shadow-md">
          <IconComponent className="w-5 h-5 text-gray-300" />
        </div>
      </div>

      {/* Bottom content (aligned right) */}
      <div className="flex justify-end mt-2">
        <span
          className={`text-[10px] font-semibold text-white bg-gray-200/10 px-2 py-0.5 rounded-full shadow-sm`}
        >
          {period}
        </span>
      </div>
    </div>
  );
};

export default StatCard;
