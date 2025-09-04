import React from "react";

const WarrantyCard = ({ data }) => {
  return (
    <div className="bg-[#252538] p-8 rounded-2xl shadow-lg border border-gray-700 hover:border-[#8a4fff]/50 w-full max-w-2xl mx-auto">
      {/* Product Title */}
      <h2 className="text-2xl font-bold text-purple-400 mb-6 text-center">
        {data.product}
      </h2>

      {/* Grid Info */}
      <div className="grid grid-cols-2 gap-6 text-gray-300">
        <p>
          <span className="font-semibold text-white">Customer:</span>{" "}
          {data.customerName}
        </p>
        <p>
          <span className="font-semibold text-white">Company:</span>{" "}
          {data.company}
        </p>
        <p>
          <span className="font-semibold text-white">Warranty Start:</span>{" "}
          {data.warrantyStartDate}
        </p>
        <p>
          <span className="font-semibold text-white">Warranty End:</span>{" "}
          {data.warrantyEndDate}
        </p>
        <p>
          <span className="font-semibold text-white">Duration:</span>{" "}
          {data.warrantyDuration}
        </p>
        <p>
          <span className="font-semibold text-white">Remaining Days:</span>{" "}
          {data.remainingDays}
        </p>
        <p>
          <span className="font-semibold text-white">Invoice:</span>{" "}
          {data.invoice}
        </p>
        <p>
          <span className="font-semibold text-white">Price:</span> ₨
          {data.price.toLocaleString()}
        </p>
      </div>
    </div>
  );
};

export default WarrantyCard;
