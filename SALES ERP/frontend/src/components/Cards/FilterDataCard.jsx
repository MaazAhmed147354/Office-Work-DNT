import { useState } from "react";
import { SlidersHorizontal, Funnel } from "lucide-react";
import DateTabs from "../Tabs/DateTabs";
import SalesPersonModal from "../Modals/SalesPersonModal";
import ProductsModal from "../Modals/ProductsModal";

const FilterDataCard = ({
  context, // "sales" | "products"
  selectedTab,
  setSelectedTab,
  selectedValue,
  setSelectedValue,
  listData, // salespersons OR brands
  selectedIds,
  setSelectedIds,
  selectedBrandIds,
  setSelectedBrandIds,
}) => {
  const [isModalOpen, setIsModalOpen] = useState(false);

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
          {/* Salesperson/Brand Selection Section */}
          <div className="flex gap-2">
            <h2 className="flex items-center gap-2 text-base md:text-md font-semibold text-[#BEB7DF] tracking-wide">
              <Funnel />
              <span className="hidden md:inline">
                {context === "sales"
                  ? "Select Salespersons"
                  : "Select Products"}
              </span>
            </h2>
            <div>
              <button
                onClick={() => setIsModalOpen(true)}
                className="px-4 py-2 gap-2 rounded-lg bg-[#38384a] text-gray-300 hover:bg-[#8a4fff] hover:text-white transition-colors whitespace-nowrap"
              >
                <SlidersHorizontal />
              </button>
            </div>
          </div>
        </div>
      </div>

      {/* Conditionally render modal */}
      {context === "sales" && (
        <SalesPersonModal
          isOpen={isModalOpen}
          onClose={() => setIsModalOpen(false)}
          salespersons={listData}
          selectedSalespersonIds={selectedIds}
          setSelectedSalespersonIds={setSelectedIds}
        />
      )}
      {context === "products" && (
        <ProductsModal
          isOpen={isModalOpen}
          onClose={() => setIsModalOpen(false)}
          brands={listData}
          selectedBrandIds={selectedBrandIds}
          setSelectedBrandIds={setSelectedBrandIds}
          selectedProductIds={selectedIds}
          setSelectedProductIds={setSelectedIds}
        />
      )}
    </div>
  );
};

export default FilterDataCard;
