import { useState } from "react";
import { Calendar, X } from "lucide-react";

const DateModal = ({
  isOpen,
  onClose,
  onDateSubmit,
  StartDate = "",
  EndDate = "",
}) => {
  const [startDate, setStartDate] = useState(StartDate);
  const [endDate, setEndDate] = useState(EndDate);

  const handleSubmit = (e) => {
    e.preventDefault();
    if (startDate && endDate) {
      onDateSubmit(startDate, endDate);
      onClose();
    }
  };

  if (!isOpen) return null;

  return (
    <div className="fixed inset-0 z-50 flex items-center justify-center bg-black/50 backdrop-blur-sm">
      <div className="relative bg-[#252538] rounded-xl border border-[#38384a] p-6 w-full max-w-md mx-4">
        {/* Close button */}
        <button
          onClick={onClose}
          className="absolute top-4 right-4 p-1 rounded-full hover:bg-[#38384a] transition-colors"
        >
          <X className="w-5 h-5 text-[#BEB7DF]" />
        </button>

        {/* Modal content */}
        <div className="text-center">
          <div className="flex items-center justify-center gap-2 mb-4">
            <Calendar className="text-[#8a4fff]" />
            <h3 className="text-xl font-semibold text-[#BEB7DF]">
              Select Date Range
            </h3>
          </div>

          <form onSubmit={handleSubmit} className="space-y-4">
            <div className="space-y-2">
              <label className="block text-sm font-medium text-[#BEB7DF] text-left">
                Start Date
              </label>
              <input
                type="date"
                value={startDate}
                onChange={(e) => setStartDate(e.target.value)}
                className="w-full px-3 py-2 bg-[#1e1e2d] border border-[#38384a] rounded focus:outline-none focus:ring-2 focus:ring-[#8a4fff] text-[#BEB7DF]"
                required
              />
            </div>

            <div className="space-y-2">
              <label className="block text-sm font-medium text-[#BEB7DF] text-left">
                End Date
              </label>
              <input
                type="date"
                value={endDate}
                onChange={(e) => setEndDate(e.target.value)}
                className="w-full px-3 py-2 bg-[#1e1e2d] border border-[#38384a] rounded focus:outline-none focus:ring-2 focus:ring-[#8a4fff] text-[#BEB7DF]"
                min={startDate}
                required
              />
            </div>

            <div className="flex justify-center gap-4 pt-4">
              <button
                type="button"
                onClick={onClose}
                className="px-6 py-2 bg-[#38384a] text-[#BEB7DF] rounded-lg hover:bg-[#4A4B5A] transition-colors"
              >
                Cancel
              </button>
              <button
                type="submit"
                className="px-6 py-2 bg-[#8a4fff] text-white rounded-lg hover:bg-[#7a3fe6] transition-colors"
              >
                Apply Dates
              </button>
            </div>
          </form>
        </div>
      </div>
    </div>
  );
};

export default DateModal;
