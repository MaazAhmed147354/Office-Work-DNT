export const DataTable = ({ title, subtitle, columns, data, onExecute }) => {
  return (
    <div className="bg-[#252538] rounded-xl border border-[#38384a] hover:border-[#8a4fff]/50">
      <div className="p-6 border-b border-[#38384a]">
        <h3 className="font-semibold text-lg text-white">{title}</h3>
        {subtitle && <p className="text-gray-400 text-sm mt-1">{subtitle}</p>}
      </div>

      <div className="overflow-x-auto rounded-b-xl">
        <table className="min-w-full divide-y divide-[#38384a]">
          <thead className="bg-[#2d2d42]">
            <tr>
              {columns.map((column) => (
                <th
                  key={column.field}
                  scope="col"
                  className={`px-6 py-3 text-left text-xs font-medium text-gray-400 uppercase tracking-wider ${
                    column.style || "text-left"
                  }`}
                >
                  {column.header}
                </th>
              ))}
            </tr>
          </thead>
          <tbody className="bg-[#252538] divide-y divide-[#38384a]">
            {data.map((item, index) => (
              <tr key={index}>
                {columns.map((column, index) => (
                  <td
                    key={index}
                    className={`px-6 py-4 whitespace-nowrap text-sm ${
                      column.style?.includes("text-center")
                        ? "text-center"
                        : "text-left"
                    } ${
                      column.style?.includes("font-bold") ? "font-bold" : ""
                    } ${
                      item[column.field]?.toString().startsWith("$")
                        ? "text-green-400"
                        : "text-white"
                    }`}
                  >
                    {item[column.field]}
                  </td>
                ))}
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
};
