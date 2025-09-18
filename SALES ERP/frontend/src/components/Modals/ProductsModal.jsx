import { useState, useEffect, useRef } from "react";

const ProductsModal = ({
  isOpen,
  onClose,
  brands = [],
  selectedBrandIds = [],
  setSelectedBrandIds,
  selectedProductIds = [],
  setSelectedProductIds,
}) => {
  const [localSelectedBrandIds, setLocalSelectedBrandIds] =
    useState(selectedBrandIds);
  const [localSelectedProductIds, setLocalSelectedProductIds] =
    useState(selectedProductIds);
  const [expandedBrands, setExpandedBrands] = useState([]);
  const [brandSearch, setBrandSearch] = useState("");
  const [productSearch, setProductSearch] = useState({});
  const selectAllRef = useRef(null);

  // Sync only when modal opens
  useEffect(() => {
    if (isOpen) {
      setLocalSelectedBrandIds(selectedBrandIds);
      setLocalSelectedProductIds(selectedProductIds);
    }
  }, [isOpen]);

  // ✅ update indeterminate state for Select All Brands
  useEffect(() => {
    if (!selectAllRef.current) return;
    if (
      localSelectedBrandIds.length > 0 &&
      localSelectedBrandIds.length < brands.length
    ) {
      selectAllRef.current.indeterminate = true;
    } else {
      selectAllRef.current.indeterminate = false;
    }
  }, [localSelectedBrandIds, brands.length]);

  const handleBrandCheckboxChange = (brand) => {
    const brandProductIds = brand.products.map((p) => p.id);

    if (localSelectedBrandIds.includes(brand.id)) {
      // Unselect brand & its products
      setLocalSelectedBrandIds(
        localSelectedBrandIds.filter((id) => id !== brand.id)
      );
      setLocalSelectedProductIds(
        localSelectedProductIds.filter((id) => !brandProductIds.includes(id))
      );
    } else {
      // Select brand & its products
      setLocalSelectedBrandIds([...localSelectedBrandIds, brand.id]);
      setLocalSelectedProductIds([
        ...new Set([...localSelectedProductIds, ...brandProductIds]),
      ]);
    }
  };

  const handleProductCheckboxChange = (brand, product) => {
    let newSelected = [];
    if (localSelectedProductIds.includes(product.id)) {
      newSelected = localSelectedProductIds.filter((id) => id !== product.id);
    } else {
      newSelected = [...localSelectedProductIds, product.id];
    }
    setLocalSelectedProductIds(newSelected);

    // update brand selection
    const brandProductIds = brand.products.map((p) => p.id);
    const selectedInBrand = brandProductIds.filter((id) =>
      newSelected.includes(id)
    );

    if (selectedInBrand.length === brand.products.length) {
      if (!localSelectedBrandIds.includes(brand.id)) {
        setLocalSelectedBrandIds([...localSelectedBrandIds, brand.id]);
      }
    } else if (selectedInBrand.length === 0) {
      setLocalSelectedBrandIds(
        localSelectedBrandIds.filter((id) => id !== brand.id)
      );
    } else {
      // partial: don’t add/remove brand, keep indeterminate
      setLocalSelectedBrandIds(
        localSelectedBrandIds.filter((id) => id !== brand.id)
      );
    }
  };

  const handleSelectAllBrands = (e) => {
    if (e.target.checked) {
      const allBrandIds = brands.map((b) => b.id);
      const allProductIds = brands.flatMap((b) => b.products.map((p) => p.id));
      setLocalSelectedBrandIds(allBrandIds);
      setLocalSelectedProductIds(allProductIds);
      setExpandedBrands(allBrandIds);
    } else {
      setLocalSelectedBrandIds([]);
      setLocalSelectedProductIds([]);
      setExpandedBrands([]);
    }
  };

  const handleApply = () => {
    setSelectedBrandIds(localSelectedBrandIds);
    setSelectedProductIds(localSelectedProductIds);
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

  const filteredBrands = brands.filter((b) =>
    b.name.toLowerCase().includes(brandSearch.toLowerCase())
  );

  return (
    <>
      <div
        className="fixed inset-0 bg-black/50 backdrop-blur-sm z-40"
        onClick={onClose}
      />
      <div className="fixed left-1/2 top-1/2 -translate-x-1/2 -translate-y-1/2 bg-[#252538] border border-[#38384a] rounded-xl p-6 z-50 w-[460px] max-h-[80vh] overflow-hidden">
        <h3 className="text-lg font-medium text-[#BEB7DF] mb-4">
          Select Brands & Products
        </h3>

        {/* Brand Search */}
        <input
          type="text"
          value={brandSearch}
          onChange={(e) => setBrandSearch(e.target.value)}
          placeholder="Search brands..."
          className="w-full mb-3 px-3 py-2 rounded bg-[#2d2d42] text-gray-200 focus:outline-none focus:ring-2 focus:ring-[#8a4fff]"
        />

        {/* Select All Brands */}
        <label className="flex items-center mb-3 p-2 hover:bg-[#38384a] rounded cursor-pointer">
          <input
            ref={selectAllRef}
            type="checkbox"
            checked={
              localSelectedBrandIds.length === brands.length &&
              brands.length > 0
            }
            onChange={handleSelectAllBrands}
            className="mr-3 rounded text-[#8a4fff] focus:ring-[#8a4fff]"
          />
          <span className="text-gray-200">Select All Brands</span>
        </label>

        {/* Brands List */}
        <div className="space-y-3 overflow-y-auto max-h-[45vh] pr-2">
          {filteredBrands.map((brand) => {
            const isExpanded = expandedBrands.includes(brand.id);
            const searchQuery = productSearch[brand.id] || "";

            const filteredProducts = brand.products.filter((p) =>
              p.name.toLowerCase().includes(searchQuery.toLowerCase())
            );

            const brandProductIds = brand.products.map((p) => p.id);
            const selectedInBrand = brandProductIds.filter((id) =>
              localSelectedProductIds.includes(id)
            );

            const brandChecked = localSelectedBrandIds.includes(brand.id);
            const brandIndeterminate =
              selectedInBrand.length > 0 &&
              selectedInBrand.length < brand.products.length;

            return (
              <div
                key={brand.id}
                className="border border-[#38384a] rounded-lg"
              >
                {/* Brand Row */}
                <div className="flex items-center justify-between px-3 py-2 hover:bg-[#38384a] rounded-t-lg">
                  <label className="flex items-center flex-1 cursor-pointer">
                    <input
                      type="checkbox"
                      checked={brandChecked}
                      ref={(el) => {
                        if (el) el.indeterminate = brandIndeterminate;
                      }}
                      onChange={() => handleBrandCheckboxChange(brand)}
                      className="mr-2 rounded text-[#8a4fff] focus:ring-[#8a4fff]"
                    />
                    <span className="text-[#BEB7DF] font-medium">
                      {brand.name}
                    </span>
                  </label>
                  <button
                    onClick={() => toggleBrandExpand(brand.id)}
                    className="text-gray-400 ml-2"
                  >
                    {isExpanded ? "▲" : "▼"}
                  </button>
                </div>

                {/* Expanded Products */}
                {isExpanded && (
                  <div className="p-3 space-y-2 overflow-y-auto max-h-[160px]">
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

                    {filteredProducts.map((product) => (
                      <label
                        key={product.id}
                        className="flex items-center p-1 hover:bg-[#38384a] rounded cursor-pointer"
                      >
                        <input
                          type="checkbox"
                          checked={localSelectedProductIds.includes(product.id)}
                          onChange={() =>
                            handleProductCheckboxChange(brand, product)
                          }
                          className="mr-2 rounded text-[#8a4fff] focus:ring-[#8a4fff]"
                        />
                        <span className="text-gray-200 text-sm">
                          {product.name}
                        </span>
                      </label>
                    ))}
                  </div>
                )}
              </div>
            );
          })}
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
