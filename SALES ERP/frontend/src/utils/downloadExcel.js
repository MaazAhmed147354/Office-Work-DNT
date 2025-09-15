// import ExcelJS from "exceljs";
// import { saveAs } from "file-saver";

// /**
//  * Export styled Excel Report
//  */
// export const downloadExcelWithTable = async (
//   title,
//   columns,
//   data,
//   fileName = "report.xlsx"
// ) => {
//   const workbook = new ExcelJS.Workbook();
//   const worksheet = workbook.addWorksheet("Report");

//   // Row heights for header area
//   worksheet.getRow(1).height = 50;
//   worksheet.getRow(2).height = 25;
//   worksheet.getRow(3).height = 20;
//   worksheet.getRow(4).height = 20;

//   // Add Logo (top-left)
//   try {
//     const response = await fetch("/dreams.jpg"); // put your logo inside public/logo.png
//     const logoBuffer = await response.arrayBuffer();
//     const logo = workbook.addImage({
//       buffer: logoBuffer,
//       extension: "jpg",
//     });
//     worksheet.addImage(logo, {
//       tl: { col: 0, row: 0 },
//       ext: { width: 115, height: 100 },
//     });
//   } catch (err) {
//     console.warn("Logo not found, skipping...");
//   }

//   // Dreams Network text
//   worksheet.mergeCells("A1:D1");
//   const orgCell = worksheet.getCell("A1");
//   orgCell.value = "Dreams Network";
//   orgCell.font = { size: 18, bold: true, color: { argb: "2563EB" } };
//   orgCell.alignment = { vertical: "middle", horizontal: "center" };

//   // Sales Breakdown
//   worksheet.mergeCells("A2:D2");
//   const reportTitleCell = worksheet.getCell("A2");
//   reportTitleCell.value = "Sales Breakdown";
//   reportTitleCell.font = { size: 14, bold: true, color: { argb: "555555" } };
//   reportTitleCell.alignment = { vertical: "middle", horizontal: "center" };

//   // Report Date
//   worksheet.mergeCells("A3:D3");
//   const dateCell = worksheet.getCell("A3");
//   dateCell.value = `Report Date: ${new Date().toLocaleDateString("en-GB", {
//     day: "2-digit",
//     month: "short",
//     year: "numeric",
//   })}`;
//   dateCell.font = { italic: true, size: 12, color: { argb: "666666" } };
//   dateCell.alignment = { vertical: "middle", horizontal: "center" };

//   // Leave one empty row before table
//   // worksheet.addRow([]);

//   // Table Title Row (merged across all table columns)
//   const tableTitleRow = worksheet.addRow([`${title}`]);
//   worksheet.mergeCells(
//     tableTitleRow.number,
//     1,
//     tableTitleRow.number,
//     columns.length
//   );
//   const tableTitleCell = tableTitleRow.getCell(1);
//   tableTitleCell.font = { size: 14, bold: true, color: { argb: "FF000000" } };
//   tableTitleCell.alignment = { vertical: "middle", horizontal: "center" };
//   tableTitleCell.fill = {
//     type: "pattern",
//     pattern: "solid",
//     fgColor: { argb: "2563EB" }, // blue
//   };
//   tableTitleRow.height = 25;

//   // Table Header Row
//   const headerRow = worksheet.addRow(columns.map((c) => c.header));
//   headerRow.font = { bold: true, color: { argb: "FFFFFF" } };
//   headerRow.alignment = { horizontal: "center", vertical: "middle" };
//   headerRow.height = 20;

//   headerRow.eachCell((cell) => {
//     cell.fill = {
//       type: "pattern",
//       pattern: "solid",
//       fgColor: { argb: "FF4B7CDE" }, // light blue
//     };
//     cell.border = {
//       top: { style: "thin" },
//       left: { style: "thin" },
//       bottom: { style: "thin" },
//       right: { style: "thin" },
//     };
//   });

//   // Table Data Rows
//   data.forEach((row) => {
//     const newRow = worksheet.addRow(columns.map((c) => row[c.field]));
//     newRow.eachCell((cell) => {
//       cell.alignment = { horizontal: "center", vertical: "middle" };
//       cell.fill = {
//         type: "pattern",
//         pattern: "solid",
//         fgColor: { argb: "FFD6E7FA" }, // lighter sky blue
//       };
//       cell.border = {
//         top: { style: "thin" },
//         left: { style: "thin" },
//         bottom: { style: "thin" },
//         right: { style: "thin" },
//       };

//       // Format numbers with commas
//       if (typeof cell.value === "number") {
//         cell.numFmt = "#,##0";
//       }
//     });
//   });

//   // ✅ Calculate totals directly from data
//   const totalSales = data.reduce(
//     (sum, r) => sum + (parseFloat(r.totalSales) || 0),
//     0
//   );
//   const totalOrders = data.reduce(
//     (sum, r) => sum + (parseFloat(r.totalOrders) || 0),
//     0
//   );
//   const totalContribution = data.reduce(
//     (sum, r) => sum + parseFloat(r.percentOfTotal.replace("%", "") || 0),
//     0
//   );

//   // Totals Data Row
//   const totalsRow = worksheet.addRow([
//     "TOTAL", // label under "Period"
//     totalSales,
//     totalOrders,
//     `${totalContribution.toFixed(2)}%`,
//   ]);

//   totalsRow.font = { bold: true, color: { argb: "FFFFFFFF" } };
//   totalsRow.alignment = { horizontal: "center", vertical: "middle" };
//   totalsRow.eachCell((cell) => {
//     cell.fill = {
//       type: "pattern",
//       pattern: "solid",
//       fgColor: { argb: "FF4B7CDE" }, // darker blue for totals
//     };
//     cell.border = {
//       top: { style: "thin" },
//       left: { style: "thin" },
//       bottom: { style: "thin" },
//       right: { style: "thin" },
//     };
//   });

//   // Leave one empty row after table
//   worksheet.addRow([]);

//   // ✅ Add footer row (system generated note)
//   const footerRow = worksheet.addRow([
//     `Generated on ${new Date().toLocaleString("en-GB", {
//       day: "2-digit",
//       month: "short",
//       year: "numeric",
//       hour: "2-digit",
//       hour12: true,
//       minute: "2-digit",
//       second: "2-digit",
//     })}\nThis is a system generated report`,
//   ]);

//   // Merge footer row across all columns
//   worksheet.mergeCells(footerRow.number, 1, footerRow.number, columns.length);

//   const footerCell = footerRow.getCell(1);
//   footerCell.font = { italic: true, size: 11, color: { argb: "FF666666" } };
//   footerCell.alignment = {
//     horizontal: "center",
//     vertical: "middle",
//     wrapText: true, // ✅ enables line breaks
//   };
//   footerRow.height = 40;

//   // Auto column widths
//   worksheet.columns.forEach((col, i) => {
//     const headerText = columns[i]?.header || "";
//     const maxLength = Math.max(
//       headerText.length,
//       ...data.map((row) => row[columns[i]?.field]?.toString().length || 0)
//     );
//     col.width = Math.max(maxLength + 5, 15);
//   });

//   // Save Excel file
//   const buffer = await workbook.xlsx.writeBuffer();
//   saveAs(new Blob([buffer]), fileName);
// };

import ExcelJS from "exceljs";
import { saveAs } from "file-saver";

/**
 * Export styled Excel Report
 * Supports:
 *  - Single table (data = array of rows)
 *  - Multiple tables (data = array of { title, rows })
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
    const response = await fetch("/dreams.jpg");
    const logoBuffer = await response.arrayBuffer();
    const logo = workbook.addImage({
      buffer: logoBuffer,
      extension: "jpg",
    });
    worksheet.addImage(logo, {
      tl: { col: 0, row: 0 },
      ext: { width: 115, height: 100 },
    });
  } catch (err) {
    console.warn("Logo not found, skipping...");
  }

  // Dreams Network text
  worksheet.mergeCells("A1:D1");
  const orgCell = worksheet.getCell("A1");
  orgCell.value = "Dreams Network";
  orgCell.font = {
    name: "Times New Roman",
    size: 18,
    bold: true,
    color: { argb: "2563EB" },
  };
  orgCell.alignment = { vertical: "middle", horizontal: "center" };

  // Sales Breakdown
  worksheet.mergeCells("A2:D2");
  const reportTitleCell = worksheet.getCell("A2");
  reportTitleCell.value = "Sales Breakdown";
  reportTitleCell.font = {
    name: "Times New Roman",
    size: 14,
    bold: true,
    color: { argb: "555555" },
  };
  reportTitleCell.alignment = { vertical: "middle", horizontal: "center" };

  // Report Date
  worksheet.mergeCells("A3:D3");
  const dateCell = worksheet.getCell("A3");
  dateCell.value = `Report Date: ${new Date().toLocaleDateString("en-GB", {
    day: "2-digit",
    month: "short",
    year: "numeric",
  })}`;
  dateCell.font = {
    name: "Times New Roman",
    italic: true,
    size: 12,
    color: { argb: "666666" },
  };
  dateCell.alignment = { vertical: "middle", horizontal: "center" };

  // Leave some spacing before first table
  worksheet.addRow([]);

  // ✅ Normalize to array of tables
  const tables =
    Array.isArray(data) && data[0]?.rows
      ? data.map((t) => ({ ...t, rows: t.rows || [] }))
      : [{ title, rows: data || [] }];

  tables.forEach((table, idx) => {
    // Table Title Row
    const tableTitleRow = worksheet.addRow([table.title]);
    worksheet.mergeCells(
      tableTitleRow.number,
      1,
      tableTitleRow.number,
      columns.length
    );
    const tableTitleCell = tableTitleRow.getCell(1);
    tableTitleCell.font = {
      name: "Times New Roman",
      size: 14,
      bold: true,
      color: { argb: "FF000000" },
    };
    tableTitleCell.alignment = { vertical: "middle", horizontal: "center" };
    tableTitleCell.fill = {
      type: "pattern",
      pattern: "solid",
      fgColor: { argb: "2563EB" }, // blue
    };
    tableTitleRow.height = 25;

    // Header Row
    const headerRow = worksheet.addRow(columns.map((c) => c.header));
    headerRow.font = {
      name: "Times New Roman",
      bold: true,
      color: { argb: "FFFFFF" },
    };
    headerRow.alignment = { horizontal: "center", vertical: "middle" };
    headerRow.height = 20;

    headerRow.eachCell((cell) => {
      cell.fill = {
        type: "pattern",
        pattern: "solid",
        fgColor: { argb: "FF4B7CDE" }, // light blue
      };
      cell.border = {
        top: { style: "thin" },
        left: { style: "thin" },
        bottom: { style: "thin" },
        right: { style: "thin" },
      };
    });

    // Data Rows
    table.rows.forEach((row) => {
      const newRow = worksheet.addRow(columns.map((c) => row[c.field]));
      newRow.eachCell((cell) => {
        cell.alignment = { horizontal: "center", vertical: "middle" };
        cell.fill = {
          type: "pattern",
          pattern: "solid",
          fgColor: { argb: "FFD6E7FA" },
        };
        cell.border = {
          top: { style: "thin" },
          left: { style: "thin" },
          bottom: { style: "thin" },
          right: { style: "thin" },
        };
        if (typeof cell.value === "number") {
          cell.numFmt = "#,##0";
        }
      });
    });

    // Totals Row
    const totalSales = table.rows.reduce(
      (sum, r) => sum + (parseFloat(r.totalSales) || 0),
      0
    );
    const totalOrders = table.rows.reduce(
      (sum, r) => sum + (parseFloat(r.totalOrders) || 0),
      0
    );
    const totalContribution = table.rows.reduce(
      (sum, r) => sum + parseFloat(r.percentOfTotal.replace("%", "") || 0),
      0
    );

    const totalsRow = worksheet.addRow([
      "TOTAL",
      totalSales,
      totalOrders,
      `${totalContribution.toFixed(2)}%`,
    ]);

    totalsRow.font = {
      name: "Times New Roman",
      bold: true,
      color: { argb: "FFFFFFFF" },
    };
    totalsRow.alignment = { horizontal: "center", vertical: "middle" };
    totalsRow.eachCell((cell) => {
      cell.fill = {
        type: "pattern",
        pattern: "solid",
        fgColor: { argb: "FF4B7CDE" },
      };
      cell.border = {
        top: { style: "thin" },
        left: { style: "thin" },
        bottom: { style: "thin" },
        right: { style: "thin" },
      };
    });

    // Leave spacing after each table
    worksheet.addRow([]);
  });

  // Footer
  const footerRow = worksheet.addRow([
    `Generated on ${new Date().toLocaleString("en-GB", {
      day: "2-digit",
      month: "short",
      year: "numeric",
      hour: "2-digit",
      hour12: true,
      minute: "2-digit",
      second: "2-digit",
    })}\nThis is a system generated report`,
  ]);
  worksheet.mergeCells(footerRow.number, 1, footerRow.number, columns.length);

  const footerCell = footerRow.getCell(1);
  footerCell.font = {
    name: "Times New Roman",
    italic: true,
    size: 11,
    color: { argb: "FF666666" },
  };
  footerCell.alignment = {
    horizontal: "center",
    vertical: "middle",
    wrapText: true,
  };
  footerRow.height = 40;

  // Auto column widths
  worksheet.columns.forEach((col, i) => {
    const headerText = columns[i]?.header || "";
    const maxLength = Math.max(
      headerText.length,
      ...tables.flatMap((t) =>
        t.rows.map((row) => row[columns[i]?.field]?.toString().length || 0)
      )
    );
    col.width = Math.max(maxLength + 5, 15);
  });

  // Save Excel file
  const buffer = await workbook.xlsx.writeBuffer();
  saveAs(new Blob([buffer]), fileName);
};
