import { useState, useMemo } from "react";
import { ChevronDown, ChevronUp } from "lucide-react";
import DownloadButton from "./DownloadButton";
import GlobalPaginationTable from "../Tables/GlobalPaginationTable";

const Accordion = ({ data }) => {
  if (!data || data.length === 0) {
    return (
      <div className="bg-[#252538] rounded-xl p-6 border border-[#38384a] text-gray-400 text-sm">
        No accordion data available
      </div>
    );
  }

  const [openIndex, setOpenIndex] = useState(null);

  const toggleAccordion = (index) => {
    setOpenIndex(openIndex === index ? null : index);
  };

  // ✅ Transform sales data once, reuse everywhere
  const transformedData = useMemo(() => {
    return data.map((item) => ({
      name: item.name,
      rows: item.sales.map((sale) => ({
        period: sale.period,
        totalSales: sale.totalSales,
        totalOrders: sale.totalOrders,
        percentOfTotal: `${sale.percentOfTotal.toFixed(2)}%`,
      })),
    }));
  }, [data]);

  // ✅ Collect all tables data for Download All
  const allTablesData = transformedData.map((sp) => ({
    title: `Sales Performance - ${sp.name.toUpperCase()}`,
    rows: sp.rows,
  }));

  // ✅ Shared columns (used by both single + all)
  const columns = [
    { header: "Period 🗓️", field: "period" },
    { header: "Total Sales 💵", field: "totalSales" },
    { header: "Total Orders 🗳️", field: "totalOrders" },
    {
      header: "Contribution in Total Sales",
      field: "percentOfTotal",
    },
  ];

  return (
    <div className="space-y-4">
      {/* ✅ Download All Button */}
      <div className="flex justify-end">
        <DownloadButton
          type="excel"
          buttonText="Download All"
          title="All Salespersons Performance"
          multiData={allTablesData} // new prop
          columns={columns}
        />
      </div>

      {/* Accordions */}
      <div className="space-y-0 grid grid-cols-2 gap-4">
        {transformedData.map((sp, index) => (
          <div
            key={index}
            className="bg-[#252538] border border-[#38384a] rounded-xl overflow-hidden col-span-2"
          >
            <button
              onClick={() => toggleAccordion(index)}
              className="w-full text-left p-4 flex justify-between items-center hover:bg-[#38384a]"
            >
              <span className="font-medium text-[#BEB7DF]">{sp.name}</span>
              <span className="text-gray-400">
                {openIndex === index
                  ? <ChevronUp /> || "▲"
                  : <ChevronDown /> || "▼"}
              </span>
            </button>

            {openIndex === index && (
              <div className="px-4 py-2 space-y-4">
                {/* Download Button */}
                <div className="flex items-center justify-end">
                  <DownloadButton
                    type="excel"
                    buttonText="Download Excel"
                    title={`Sales Performance - ${sp.name.toUpperCase()}`}
                    data={sp.rows}
                    columns={columns}
                  />
                </div>
                <GlobalPaginationTable
                  title="Sales Performance Over Time"
                  data={sp.rows}
                  keyField="period"
                  columns={[
                    {
                      header: "Period 🗓️",
                      field: "period",
                      style: "text-left",
                    },
                    {
                      header: "Total Sales 💲",
                      field: "totalSales",
                      style: "text-left text-green-500",
                    },
                    {
                      header: "Total Orders 🗳️",
                      field: "totalOrders",
                      style: "text-center",
                    },
                    {
                      header: "% of Total",
                      field: "percentOfTotal",
                      style: "text-center",
                    },
                  ]}
                  rowsPerPage={5}
                />
              </div>
            )}
          </div>
        ))}
      </div>
    </div>
  );
};

export default Accordion;
