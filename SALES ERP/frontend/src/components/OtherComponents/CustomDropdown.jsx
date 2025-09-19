import { useState, useRef, useEffect } from "react";

const CustomDropdown = ({
  onSelect,
  selectedValue,
  options,
  placeholder = "Select",
  customWidth = "min-w-[120px]",
  searchable = false,
}) => {
  const [isOpen, setIsOpen] = useState(false);
  const [searchTerm, setSearchTerm] = useState(""); // ✅ NEW STATE
  const dropdownRef = useRef(null);

  const handleSelect = (value) => {
    onSelect(value);
    setIsOpen(false);
    setSearchTerm(""); // ✅ reset search when closing
  };

  // ✅ Close dropdown on outside click
  useEffect(() => {
    const handleClickOutside = (e) => {
      if (dropdownRef.current && !dropdownRef.current.contains(e.target)) {
        setIsOpen(false);
        setSearchTerm("");
      }
    };
    document.addEventListener("mousedown", handleClickOutside);
    return () => document.removeEventListener("mousedown", handleClickOutside);
  }, []);

  // ✅ Filtered options when searchable
  const filteredOptions = searchable
    ? options.filter((option) =>
        option.label.toLowerCase().includes(searchTerm.toLowerCase())
      )
    : options;

  return (
    <div ref={dropdownRef} className="relative">
      <button
        onClick={() => setIsOpen(!isOpen)}
        className={`p-2 rounded bg-[#1e1e2f] text-gray-200 w-full text-left ${customWidth} flex items-center justify-between`}
      >
        <span className="flex-1">{selectedValue || placeholder}</span>
        <span className="ml-2 transform transition-transform">
          {isOpen ? "▲" : "▼"}
        </span>
      </button>

      {isOpen && (
        <div className="absolute top-full left-0 mt-1 bg-[#1e1e2f] border border-[#38384a] rounded shadow-lg z-10 w-full max-h-[200px] overflow-y-auto">
          {/* ✅ Show search input if searchable */}
          {searchable && (
            <div className="p-2 border-b border-[#38384a]">
              <input
                type="text"
                placeholder="Search..."
                value={searchTerm}
                onChange={(e) => setSearchTerm(e.target.value)}
                className="w-full p-1 rounded bg-[#252538] text-gray-200 placeholder-gray-400 focus:outline-none"
              />
            </div>
          )}

          {filteredOptions.length > 0 ? (
            filteredOptions.map((option) => (
              <div
                key={option.value}
                className="p-2 hover:bg-[#8a4fff] cursor-pointer text-gray-200"
                onClick={() => handleSelect(option.value)}
              >
                {option.label}
              </div>
            ))
          ) : (
            <div className="p-2 text-gray-400 italic">No results found</div>
          )}
        </div>
      )}
    </div>
  );
};

export default CustomDropdown;
