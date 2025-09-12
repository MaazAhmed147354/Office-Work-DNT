import { useState } from "react";
import { SlidersHorizontal, Funnel } from "lucide-react";
import DateTabs from "../Tabs/DateTabs";
import SalesPersonModal from "../Modals/SalesPersonModal";

const FilterDataCard = ({
  selectedTab,
  setSelectedTab,
  selectedValue,
  setSelectedValue,
  salespersons,
  selectedSalespersonIds,
  setSelectedSalespersonIds,
}) => {
  const [isSalesModalOpen, setIsSalesModalOpen] = useState(false);

  return (
    <div>
      <div className="bg-[#252538] p-4 rounded-xl border border-[#38384a]">
        <div className="flex flex-col lg:flex-row items-center justify-center gap-4 lg:gap-8">
          {/* Date Selection Section */}
          <div className="flex gap-2">
            <h2 className="flex items-center gap-2 text-base md:text-md font-semibold text-[#BEB7DF] tracking-wide">
              <Funnel />
              <span className="hidden md:inline">Select Date</span>
            </h2>
            <div className="">
              <DateTabs
                selectedTab={selectedTab}
                setSelectedTab={setSelectedTab}
                selectedValue={selectedValue}
                setSelectedValue={setSelectedValue}
              />
            </div>
          </div>
          {/* Salesperson Selection Section */}
          <div className="flex gap-2">
            <h2 className="flex items-center gap-2 text-base md:text-md font-semibold text-[#BEB7DF] tracking-wide">
              <Funnel />
              <span className="hidden md:inline">Select Salespersons</span>
            </h2>
            <div>
              <button
                onClick={() => setIsSalesModalOpen(true)}
                className="px-4 py-2 gap-2 rounded-lg bg-[#38384a] text-gray-300 hover:bg-[#8a4fff] hover:text-white transition-colors whitespace-nowrap"
              >
                <SlidersHorizontal />
              </button>
            </div>
          </div>
        </div>
      </div>

      <SalesPersonModal
        isOpen={isSalesModalOpen}
        onClose={() => setIsSalesModalOpen(false)}
        salespersons={salespersons}
        selectedSalespersonIds={selectedSalespersonIds}
        setSelectedSalespersonIds={setSelectedSalespersonIds}
      />
    </div>
  );
};

export default FilterDataCard;
