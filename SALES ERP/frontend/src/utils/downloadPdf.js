import jsPDF from "jspdf";
import html2canvas from "html2canvas";

/**
 * Generate styled PDF with chart cards (screenshots of cards)
 * @param {string} title - Report title
 * @param {Array} cardRefs - Array of refs to Card components (Cards with heading + chart)
 * @param {string} fileName - Output PDF filename
 */
export const downloadPdfWithCharts = async (
  title,
  cardRefs,
  fileName = "report.pdf"
) => {
  const doc = new jsPDF("p", "pt", "a4");
  const pageWidth = doc.internal.pageSize.getWidth();
  const margin = 40;
  let yPos = margin;

  // ✅ Add Logo
  try {
    const logo = await fetch("/dreams.jpg"); // place logo in /public
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

  // ✅ Add Heading
  doc.setFont("helvetica", "bold");
  doc.setFontSize(18);
  doc.text("DREAMS NETWORK", pageWidth / 2, yPos + 20, { align: "center" });
  doc.setFontSize(14);
  doc.text(title.toUpperCase(), pageWidth / 2, yPos + 45, { align: "center" });
  yPos += 100;

  // ✅ Add each Card as screenshot
  for (let i = 0; i < cardRefs.length; i++) {
    const cardRef = cardRefs[i];
    if (!cardRef?.current) continue;

    const canvas = await html2canvas(cardRef.current, { scale: 2 });
    const imgData = canvas.toDataURL("image/png");

    const imgWidth = pageWidth - margin * 2;
    const imgHeight = (canvas.height * imgWidth) / canvas.width;

    // Render directly under heading
    doc.addImage(imgData, "PNG", margin, yPos, imgWidth, imgHeight);
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
