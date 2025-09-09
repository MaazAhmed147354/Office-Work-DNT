import { useState } from "react";
import { SlidersHorizontal } from "lucide-react";
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
  console.log("FilterData:", salespersons);

  return (
    <div>
      <div className="bg-[#252538] px-4 rounded-xl border border-[#38384a]">
        <div className="flex flex-col md:flex-row md:items-center justify-between gap-4">
          <div className="flex-1 ml-22">
            <DateTabs
              selectedTab={selectedTab}
              setSelectedTab={setSelectedTab}
              selectedValue={selectedValue}
              setSelectedValue={setSelectedValue}
            />
          </div>
          <div>
            <button
              onClick={() => setIsSalesModalOpen(true)}
              className="px-4 py-2 rounded-lg bg-[#38384a] text-gray-300 hover:bg-[#8a4fff] hover:text-white transition-colors whitespace-nowrap"
            >
              <SlidersHorizontal />
            </button>
          </div>
        </div>
      </div>

      <SalesPersonModal
        isOpen={isSalesModalOpen}
        onClose={() => setIsSalesModalOpen(false)}
        salespersons={salespersons}
        selectedSalesIds={selectedSalespersonIds}
        onSelectionChange={setSelectedSalespersonIds}
      />
    </div>
  );
};

export default FilterDataCard;
