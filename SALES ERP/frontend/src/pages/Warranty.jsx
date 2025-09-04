import React, { useState } from "react";
import ProductWarrantyService from "../services/productWarrantyService";
import { WarrantyCard } from "../components";

const Warranty = () => {
  const [macAddress, setMacAddress] = useState("");
  const [warrantyData, setWarrantyData] = useState(null);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState("");

  const handleSearch = async () => {
    if (!macAddress.trim()) {
      setError("Please enter a MAC address.");
      return;
    }
    setError("");
    setLoading(true);
    try {
      const data = await ProductWarrantyService.getProductWarranty(macAddress);
      setWarrantyData(data);
    } catch (err) {
      setError("Failed to fetch warranty details.");
      setWarrantyData(null);
    } finally {
      setLoading(false);
    }
  };

  return (
    <div className="flex flex-col items-center justify-center min-h-[80vh] text-white">
      {/* Title */}
      <h1 className="text-3xl font-bold mb-8 text-purple-400">
        Product Warranty Lookup
      </h1>

      {/* Input Section */}
      <div className="flex gap-4 mb-8">
        <input
          type="text"
          placeholder="Enter MAC Address"
          value={macAddress}
          onChange={(e) => setMacAddress(e.target.value)}
          className="p-3 rounded-lg bg-[#1e1e2d] border border-gray-600 focus:border-purple-500 focus:outline-none w-80"
        />
        <button
          onClick={handleSearch}
          disabled={loading}
          className="px-6 py-3 bg-purple-600 hover:bg-purple-700 rounded-lg transition-colors disabled:opacity-50"
        >
          {loading ? "Searching..." : "Search"}
        </button>
      </div>

      {/* Error */}
      {error && <p className="text-red-400 mb-6">{error}</p>}

      {/* Warranty Card */}
      {warrantyData && <WarrantyCard data={warrantyData} />}
    </div>
  );
};

export default Warranty;
