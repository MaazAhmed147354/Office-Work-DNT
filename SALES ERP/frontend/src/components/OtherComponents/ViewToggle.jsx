import { PieChart, Table } from "lucide-react";

const ViewToggle = ({ onToggle, viewMode }) => (
  <div className="flex items-center rounded-lg mb-4">
    <button
      onClick={() => onToggle("graphical")}
      className={`flex items-center gap-2 px-4 py-2 rounded-md transition-colors ${
        viewMode === "graphical"
          ? "bg-[#8a4fff] text-white"
          : "text-gray-300 hover:text-white"
      }`}
    >
      <PieChart size={18} />
      <span>Graphical</span>
    </button>

    <button
      onClick={() => onToggle("tabular")}
      className={`flex items-center gap-2 px-4 py-2 rounded-md transition-colors ${
        viewMode === "tabular"
          ? "bg-[#8a4fff] text-white"
          : "text-gray-300 hover:text-white"
      }`}
    >
      <Table size={18} />
      <span>Tabular</span>
    </button>
  </div>
);

export default ViewToggle;
