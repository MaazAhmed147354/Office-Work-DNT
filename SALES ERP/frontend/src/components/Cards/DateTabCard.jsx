import { useState, useEffect, useRef } from "react";

const DateTabCard = ({
  selectedTab,
  setSelectedTab,
  selectedValue,
  setSelectedValue,
}) => {
  const [showPicker, setShowPicker] = useState(false);
  const [activeTab, setActiveTab] = useState(null);
  const wrapperRef = useRef(null);

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
      className="bg-[#252538] p-4 rounded-xl border border-[#38384a]"
    >
      <div className="flex justify-center gap-6">
        {["year", "month", "week", "quarter"].map((tab) => (
          <div key={tab} className="flex items-center gap-3">
            <button
              onClick={() => handleTabClick(tab)}
              className={`px-4 py-2 rounded-lg capitalize ${
                selectedTab === tab
                  ? "bg-[#8a4fff] text-white"
                  : "bg-[#38384a] text-gray-300"
              }`}
            >
              {tab}
            </button>

            {/* Picker rendered inline, adjusts other tabs */}
            {showPicker && activeTab === tab && (
              <>
                {tab === "year" && (
                  <input
                    type="number"
                    min="2000"
                    max="2100"
                    placeholder="Year"
                    className="p-2 rounded bg-[#1e1e2f] text-gray-200"
                    onChange={(e) => handleValueChange(e.target.value)}
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
                  <select
                    className="p-2 rounded bg-[#1e1e2f] text-gray-200"
                    onChange={(e) => handleValueChange(e.target.value)}
                  >
                    <option value="">Select Quarter</option>
                    <option value="Q1">Q1 (Jan–Mar)</option>
                    <option value="Q2">Q2 (Apr–Jun)</option>
                    <option value="Q3">Q3 (Jul–Sep)</option>
                    <option value="Q4">Q4 (Oct–Dec)</option>
                  </select>
                )}
              </>
            )}
          </div>
        ))}
      </div>
    </div>
  );
};

export default DateTabCard;
