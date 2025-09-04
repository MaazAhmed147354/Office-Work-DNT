import { useState } from "react";
import { Calendar, ChevronLeft, ChevronRight } from "lucide-react";
import DateModal from "../Modals/DateModal";

const TableCard = ({ title, data, columns, className = "", onExecute }) => {
  const [showDateModal, setShowDateModal] = useState(false);
  const [tableData, setTableData] = useState(data);
  const [dateRange, setDateRange] = useState({
    start: "",
    end: "",
  });
  const [currentPage, setCurrentPage] = useState(1);
  const rowsPerPage = 6;

  const handleDateSubmit = async (startDate, endDate) => {
    try {
      const newData = await onExecute(startDate, endDate);
      setTableData(newData);
      setDateRange({ start: startDate, end: endDate });
      setCurrentPage(1); // Reset to first page when new data loads
    } catch (error) {
      console.error("Error fetching data:", error);
    }
  };

  // Calculate pagination
  const totalPages = Math.ceil(tableData.length / rowsPerPage);
  const startIndex = (currentPage - 1) * rowsPerPage;
  const endIndex = startIndex + rowsPerPage;
  const currentRows = tableData.slice(startIndex, endIndex);

  const goToPage = (page) => {
    if (page >= 1 && page <= totalPages) {
      setCurrentPage(page);
    }
  };

  return (
    <div
      className={`p-6 rounded-xl bg-[#252538] border border-[#38384a] hover:border-[#8a4fff]/50 transition-colors duration-300 ${className}`}
    >
      <div className="flex justify-between items-center mb-4">
        <h3 className="text-lg font-semibold text-[#BEB7DF]">{title}</h3>
        <button
          onClick={() => setShowDateModal(true)}
          className="flex items-center gap-2 px-4 py-2 bg-[#38384a] text-[#BEB7DF] rounded-lg hover:bg-[#4A4B5A] transition-colors"
        >
          <Calendar size={16} />
          Select Range
        </button>
      </div>

      {/* Date range display */}
      {dateRange.start && dateRange.end && (
        <div className="text-sm text-[#8a4fff] mb-4">
          Showing data from {dateRange.start} to {dateRange.end}
        </div>
      )}

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
            {currentRows.map((row, rowIndex) => (
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
            ))}
          </tbody>
        </table>
      </div>

      {/* Pagination Controls */}
      {tableData.length > rowsPerPage && (
        <div className="flex justify-between items-center mt-4">
          <div className="text-sm text-gray-400">
            Showing {startIndex + 1} to {Math.min(endIndex, tableData.length)}{" "}
            of {tableData.length} entries
          </div>
          <div className="flex gap-2">
            <button
              onClick={() => goToPage(currentPage - 1)}
              disabled={currentPage === 1}
              className={`p-2 rounded-md ${
                currentPage === 1
                  ? "bg-[#38384a] text-gray-500 cursor-not-allowed"
                  : "bg-[#38384a] text-[#BEB7DF] hover:bg-[#4A4B5A]"
              }`}
            >
              <ChevronLeft size={16} />
            </button>

            {Array.from({ length: totalPages }, (_, i) => i + 1).map((page) => (
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

            <button
              onClick={() => goToPage(currentPage + 1)}
              disabled={currentPage === totalPages}
              className={`p-2 rounded-md ${
                currentPage === totalPages
                  ? "bg-[#38384a] text-gray-500 cursor-not-allowed"
                  : "bg-[#38384a] text-[#BEB7DF] hover:bg-[#4A4B5A]"
              }`}
            >
              <ChevronRight size={16} />
            </button>
          </div>
        </div>
      )}

      <DateModal
        isOpen={showDateModal}
        onClose={() => setShowDateModal(false)}
        onDateSubmit={handleDateSubmit}
        StartDate={dateRange.start}
        EndDate={dateRange.end}
      />
    </div>
  );
};

export default TableCard;
