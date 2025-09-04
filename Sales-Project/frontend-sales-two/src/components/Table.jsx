const Table = ({ data, columns }) => {
  return (
    <div className="flex flex-col overflow-x-auto rounded-lg border-none border-[#66635B]/50">
      <table className="w-full min-w-[600px] h-full">
        <thead className="bg-[#1a1a2e] text-[#E0DDFF] border-[#4A4B5A]">
          <tr>
            {columns.map((column) => (
              <th
                key={column.field}
                className={`px-4 py-2 ${column.style} text-xs font-semibold border-b border-[#66635B] whitespace-nowrap`}
              >
                {column.header}
              </th>
            ))}
          </tr>
        </thead>
        <tbody>
          {data.map((row, rowIndex) => (
            <tr
              key={rowIndex}
              className={`
                ${
                  rowIndex % 2 === 0 ? "bg-[#1a1a2e]/40" : "bg-[#2b2d42]/40"
                } hover:bg-[#BEB7DF]/10 transition-colors`}
            >
              {columns.map((column) => (
                <td
                  key={column.field}
                  className={`px-4 py-2 text-[#BEB7DF] text-xs ${column.style}`}
                >
                  {column.field === "acceptanceRate" ? (
                    <div className="relative h-full w-full bg-[#66635B]/30 rounded-sm overflow-hidden">
                      <div
                        className={`absolute inset-y-0 left-0 flex items-center justify-end pr-2 ${
                          parseInt(row.acceptanceRate) >= 85
                            ? "bg-green-500"
                            : "bg-yellow-500"
                        }`}
                        style={{
                          width: `${row.acceptanceRate.replace("%", "")}%`,
                          minWidth: "25px", // Ensures percentage is visible even for small values
                        }}
                      >
                        <span className="text-xs font-medium text-white">
                          {row.acceptanceRate}
                        </span>
                      </div>
                    </div>
                  ) : column.field === "employee" ? (
                    <span className="whitespace-nowrap truncate flex flex-row items-center">
                      {rowIndex + 1}
                      <img
                        src={row["image"]}
                        className="w-[20px] mx-4"
                        onError={(e) => {
                          e.target.style.display = "none"; // Hide if image fails to load
                        }}
                      />
                      {row[column.field]}
                    </span>
                  ) : column.field === "name" ? (
                    <span className="whitespace-nowrap truncate flex flex-row gap-3">
                      <span>{rowIndex + 1}</span>
                      <span>{row[column.field]}</span>
                    </span>
                  ) : (
                    <span className="whitespace-nowrap truncate">
                      {row[column.field]}
                    </span>
                  )}
                </td>
              ))}
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default Table;
