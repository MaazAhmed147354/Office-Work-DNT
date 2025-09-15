import { useState, useEffect } from "react";
import { useToast } from "../context/ToastContext";
import {
  SalesPersonChartCard,
  ProductSalesChartCard,
  MonthlySalesChartCard,
  TopProductsTableCard,
  StatCard,
  LeaderboardCard,
  SpinnerLoader,
} from "../components";
import dashboardService from "../services/dashboardService";

const Dashboard = () => {
  const [salesBySalesperson, setSalesBySalesperson] = useState([]);
  const [salesByProduct, setSalesByProduct] = useState([]);
  const [salesByMonth, setSalesByMonth] = useState([]);
  const [statCardData, setStatCardData] = useState([]);
  const [loading, setLoading] = useState(true); // ✅ Global Loader state

  const { showToast } = useToast();

  useEffect(() => {
    const fetchData = async () => {
      try {
        const [salespersonData, productData, monthlySalesData] =
          await Promise.all([
            dashboardService.getSalesBySalesperson(),
            dashboardService.getSalesByProduct(),
            dashboardService.getMonthlySales(),
          ]);
        setSalesBySalesperson(salespersonData || []);
        setSalesByProduct(productData || []);
        setSalesByMonth(monthlySalesData || []);

        if (
          productData.length > 0 &&
          salespersonData.length > 0 &&
          monthlySalesData.length > 0
        ) {
          const topProduct = productData[0];
          const topSeller = salespersonData[0];
          const totalSales = salespersonData.reduce(
            (sum, sp) => sum + sp.totalSales,
            0
          );

          setStatCardData([
            {
              title: "Total Sales",
              value: totalSales.toLocaleString() + " PKR",
              subtitle: "All Salespersons",
              icon: "dollar",
              classname: "bg-violet-700",
            },
            {
              title: "Star Product",
              value: topProduct.totalSales.toLocaleString() + " PKR",
              subtitle: topProduct.productName,
              icon: "star",
              classname: "bg-purple-500",
            },
            {
              title: "Top Seller",
              value: topSeller.totalSales.toLocaleString() + " PKR",
              subtitle: topSeller.salesPersonName,
              icon: "certificate",
              classname: "bg-sky-600",
            },
          ]);
        }
        showToast("Dashboard data fetched", "success");
      } catch (err) {
        console.error("Error loading dashboard data:", err);
        setStatCardData([{}, {}, {}]);
        showToast("Failure fetching Dashboard Data!", "error");
      } finally {
        setLoading(false); // ✅ Hide loader when all requests complete
      }
    };
    fetchData();
  }, []);

  return loading == true ? (
    <SpinnerLoader label="Loading dashboard..." />
  ) : (
    <div className="flex flex-col md:flex-row min-h-full">
      {/* Main Content Area - Scrollable */}
      <div className="flex-1">
        {/* Top Stats Row */}
        <div className="grid grid-cols-1 md:grid-cols-3 gap-6 mb-6">
          {statCardData.map((sc, index) => (
            <StatCard
              key={index}
              title={sc.title}
              value={sc.value}
              subtitle={sc.subtitle}
              icon={sc.icon}
              classname={sc.classname}
              period="This Month"
            />
          ))}
        </div>

        {/* Graphs Section */}
        <div className="grid grid-cols-2 md:grid-cols-2 gap-6 mb-6">
          <div className="grid col-span-2 md:grid-cols-2 gap-6">
            <LeaderboardCard data={salesBySalesperson.slice(0, 3)} />
            <MonthlySalesChartCard data={salesByMonth} />
          </div>
          <div className="grid col-span-2 md:grid-cols-2 gap-6">
            <ProductSalesChartCard data={salesByProduct} />
            <SalesPersonChartCard data={salesBySalesperson} />
          </div>
        </div>

        {/* Table Section */}
        <div className="grid grid-cols-1 gap-6">
          <TopProductsTableCard data={salesByProduct} />
        </div>
      </div>
    </div>
  );
};

export default Dashboard;
