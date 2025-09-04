import { useState } from "react";
import { ChevronLeft, ChevronRight } from "lucide-react";

const GlobalPaginationTable = ({
  title,
  data,
  columns,
  className = "",
  rowsPerPage = 10,
}) => {
  const [currentPage, setCurrentPage] = useState(1);
  const [pageGroup, setPageGroup] = useState(0); // ✅ new state for grouped pagination
  const pagesPerGroup = 15; // ✅ show max 15 page numbers at once

  // Pagination calculations
  const totalPages = Math.ceil(data.length / rowsPerPage);
  const startIndex = (currentPage - 1) * rowsPerPage;
  const endIndex = startIndex + rowsPerPage;
  const currentRows = data.slice(startIndex, endIndex);

  const goToPage = (page) => {
    if (page >= 1 && page <= totalPages) {
      setCurrentPage(page);
    }
  };

  // ✅ Grouped page numbers
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
      {/* Title */}
      {title && (
        <h3 className="text-lg font-semibold text-[#BEB7DF] mb-4">{title}</h3>
      )}

      {/* Table */}
      <div className="overflow-x-auto">
        <table className="w-full min-w-[600px]">
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

        {/* ✅ Updated Pagination with 15 pages max */}
        {data.length > rowsPerPage && (
          <div className="flex justify-between items-center mt-4">
            <div className="text-sm text-gray-400">
              Showing {startIndex + 1} to {Math.min(endIndex, data.length)} of{" "}
              {data.length} entries
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

export default GlobalPaginationTable;
