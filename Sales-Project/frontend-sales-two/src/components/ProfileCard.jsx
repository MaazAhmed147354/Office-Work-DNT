const ProfileCard = ({
  title = "Opportunities Created",
  period = "Current Month",
  profiles,
}) => {
  return (
    <div className="min-h-full p-5 pt-1 rounded-xl shadow-lg backdrop-blur-md bg-[#1a1a2e]/70 border border-[#4A4B5A]/30 transition-all duration-300 hover:backdrop-blur-lg hover:bg-[#16213e]/80 transform ease-in-out hover:-translate-y-2 hover:scale-[1.02] hover:shadow-xl">
      {/* Header */}
      <div className="mb-4">
        <h3 className="font-bold text-[#BEB7DF] text-lg">{title}🚀</h3>
        <p className="text-[#BEB7DF]/70 text-sm">{period}</p>
      </div>

      {/* Profile Grid */}
      <div className="flex justify-between gap-2">
        {profiles.map((item) => (
          <div key={item.name} className="text-center flex-1 group">
            {/* Profile Image with Glow */}
            <div
              className={`
              w-14 h-14 rounded-full mx-auto mb-2
              bg-[#2b2d42] border-2 border-[#4A4B5A]/40 group-hover:border-[#6C5CE7]/60
              flex items-center justify-center
              overflow-hidden
              transition-colors duration-200
            `}
            >
              {item.image ? (
                <img
                  src={item.image}
                  alt={item.name}
                  className="w-full h-full object-cover"
                  onError={(e) => {
                    e.target.style.display = "none"; // Hide if image fails to load
                  }}
                />
              ) : (
                <span className="text-[#E0DDFF] font-bold">
                  {item.name
                    .split(" ")
                    .map((n) => n[0])
                    .join("")}
                </span>
              )}
            </div>

            {/* Name */}
            <p className="text-[#BEB7DF]/90 text-sm font-medium truncate">
              {item.name}
            </p>

            {/* Value */}
            <p className="text-[#BEB7DF] font-bold mt-1">{item.value}</p>
          </div>
        ))}
      </div>
    </div>
  );
};

export default ProfileCard;
