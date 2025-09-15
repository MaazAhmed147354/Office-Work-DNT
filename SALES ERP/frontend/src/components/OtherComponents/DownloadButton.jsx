import { FileDown, FileSpreadsheet } from "lucide-react";
import { downloadPdfWithCharts } from "../../utils/downloadPdf";
import { downloadExcelWithTable } from "../../utils/downloadExcel";

/**
 * DownloadButton
 * @param {string} type - "pdf" | "excel"
 * @param {string} title - Report title
 * @param {Array} columns - Table columns (for Excel)
 * @param {Array} data - Table data (for Excel, single table)
 * @param {Array} multiData - Array of { title, rows } (for Excel, multiple tables)
 * @param {Array} chartRefs - Chart refs (for PDF)
 */
const DownloadButton = ({
  type,
  title,
  columns,
  data,
  multiData,
  chartRefs,
}) => {
  const handleDownload = async () => {
    if (type === "pdf") {
      await downloadPdfWithCharts(title, chartRefs, `${title}.pdf`);
    } else if (type === "excel") {
      downloadExcelWithTable(
        title,
        columns,
        multiData || data,
        `${title}.xlsx`
      );
    }
  };

  return (
    <button
      onClick={handleDownload}
      className={`flex items-center gap-2 px-4 py-2 rounded-lg transition text-white ${
        type === "pdf"
          ? "bg-red-500 hover:bg-red-600"
          : "bg-green-600 hover:bg-green-700"
      }`}
    >
      {type === "pdf" ? (
        <>
          <FileDown size={18} /> Download PDF
        </>
      ) : (
        <>
          <FileSpreadsheet size={18} /> Download Excel
        </>
      )}
    </button>
  );
};

export default DownloadButton;
