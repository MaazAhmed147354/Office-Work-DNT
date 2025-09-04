import { useState } from "react";
import GlobalMarqueeTable from "../Tables/GlobalMarqueeTable";

const Accordion = ({ data }) => {
  const [openIndex, setOpenIndex] = useState(null);

  const toggleAccordion = (index) => {
    setOpenIndex(openIndex === index ? null : index);
  };

  // Dummy table data
  const dummyTableData = [
    { name: "Product A", sales: 1200, profit: 400 },
    { name: "Product B", sales: 950, profit: 320 },
    { name: "Product C", sales: 720, profit: 280 },
  ];

  return (
    <div className="space-y-4">
      {data.map((item, index) => (
        <div
          key={index}
          className="bg-[#252538] border border-[#38384a] rounded-xl overflow-hidden"
        >
          {/* Accordion Header */}
          <button
            onClick={() => toggleAccordion(index)}
            className="w-full text-left p-4 flex justify-between items-center hover:bg-[#38384a]"
          >
            <span className="font-medium text-[#BEB7DF]">
              {item.salesperson}
            </span>
            <span className="text-gray-400">
              {openIndex === index ? "▲" : "▼"}
            </span>
          </button>

          {/* Accordion Body */}
          {openIndex === index && (
            <div className="p-4">
              {/* <GlobalMarqueeTable tab={tab} value={value} sales={item.sales} /> */}
              <GlobalMarqueeTable
                title="Sales Performance"
                data={dummyTableData}
                keyField="name"
                columns={[
                  { header: "Product", field: "name" },
                  { header: "Sales", field: "sales" },
                  { header: "Profit", field: "profit" },
                ]}
              />
            </div>
          )}
        </div>
      ))}
    </div>
  );
};

export default Accordion;
