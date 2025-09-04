import { useState } from "react";
import { DollarSign, User, Award, BarChart2 } from "lucide-react";
import { StatCard } from "../dcomponents/StatCard";
import { DataTable } from "../dcomponents/DataTable";
import { RevenueTrendChart } from "../dcomponents/RevenueTrendChart";
import { SalesDistributionChart } from "../dcomponents/SalesDistributionChart";
import { MonthlyComparisonChart } from "../dcomponents/MonthlyComparisonChart";
import { BatteryTarget } from "../dcomponents/BatteryTarget";

const Settings = () => {
  // Sample data - replace with your actual data fetching logic
  const [timeframe, setTimeframe] = useState("Yearly");
  const [year, setYear] = useState("2019");

  const targetData = {
    percentage: 82,
    target: 150000,
    current: 123000,
  };

  const statCardsData = [
    {
      title: "Total Revenue",
      value: "$125,430",
      change: 15,
      icon: DollarSign,
      trend: "up",
      curtainColor: "bg-purple-500",
    },
    {
      title: "Top Seller",
      value: "June Smith",
      subtitle: "$28,800 revenue",
      unit: "this month",
      icon: User,
      curtainColor: "bg-sky-600",
    },
    {
      title: "Star Product",
      value: "Product A",
      subtitle: "$75,000 revenue",
      unit: "this week",
      icon: Award,
      curtainColor: "bg-violet-700",
    },
  ];

  const topSalesData = [
    { id: 1, seller: "John Dee", sales: 250, revenue: "$2,500" },
    { id: 2, seller: "June Smith", sales: 258, revenue: "$28,800" },
    { id: 3, seller: "Emily Johnson", sales: 235, revenue: "$28,750" },
  ];

  const topProductsData = [
    { id: 1, product: "Product A", unitsSold: 8500, revenue: "$75,000" },
    { id: 2, product: "Product B", unitsSold: 430, revenue: "$46,380" },
    { id: 3, product: "Product C", unitsSold: 320, revenue: "$30,400" },
  ];

  return (
    <div className="flex flex-col md:flex-row min-h-full">
      <div className="flex-1 overflow-y-auto">
        {/* Timeframe Selector */}
        <div className="mb-6">
          {/* Your timeframe selector implementation */}
        </div>

        {/* Upper Section - Battery + Stats + Bar Chart */}
        <div className="grid grid-cols-1 md:grid-cols-4 gap-6 mb-6">
          {/* Battery Target - Left Column */}
          <div className="md:col-span-1 row-span-2">
            <BatteryTarget percentage={45} />
          </div>

          {/* Stat Cards - Top Right */}
          <div className="md:col-span-3 grid grid-cols-1 md:grid-cols-3 gap-6">
            {statCardsData.map((card, index) => (
              <StatCard key={index} {...card} />
            ))}
          </div>

          {/* Bar Chart - Bottom Right */}
          <div className="md:col-span-3">
            <MonthlyComparisonChart />
          </div>
        </div>

        {/* Middle Section - Other Charts */}
        <div className="grid grid-cols-1 lg:grid-cols-2 gap-6 mb-6">
          <RevenueTrendChart />
          <SalesDistributionChart />
        </div>

        {/* Bottom Section - Tables */}
        <div className="grid grid-cols-1 lg:grid-cols-2 gap-6">
          <DataTable
            title="Top Salesmen"
            columns={[
              { field: "seller", header: "Seller", style: "text-left" },
              { field: "sales", header: "Sales", style: "text-center" },
              { field: "revenue", header: "Revenue", style: "text-center" },
            ]}
            data={topSalesData}
            keyField="id"
          />

          <DataTable
            title="Top Products by Revenue"
            columns={[
              { field: "product", header: "Product", style: "text-left" },
              {
                field: "unitsSold",
                header: "Units Sold",
                style: "text-center",
              },
              {
                field: "revenue",
                header: "Revenue",
                style: "text-center font-bold",
              },
            ]}
            data={topProductsData}
            keyField="id"
          />
        </div>
      </div>
    </div>
  );
};

export default Settings;
