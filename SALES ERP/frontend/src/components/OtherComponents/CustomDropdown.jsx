import { useState, useRef, useEffect } from "react";

const CustomDropdown = ({
  onSelect,
  selectedValue,
  options,
  placeholder = "Select",
}) => {
  const [isOpen, setIsOpen] = useState(false);
  const dropdownRef = useRef(null);

  const handleSelect = (value) => {
    onSelect(value);
    setIsOpen(false);
  };

  useEffect(() => {
    const handleClickOutside = (e) => {
      if (dropdownRef.current && !dropdownRef.current.contains(e.target)) {
        setIsOpen(false);
      }
    };
    document.addEventListener("mousedown", handleClickOutside);
    return () => document.removeEventListener("mousedown", handleClickOutside);
  }, []);

  return (
    <div ref={dropdownRef} className="relative">
      <button
        onClick={() => setIsOpen(!isOpen)}
        className="p-2 rounded bg-[#1e1e2f] text-gray-200 w-full text-left min-w-[120px] flex items-center justify-between"
      >
        <span className="flex-1">{selectedValue || placeholder}</span>
        <span className="ml-2 transform transition-transform">
          {isOpen ? "▲" : "▼"}
        </span>
      </button>

      {isOpen && (
        <div className="absolute top-full left-0 mt-1 bg-[#1e1e2f] border border-[#38384a] rounded shadow-lg z-10 w-full max-h-[160px] overflow-y-auto">
          {options.map((option) => (
            <div
              key={option.value}
              className="p-2 hover:bg-[#8a4fff] cursor-pointer text-gray-200"
              onClick={() => handleSelect(option.value)}
            >
              {option.label}
            </div>
          ))}
        </div>
      )}
    </div>
  );
};

export default CustomDropdown;
