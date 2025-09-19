import jsPDF from "jspdf";
import html2canvas from "html2canvas";

/**
 * Generate styled PDF with chart cards (screenshots of cards)
 * @param {string} title - Report title
 * @param {Array} cardRefs - Array of refs to Card components (Cards with heading + chart)
 * @param {string} fileName - Output PDF filename
 * @param {string} customSize - Optional custom size { width, height } for each chart image
 */
export const downloadPdfWithCharts = async (
  title,
  cardRefs,
  fileName = "report.pdf",
  customSize = {} // 👈 new optional param
) => {
  const { width: customWidth, height: customHeight } = customSize;
  const doc = new jsPDF("p", "pt", "a4");
  const pageWidth = doc.internal.pageSize.getWidth();
  const margin = 40;
  let yPos = margin;

  // ✅ Logo
  try {
    const logo = await fetch("/dreams.jpg");
    const logoBuffer = await logo.arrayBuffer();
    const base64Logo = btoa(
      new Uint8Array(logoBuffer).reduce(
        (data, byte) => data + String.fromCharCode(byte),
        ""
      )
    );
    doc.addImage(
      `data:image/jpeg;base64,${base64Logo}`,
      "JPEG",
      margin,
      yPos,
      60,
      60
    );
  } catch {
    console.warn("Logo not found, skipping...");
  }

  // ✅ Heading
  doc.setFont("times", "bold");
  doc.setFontSize(18);
  doc.text("DREAMS NETWORK", pageWidth / 2, yPos + 20, { align: "center" });
  doc.setFontSize(14);
  doc.text(title.toUpperCase(), pageWidth / 2, yPos + 45, { align: "center" });
  yPos += 100;

  // ✅ Loop charts
  for (let i = 0; i < cardRefs.length; i++) {
    const cardRef = cardRefs[i];
    if (!cardRef?.current) continue;

    const canvas = await html2canvas(cardRef.current, { scale: 2 });
    const imgData = canvas.toDataURL("image/png");

    // 👇 Allow override with custom width/height
    const imgWidth = customWidth || pageWidth - margin * 2;
    const imgHeight = customHeight || (canvas.height * imgWidth) / canvas.width;
    const xPos = (pageWidth - imgWidth) / 2; // ✅ center horizontally

    doc.addImage(imgData, "PNG", xPos, yPos, imgWidth, imgHeight);
    yPos += imgHeight + 20;
  }

  // ✅ Footer
  doc.setFont("helvetica", "italic");
  doc.setFontSize(10);
  doc.text(
    `Generated on ${new Date().toLocaleString("en-GB")}`,
    pageWidth / 2,
    doc.internal.pageSize.getHeight() - 30,
    { align: "center" }
  );
  doc.text(
    "This is a system-generated report.",
    pageWidth / 2,
    doc.internal.pageSize.getHeight() - 15,
    { align: "center" }
  );

  doc.save(fileName);
};
