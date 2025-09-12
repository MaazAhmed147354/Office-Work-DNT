import { useState, useEffect } from "react";
import { useToast } from "../context/ToastContext";
import {
  ProductSalesChartCard,
  MonthlySalesChartCard,
  TopProductsTableCard,
  StatCard,
  SalesTargetCard,
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
              title: "Your Sales",
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
            {
              title: "Your Rank",
              value: "Ali Naqvi #3",
              subtitle: "Orders Completed: 58",
              icon: "trophy",
              classname: "bg-cyan-700",
            },
          ]);
        }

        showToast("Dashboard data fetched", "success");
      } catch (err) {
        console.error("Error loading dashboard data:", err);
        setStatCardData([{}, {}, {}, {}]);
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
        <div className="grid grid-cols-5 mb-6 gap-6">
          <div className="grid grid-cols-1 col-span-1">
            <SalesTargetCard target={100000000} achieved={50000000} />
          </div>
          <div className="grid grid-cols-1 md:grid-cols-2 col-span-4 gap-6">
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
        </div>

        {/* Graphs Section */}
        <div className="grid grid-cols-2 md:grid-cols-2 gap-6 mb-6">
          <div className="grid col-span-2 md:grid-cols-2 gap-6">
            <ProductSalesChartCard data={salesByProduct.slice(0, 10)} />
            <MonthlySalesChartCard data={salesByMonth} />
            {/* <ProgressChartCard /> */}
          </div>
          {/* <div className="grid col-span-2 md:grid-cols-2 gap-6"> */}
          {/* <PolarAreaChartCard /> */}
          {/* <SalesPersonChartCard data={salesBySalesperson} /> */}
          {/* <RadarChartCard /> */}
          {/* </div> */}
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
