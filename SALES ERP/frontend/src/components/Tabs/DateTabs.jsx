import { useState, useEffect, useRef } from "react";
import { ChevronRight, ChevronLeft } from "lucide-react";
import CustomDropdown from "../OtherComponents/CustomDropdown";

const DateTabCard = ({
  selectedTab,
  setSelectedTab,
  selectedValue,
  setSelectedValue,
}) => {
  const [showPicker, setShowPicker] = useState(false);
  const [activeTab, setActiveTab] = useState(null);
  const wrapperRef = useRef(null);

  // Generate years and quarter options
  const quarterOptions = [
    { value: "Q1", label: "Q1 (Jan–Mar)" },
    { value: "Q2", label: "Q2 (Apr–Jun)" },
    { value: "Q3", label: "Q3 (Jul–Sep)" },
    { value: "Q4", label: "Q4 (Oct–Dec)" },
  ];
  const generateYears = () => {
    const currentYear = new Date().getFullYear();
    const options = [];
    for (let year = 2000; year <= currentYear; year++) {
      options.push({
        value: year.toString(), // value as string "2025"
        label: year.toString(), // label as string "2025"
      });
    }
    return options;
  };

  const yearsOptions = generateYears();

  const handleTabClick = (tab) => {
    if (activeTab === tab && showPicker) {
      // If the same tab is open, close it.
      setShowPicker(false);
      setActiveTab(null);
    } else {
      // Open the picker for the clicked tab, close others.
      setActiveTab(tab);
      setShowPicker(true);
    }
  };

  const handleValueChange = (newValue) => {
    if (newValue) {
      // Setting tab and chosen value useState only when both are changed
      setSelectedTab(activeTab);
      setSelectedValue(newValue);

      // Optionally, close the picker after selection
      setShowPicker(false);
      // setActiveTab(null);
    }
  };

  // Close tab and input when clicked outside
  useEffect(() => {
    const handleClickOutside = (e) => {
      if (wrapperRef.current && !wrapperRef.current.contains(e.target)) {
        setShowPicker(false);
        setActiveTab(null);
      }
    };
    document.addEventListener("mousedown", handleClickOutside);
    return () => document.removeEventListener("mousedown", handleClickOutside);
  }, [setSelectedTab]);

  return (
    <div
      ref={wrapperRef}
      className="bg-[#252538] p-0 rounded-xl border-none border-[#38384a]"
    >
      <div className="flex gap-2">
        {["week", "month", "quarter", "year"].map((tab) => {
          const isActive = activeTab === tab && showPicker;
          return (
            <div key={tab} className="flex items-center gap-3">
              <button
                onClick={() => handleTabClick(tab)}
                className={`flex items-center gap-2 px-4 py-2 rounded-lg capitalize ${
                  selectedTab === tab
                    ? "bg-[#8a4fff] text-white"
                    : "bg-[#38384a] text-gray-300"
                }`}
              >
                {tab}
                {isActive ? (
                  <ChevronLeft size={16} />
                ) : (
                  <ChevronRight size={16} />
                )}
              </button>

              {/* Picker rendered inline, adjusts other tabs */}
              {showPicker && activeTab === tab && (
                <>
                  {tab === "year" && (
                    <CustomDropdown
                      key="year-dropdown"
                      onSelect={handleValueChange}
                      selectedValue={
                        selectedTab === "year" ? selectedValue : ""
                      }
                      options={yearsOptions}
                      placeholder="Select Year"
                      customWidth="min-w-[120px]"
                    />
                  )}
                  {tab === "month" && (
                    <input
                      type="month"
                      className="p-2 rounded bg-[#1e1e2f] text-gray-200"
                      onChange={(e) => handleValueChange(e.target.value)}
                    />
                  )}
                  {tab === "week" && (
                    <input
                      type="week"
                      className="p-2 rounded bg-[#1e1e2f] text-gray-200"
                      onChange={(e) => handleValueChange(e.target.value)}
                    />
                  )}
                  {tab === "quarter" && (
                    <CustomDropdown
                      key="quarter-dropdown"
                      onSelect={handleValueChange}
                      selectedValue={
                        selectedTab === "quarter" ? selectedValue : ""
                      }
                      options={quarterOptions}
                      placeholder="Select Quarter"
                    />
                  )}
                </>
              )}
            </div>
          );
        })}
      </div>
    </div>
  );
};

export default DateTabCard;
