// import GlobalPaginationTable from "./GlobalPaginationTable";
import GlobalMarqueeTable from "./GlobalMarqueeTable";

const TopProductsTableCard = ({ data }) => {
  // if (!data || data.length === 0) {
  //   return (
  //     <div className="bg-[#252538] rounded-xl p-6 border border-[#38384a] text-gray-400 text-sm">
  //       No top products data available
  //     </div>
  //   );
  // }

  // ✅ add rank dynamically
  const rankedData = data.map((item, index) => ({
    rank: index + 1,
    productName: item.productName,
    totalQuantity: item.totalQuantity,
    totalOrders: item.totalOrders,
    totalSales: item.totalSales.toLocaleString(),
  }));

  const columns = [
    { header: "Rank 🏆", field: "rank", style: "text-center" },
    { header: "Product 📦", field: "productName", style: "text-left" },
    { header: "Quantity", field: "totalQuantity", style: "text-center" },
    { header: "Orders", field: "totalOrders", style: "text-center" },
    {
      header: "Revenue 💰",
      field: "totalSales",
      style: "text-center text-green-500",
    },
  ];

  return (
    // <GlobalPaginationTable
    //   title="Top Products"
    //   data={rankedData}
    //   columns={columns}
    //   rowsPerPage={10}
    // />
    <GlobalMarqueeTable
      title="Top Products"
      data={rankedData}
      columns={columns}
      speed={30} // smaller = faster scrolling
    />
  );
};

export default TopProductsTableCard;
