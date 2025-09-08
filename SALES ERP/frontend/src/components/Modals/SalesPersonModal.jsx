import { useState, useEffect } from "react";

const SalespersonModal = ({
  isOpen,
  onClose,
  salespersons = [],
  selectedSalesIds = [],
  onSelectionChange,
}) => {
  // Local state to track selections before applying
  const [localSelectedIds, setLocalSelectedIds] = useState(selectedSalesIds);

  // Update local state when modal opens or parent selectedSalesIds changes
  useEffect(() => {
    setLocalSelectedIds(selectedSalesIds);
  }, [selectedSalesIds, isOpen]); // Reset when modal opens or parent selection changes

  // Handle checkbox change
  const handleCheckboxChange = (id) => {
    const newSelectedIds = selectedSalesIds.includes(id)
      ? selectedSalesIds.filter((selectedId) => selectedId !== id)
      : [...selectedSalesIds, id];

    setLocalSelectedIds(newSelectedIds);
  };

  // Select All / Deselect All logic
  const handleSelectAll = (e) => {
    if (e.target.checked) {
      setLocalSelectedIds(salespersons.map((sp) => sp.id));
    } else {
      setLocalSelectedIds([]);
    }
  };

  // Apply the selection and close modal
  const handleApply = () => {
    onSelectionChange(localSelectedIds); // Update parent state
    onClose(); // Close modal
  };

  // Check if all are selected for the "Select All" checkbox
  const isAllSelected =
    (salespersons?.length ?? 0) > 0 &&
    localSelectedIds.length === salespersons.length;

  if (!isOpen) return null;

  return (
    <>
      {/* Backdrop */}
      <div
        className="fixed inset-0 bg-black/50 backdrop-blur-sm z-40"
        onClick={onClose}
      ></div>

      {/* Modal */}
      <div className="fixed left-1/2 top-1/2 transform -translate-x-1/2 -translate-y-1/2 bg-[#252538] border border-[#38384a] rounded-xl p-6 z-50 w-80 max-h-96 overflow-auto">
        <h3 className="text-lg font-medium text-[#BEB7DF] mb-4">
          Select Salespersons
        </h3>

        {/* Select All Checkbox - Only show if we have salespersons */}
        {salespersons.length > 0 && (
          <>
            <label className="flex items-center mb-3 p-2 hover:bg-[#38384a] rounded cursor-pointer">
              <input
                type="checkbox"
                checked={isAllSelected}
                onChange={handleSelectAll}
                className="mr-3 rounded text-[#8a4fff] focus:ring-[#8a4fff]"
              />
              <span className="text-gray-200">Select All</span>
            </label>
            <hr className="border-[#38384a] my-2" />
          </>
        )}

        {/* Salespersons List - Show loading or empty state */}
        <div className="space-y-2">
          {salespersons.length === 0 ? (
            <div className="text-gray-400 text-center py-4">
              No salespersons available
            </div>
          ) : (
            salespersons.map((person) => (
              <label
                key={person.id}
                className="flex items-center p-2 hover:bg-[#38384a] rounded cursor-pointer"
              >
                <input
                  type="checkbox"
                  checked={localSelectedIds.includes(person.id)}
                  onChange={() => handleCheckboxChange(person.id)}
                  className="mr-3 rounded text-[#8a4fff] focus:ring-[#8a4fff]"
                />
                <span className="text-gray-200">
                  {person.username || person.name}
                </span>
              </label>
            ))
          )}
        </div>

        {/* Action Buttons */}
        <div className="flex justify-end gap-3 mt-6">
          <button
            onClick={onClose}
            className="px-4 py-2 bg-[#38384a] text-gray-300 rounded-lg hover:bg-[#8a4fff] hover:text-white transition-colors"
          >
            Cancel
          </button>
          <button
            onClick={handleApply}
            className="px-4 py-2 bg-[#8a4fff] text-white rounded-lg hover:bg-[#7935e0] transition-colors"
          >
            Apply
          </button>
        </div>
      </div>
    </>
  );
};

export default SalespersonModal;
