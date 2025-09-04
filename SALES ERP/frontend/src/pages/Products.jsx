import React, { useEffect, useState } from "react";
import productService from "../services/productService";
import { ProductsTable, SpinnerLoader } from "../components";

const ProductsPage = () => {
  const [products, setProducts] = useState([]);
  const [loading, setLoading] = useState(true); // ✅ Global Loader state

  useEffect(() => {
    const fetchData = async () => {
      try {
        const result = await productService.getProductsList();
        if (result) setProducts(result);
      } catch (error) {
        console.error("Failed to fetch products", error);
      } finally {
        setLoading(false); // ✅ Hide loader when all requests complete
      }
    };

    fetchData();
  }, []);

  const columns = [
    { header: "Branch", field: "branchName", style: "text-left" },
    { header: "Product", field: "productName", style: "text-left" },
    { header: "Stock", field: "productQuantity", style: "text-center" },
    { header: "Price", field: "productPrice", style: "text-center" },
  ];

  return loading == true ? (
    <SpinnerLoader label="Loading products..." />
  ) : (
    <div className="flex flex-col md:flex-row min-h-full">
      <div className="flex-1 overflow-y-auto">
        <div className="grid grid-cols-1 gap-6 max-w-7xl mx-auto">
          <ProductsTable
            title="Products List"
            data={products}
            columns={columns}
          />
        </div>
      </div>
    </div>
  );
};

export default ProductsPage;
