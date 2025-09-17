import { useState, useEffect, useRef } from "react";

const ProductsModal = ({
  isOpen,
  onClose,
  brands = [],
  selectedProductIds = [],
  setSelectedProductIds,
}) => {
  const [localSelectedIds, setLocalSelectedIds] = useState(selectedProductIds);
  const [expandedBrands, setExpandedBrands] = useState([]);
  const [brandSearch, setBrandSearch] = useState("");
  const [productSearch, setProductSearch] = useState({}); // per-brand search

  useEffect(() => {
    setLocalSelectedIds(selectedProductIds);
  }, [selectedProductIds, isOpen]);

  // ✅ Handle individual product checkbox
  const handleProductCheckboxChange = (id) => {
    const newSelectedIds = localSelectedIds.includes(id)
      ? localSelectedIds.filter((selectedId) => selectedId !== id)
      : [...localSelectedIds, id];
    setLocalSelectedIds(newSelectedIds);
  };

  // ✅ Handle brand checkbox (Select/Deselect all products in brand)
  const handleBrandCheckboxChange = (brand, isChecked) => {
    if (isChecked) {
      const newIds = [
        ...new Set([...localSelectedIds, ...brand.products.map((p) => p.id)]),
      ];
      setLocalSelectedIds(newIds);
    } else {
      const newIds = localSelectedIds.filter(
        (id) => !brand.products.some((p) => p.id === id)
      );
      setLocalSelectedIds(newIds);
    }
  };

  const handleApply = () => {
    setSelectedProductIds(localSelectedIds);
    onClose();
  };

  const toggleBrandExpand = (brandId) => {
    setExpandedBrands((prev) =>
      prev.includes(brandId)
        ? prev.filter((id) => id !== brandId)
        : [...prev, brandId]
    );
  };

  if (!isOpen) return null;

  // Filter brands based on brandSearch
  const filteredBrands = brands.filter((b) =>
    b.name.toLowerCase().includes(brandSearch.toLowerCase())
  );

  return (
    <>
      {/* Backdrop */}
      <div
        className="fixed inset-0 bg-black/50 backdrop-blur-sm z-40"
        onClick={onClose}
      ></div>

      {/* Modal */}
      <div className="fixed left-1/2 top-1/2 transform -translate-x-1/2 -translate-y-1/2 bg-[#252538] border border-[#38384a] rounded-xl p-6 z-50 w-[420px] max-h-[80vh] overflow-auto">
        <h3 className="text-lg font-medium text-[#BEB7DF] mb-4">
          Select Brands & Products
        </h3>

        {/* Brand Search */}
        <input
          type="text"
          value={brandSearch}
          onChange={(e) => setBrandSearch(e.target.value)}
          placeholder="Search brands..."
          className="w-full mb-4 px-3 py-2 rounded bg-[#2d2d42] text-gray-200 focus:outline-none focus:ring-2 focus:ring-[#8a4fff]"
        />

        {/* Brands & Products */}
        <div className="space-y-3">
          {filteredBrands.length === 0 ? (
            <div className="text-gray-400 text-center py-4">
              No brands found
            </div>
          ) : (
            filteredBrands.map((brand) => {
              const isExpanded = expandedBrands.includes(brand.id);
              const searchQuery = productSearch[brand.id] || "";

              // Filter products inside brand
              const filteredProducts = brand.products.filter((p) =>
                p.name.toLowerCase().includes(searchQuery.toLowerCase())
              );

              // ✅ Determine brand checkbox state
              const allSelected = brand.products.every((p) =>
                localSelectedIds.includes(p.id)
              );
              const anySelected = brand.products.some((p) =>
                localSelectedIds.includes(p.id)
              );
              const isIndeterminate = anySelected && !allSelected;

              return (
                <div
                  key={brand.id}
                  className="border border-[#38384a] rounded-lg"
                >
                  {/* Brand Row with Checkbox */}
                  <div
                    className="flex justify-between items-center px-3 py-2 cursor-pointer hover:bg-[#38384a] rounded-t-lg"
                    onClick={() => toggleBrandExpand(brand.id)}
                  >
                    <div className="flex items-center gap-2">
                      <input
                        ref={(el) => {
                          if (el) el.indeterminate = isIndeterminate;
                        }}
                        type="checkbox"
                        checked={allSelected}
                        onChange={(e) =>
                          handleBrandCheckboxChange(brand, e.target.checked)
                        }
                        onClick={(e) => e.stopPropagation()}
                        className="rounded text-[#8a4fff] focus:ring-[#8a4fff]"
                      />
                      <span className="text-[#BEB7DF] font-medium">
                        {brand.name}
                      </span>
                    </div>
                    <span className="text-gray-400">
                      {isExpanded ? "▲" : "▼"}
                    </span>
                  </div>

                  {/* Expanded: Products */}
                  {isExpanded && (
                    <div className="p-3 space-y-2">
                      {/* Product Search */}
                      <input
                        type="text"
                        value={searchQuery}
                        onChange={(e) =>
                          setProductSearch({
                            ...productSearch,
                            [brand.id]: e.target.value,
                          })
                        }
                        placeholder="Search products..."
                        className="w-full mb-2 px-2 py-1 rounded bg-[#2d2d42] text-gray-200 text-sm focus:outline-none focus:ring-2 focus:ring-[#8a4fff]"
                      />

                      {filteredProducts.length === 0 ? (
                        <div className="text-gray-400 text-center text-sm">
                          No products found
                        </div>
                      ) : (
                        filteredProducts.map((product) => (
                          <label
                            key={product.id}
                            className="flex items-center p-1 hover:bg-[#38384a] rounded cursor-pointer"
                          >
                            <input
                              type="checkbox"
                              checked={localSelectedIds.includes(product.id)}
                              onChange={() =>
                                handleProductCheckboxChange(product.id)
                              }
                              className="mr-2 rounded text-[#8a4fff] focus:ring-[#8a4fff]"
                            />
                            <span className="text-gray-200 text-sm">
                              {product.name}
                            </span>
                          </label>
                        ))
                      )}
                    </div>
                  )}
                </div>
              );
            })
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

export default ProductsModal;
