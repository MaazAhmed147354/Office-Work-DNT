import React from "react";

const LeaderboardCard = ({ data }) => {
  // podium order → middle is 1st, left is 2nd, right is 3rd
  const podiumOrder = [
    { rank: 2, person: data[1], border: "border-violet-400" }, // left
    { rank: 1, person: data[0], border: "border-cyan-400" }, // middle (highest)
    { rank: 3, person: data[2], border: "border-purple-400" }, // right
  ];

  return (
    <div className="bg-[#252538] text-white rounded-2xl p-6 shadow-lg flex flex-col items-center border border-[#38384a] hover:border-[#4adeff]/50">
      <h2 className="text-lg font-bold mb-6 text-purple-400">🏆 Leaderboard</h2>

      <div className="flex justify-center items-end gap-6 w-full perspective">
        {podiumOrder.map(({ rank, person, border }) => (
          <div
            key={rank}
            className="flex flex-col items-center justify-end transform transition-transform duration-300 hover:-translate-y-2"
            style={{ order: rank === 1 ? 2 : rank === 2 ? 1 : 3 }} // ensure middle is 1st
          >
            {/* Salesperson Name */}
            <span className="text-sm font-semibold text-gray-200 mb-2">
              {person?.salesPersonName.toUpperCase() || `Salesperson ${rank}`}
            </span>

            {/* Avatar */}
            <img
              src={"./avatar.png"}
              alt="avatar"
              className={`w-16 h-16 rounded-full border-4 ${border} shadow-lg mb-2`}
            />

            {/* Podium step with 3D effect */}
            <div
              className={`w-20 flex items-center justify-center rounded-t-md shadow-xl relative overflow-hidden`}
              style={{
                height: rank === 1 ? "6rem" : rank === 2 ? "5rem" : "4rem",
                background:
                  rank === 1
                    ? "linear-gradient(to top, #0891b2, #22d3ee)" // cyan
                    : rank === 2
                    ? "linear-gradient(to top, #6d28d9, #8b5cf6)" // violet
                    : "linear-gradient(to top, #7e22ce, #a855f7)", // purple
                boxShadow:
                  "0 6px 12px rgba(0,0,0,0.4), inset 0 -4px 8px rgba(0,0,0,0.5)",
                transform: "perspective(600px) rotateX(15deg)",
              }}
            >
              <span className="text-lg font-bold text-white drop-shadow-lg">
                #{rank}
              </span>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
};

export default LeaderboardCard;
