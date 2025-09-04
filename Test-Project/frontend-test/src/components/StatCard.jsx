const StatCard = ({ label, value, percentage, comparison, icolor, icon }) => {
  return (
    <div className="bg-white p-4 rounded-lg shadow flex relative overflow-visible transition-all duration-300 hover:-translate-y-1 hover:scale-105">
      <div className="flex flex-col w-full">
        {/* Floating Icon */}
        <div
          className={`flex items-center justify-center rounded-lg text-2xl text-white p-6 w-10 h-10 drop-shadow-md drop-shadow-gray-600/50 ${icolor}`}
          style={{
            position: "absolute",
            top: "-0.75rem", // Moves the icon slightly above the white box
            left: "1rem",
          }}
        >
          {icon}
        </div>

        {/* Label and Value */}
        <div className="flex flex-col items-end absolute top-4 right-4 text-right">
          <h4 className="text-sm font-medium text-gray-500">{label}</h4>
          <div className="text-lg font-bold">{value}</div>
        </div>

        {/* Spacer */}
        <div className="h-16" />

        {/* Percentage Comparison */}
        <div className="text-sm text-green-600 mt-auto">
          {percentage} <span className="text-gray-400">{comparison}</span>
        </div>
      </div>
    </div>
  );
};

export default StatCard;