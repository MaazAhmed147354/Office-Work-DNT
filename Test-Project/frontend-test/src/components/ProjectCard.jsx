import React from "react";

const ProgressBar = ({ progress }) => {
  const progressColor = progress === 100 ? "bg-green-500" : "bg-blue-500";

  return (
    <div className="w-full bg-gray-200 rounded-full h-2">
      <div
        className={`${progressColor} h-2 rounded-full`}
        style={{ width: `${progress}%` }}
      />
    </div>
  );
};

const ProjectCard = ({ projects }) => {
  return (
    <div className="bg-white rounded-lg shadow p-6 w-full max-w-5xl">
      <h2 className="text-lg font-semibold mb-1">Projects</h2>
      <p className="text-sm text-gray-600 mb-6">30 done this month</p>

      <table className="w-full text-sm text-gray-700">
        <thead>
          <tr className="text-left text-xs font-semibold text-gray-500">
            <th className="pb-3">COMPANIES</th>
            <th className="pb-3">MEMBERS</th>
            <th className="pb-3">BUDGET</th>
            <th className="pb-3">COMPLETION</th>
          </tr>
        </thead>

        <tbody>
          {projects.map(
            ({ id, company, logo, members, budget, completion }) => (
              <tr
                key={id}
                className="border-b border-gray-300 last:border-none"
              >
                {/* Companies */}
                <td className="py-4">
                  <div className="flex items-center gap-2">
                    <img
                      src={`./../../${logo}`}
                      alt={company}
                      className="w-5 h-5"
                    />
                    <span className="text-sm font-medium text-gray-800">
                      {company}
                    </span>
                  </div>
                </td>

                {/* Members */}
                <td className="py-4">
                  <div className="flex">
                    {members.map((memberUrl, i) => (
                      <img
                        key={i}
                        src={`./../../${memberUrl}`}
                        alt={`Member ${i + 1}`}
                        title={`Member ${i + 1}`}
                        className="w-6 h-6 rounded-full border-white hover:z-10"
                      />
                    ))}
                  </div>
                </td>

                {/* Budget */}
                <td className="py-4">
                  <span className="text-sm">{budget}</span>
                </td>

                {/* Completion */}
                <td className="py-4 w-40">
                  <ProgressBar progress={completion} />
                  <p className="text-xs text-gray-500 mt-1">{completion}%</p>
                </td>
              </tr>
            )
          )}
        </tbody>
      </table>
    </div>
  );
};

export default ProjectCard;
