import { useState } from "react";
import { ChevronLeft, ChevronRight } from "lucide-react";

const branchOptions = [
  { id: 0, name: "Head Office" },
  { id: 1, name: "Hafeez Centre (Lahore)" },
  { id: 2, name: "H.O. Branch (Karachi)" },
  { id: 4, name: "Karachi City (Karachi)" },
  { id: 5, name: "Bharia Town ISP" },
];

const ProductsTable = ({ title, data, columns, className = "" }) => {
  const [currentPage, setCurrentPage] = useState(1);
  const [pageGroup, setPageGroup] = useState(0); // track which 15-page group
  const [selectedBranch, setSelectedBranch] = useState("all"); // branch filter
  const rowsPerPage = 10;
  const pagesPerGroup = 15;

  // Apply branch filter
  const filteredData =
    selectedBranch === "all"
      ? data
      : data.filter((row) => String(row.branchId) === String(selectedBranch));

  // Pagination calculations
  const totalPages = Math.ceil(filteredData.length / rowsPerPage);
  const startIndex = (currentPage - 1) * rowsPerPage;
  const endIndex = startIndex + rowsPerPage;
  const currentRows = filteredData.slice(startIndex, endIndex);

  const goToPage = (page) => {
    if (page >= 1 && page <= totalPages) {
      setCurrentPage(page);
    }
  };

  // Grouped page numbers
  const startPage = pageGroup * pagesPerGroup + 1;
  const endPage = Math.min(startPage + pagesPerGroup - 1, totalPages);
  const pageNumbers = Array.from(
    { length: endPage - startPage + 1 },
    (_, i) => startPage + i
  );

  return (
    <div
      className={`p-6 rounded-xl bg-[#252538] border border-[#38384a] hover:border-[#8a4fff]/50 transition-colors duration-300 ${className}`}
    >
      <div className="flex justify-between items-center mb-4">
        <h3 className="text-lg font-semibold text-[#BEB7DF]">{title}</h3>

        {/* Branch Filter */}
        <select
          value={selectedBranch}
          onChange={(e) => {
            setSelectedBranch(e.target.value);
            setCurrentPage(1); // reset pagination on filter change
            setPageGroup(0);
          }}
          className="ml-4 px-3 py-2 bg-[#2d2d42] text-[#BEB7DF] rounded-md border border-[#38384a] focus:outline-none focus:ring-2 focus:ring-[#8a4fff]"
        >
          <option value="all">All Branches</option>
          {branchOptions.map((branch) => (
            <option key={branch.id} value={branch.id}>
              {branch.name}
            </option>
          ))}
        </select>
      </div>

      {/* Table + Pagination inside same scroll container */}
      <div className="overflow-x-auto">
        <table className="w-full min-w-full">
          <thead>
            <tr className="border-b border-[#38384a]">
              {columns.map((column) => (
                <th
                  key={column.field}
                  className={`px-4 py-3 text-xs font-medium text-gray-300 ${column.style}`}
                >
                  {column.header}
                </th>
              ))}
            </tr>
          </thead>
          <tbody>
            {currentRows.length > 0 ? (
              currentRows.map((row, rowIndex) => (
                <tr
                  key={startIndex + rowIndex}
                  className={`${
                    rowIndex % 2 === 0 ? "bg-[#252538]" : "bg-[#2d2d42]"
                  } hover:bg-[#38384a] transition-colors`}
                >
                  {columns.map((column) => (
                    <td
                      key={column.field}
                      className={`px-4 py-3 text-sm text-[#BEB7DF] ${column.style}`}
                    >
                      <span className="whitespace-nowrap">
                        {row[column.field]}
                      </span>
                    </td>
                  ))}
                </tr>
              ))
            ) : (
              <tr>
                <td
                  colSpan={columns.length}
                  className="text-center text-gray-400 py-4"
                >
                  No data available
                </td>
              </tr>
            )}
          </tbody>
        </table>

        {/* ✅ Pagination stays inside bounds with max 15 numbers */}
        {filteredData.length > rowsPerPage && (
          <div className="flex justify-between items-center pl-4 pt-4 border-t border-[#38384a]">
            <div className="text-sm text-gray-400">
              Showing {startIndex + 1} to{" "}
              {Math.min(endIndex, filteredData.length)} of {filteredData.length}{" "}
              entries
            </div>
            <div className="flex gap-2">
              {/* Prev group */}
              <button
                onClick={() => {
                  if (pageGroup > 0) {
                    setPageGroup(pageGroup - 1);
                    setCurrentPage(startPage - pagesPerGroup);
                  }
                }}
                disabled={pageGroup === 0}
                className={`p-2 rounded-md ${
                  pageGroup === 0
                    ? "bg-[#38384a] text-gray-500 cursor-not-allowed"
                    : "bg-[#38384a] text-[#BEB7DF] hover:bg-[#4A4B5A]"
                }`}
              >
                <ChevronLeft size={16} />
              </button>

              {pageNumbers.map((page) => (
                <button
                  key={page}
                  onClick={() => goToPage(page)}
                  className={`w-8 h-8 rounded-md ${
                    currentPage === page
                      ? "bg-[#8a4fff] text-white"
                      : "bg-[#38384a] text-[#BEB7DF] hover:bg-[#4A4B5A]"
                  }`}
                >
                  {page}
                </button>
              ))}

              {/* Next group */}
              <button
                onClick={() => {
                  if (endPage < totalPages) {
                    setPageGroup(pageGroup + 1);
                    setCurrentPage(endPage + 1);
                  }
                }}
                disabled={endPage >= totalPages}
                className={`p-2 rounded-md ${
                  endPage >= totalPages
                    ? "bg-[#38384a] text-gray-500 cursor-not-allowed"
                    : "bg-[#38384a] text-[#BEB7DF] hover:bg-[#4A4B5A]"
                }`}
              >
                <ChevronRight size={16} />
              </button>
            </div>
          </div>
        )}
      </div>
    </div>
  );
};

export default ProductsTable;
