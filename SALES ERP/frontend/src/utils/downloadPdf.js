import jsPDF from "jspdf";
import autoTable from "jspdf-autotable";
import html2canvas from "html2canvas";

/**
 * Export charts to PDF (charts passed as refs of canvas elements)
 */
export const downloadPdfWithCharts = async (
  title,
  chartRefs,
  fileName = "report.pdf"
) => {
  const doc = new jsPDF("p", "mm", "a4");
  const pageWidth = doc.internal.pageSize.getWidth();

  // Title
  doc.setFontSize(18);
  doc.setTextColor(51, 51, 51);
  doc.text(title, pageWidth / 2, 20, { align: "center" });

  let yPosition = 35;

  for (let i = 0; i < chartRefs.length; i++) {
    const chartRef = chartRefs[i];
    if (chartRef && chartRef.current) {
      // Capture chart as image
      const canvas = await html2canvas(chartRef.current);
      const imgData = canvas.toDataURL("image/png");

      // Scale image to fit page
      const imgWidth = pageWidth - 40;
      const imgHeight = (canvas.height * imgWidth) / canvas.width;

      if (yPosition + imgHeight > 280) {
        doc.addPage();
        yPosition = 20;
      }

      doc.addImage(imgData, "PNG", 20, yPosition, imgWidth, imgHeight);
      yPosition += imgHeight + 20;
    }
  }

  doc.save(fileName);
};
