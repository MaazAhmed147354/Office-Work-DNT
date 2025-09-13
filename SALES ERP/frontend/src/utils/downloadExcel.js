import ExcelJS from "exceljs";
import { saveAs } from "file-saver";

/**
 * Export styled Excel Report
 */
export const downloadExcelWithTable = async (
  title,
  columns,
  data,
  fileName = "report.xlsx"
) => {
  const workbook = new ExcelJS.Workbook();
  const worksheet = workbook.addWorksheet("Report");

  // Row heights for header area
  worksheet.getRow(1).height = 50;
  worksheet.getRow(2).height = 25;
  worksheet.getRow(3).height = 20;
  worksheet.getRow(4).height = 20;

  // Add Logo (top-left)
  try {
    const response = await fetch("/dnt.png"); // put your logo inside public/logo.png
    const logoBuffer = await response.arrayBuffer();
    const logo = workbook.addImage({
      buffer: logoBuffer,
      extension: "png",
    });
    worksheet.addImage(logo, {
      tl: { col: 0, row: 0 },
      ext: { width: 115, height: 100 },
    });
  } catch (err) {
    console.warn("Logo not found, skipping...");
  }

  // Dreams Network text
  worksheet.mergeCells("B1:D1");
  const orgCell = worksheet.getCell("B1");
  orgCell.value = "Dreams Network";
  orgCell.font = { size: 18, bold: true, color: { argb: "6D28D9" } };
  orgCell.alignment = { vertical: "middle", horizontal: "center" };

  // Sales Breakdown
  worksheet.mergeCells("B2:D2");
  const reportTitleCell = worksheet.getCell("B2");
  reportTitleCell.value = "Sales Breakdown";
  reportTitleCell.font = { size: 14, bold: true, color: { argb: "555555" } };
  reportTitleCell.alignment = { vertical: "middle", horizontal: "center" };

  // Report Date
  worksheet.mergeCells("B3:D3");
  const dateCell = worksheet.getCell("B3");
  dateCell.value = `Report Date: ${new Date().toLocaleDateString("en-GB", {
    day: "2-digit",
    month: "short",
    year: "numeric",
  })}`;
  dateCell.font = { italic: true, size: 12, color: { argb: "666666" } };
  dateCell.alignment = { vertical: "middle", horizontal: "center" };

  // Leave one empty row before table
  worksheet.addRow([]);

  // Table Header Row
  const headerRow = worksheet.addRow(columns.map((c) => c.header));
  headerRow.font = { bold: true, color: { argb: "FFFFFF" } };
  headerRow.alignment = { horizontal: "center", vertical: "middle" };
  headerRow.height = 20;

  headerRow.eachCell((cell) => {
    cell.fill = {
      type: "pattern",
      pattern: "solid",
      fgColor: { argb: "2563EB" }, // blue
    };
    cell.border = {
      top: { style: "thin" },
      left: { style: "thin" },
      bottom: { style: "thin" },
      right: { style: "thin" },
    };
  });

  // Table Data Rows
  data.forEach((row) => {
    const newRow = worksheet.addRow(columns.map((c) => row[c.field]));
    newRow.eachCell((cell) => {
      cell.alignment = { horizontal: "center", vertical: "middle" };
      cell.fill = {
        type: "pattern",
        pattern: "solid",
        fgColor: { argb: "C1EDC7" }, // light green
      };
      cell.border = {
        top: { style: "thin" },
        left: { style: "thin" },
        bottom: { style: "thin" },
        right: { style: "thin" },
      };

      // Format numbers with commas
      if (typeof cell.value === "number") {
        cell.numFmt = "#,##0";
      }
    });
  });

  // Auto column widths
  worksheet.columns.forEach((col, i) => {
    const headerText = columns[i]?.header || "";
    const maxLength = Math.max(
      headerText.length,
      ...data.map((row) => row[columns[i]?.field]?.toString().length || 0)
    );
    col.width = Math.max(maxLength + 5, 15);
  });

  // Save Excel file
  const buffer = await workbook.xlsx.writeBuffer();
  saveAs(new Blob([buffer]), fileName);
};
