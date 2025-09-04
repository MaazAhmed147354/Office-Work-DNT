import { useState, useEffect } from "react";
import { DateTabCard, SalesAnalyticsChartCard, Accordion } from "../components"; // you’ll create these
import { staticData } from "../data/analyticsData";

const getChartData = (salespeople) =>
  salespeople.map((person) => ({
    label: person.salesperson,
    legend: {color: "red"},
    totalSales: person.sales.reduce((sum, s) => sum + s.totalSales, 0),
  }));

const Analytics = () => {
  const [selectedTab, setSelectedTab] = useState("year"); // year | month | week | quarter
  const [selectedValue, setSelectedValue] = useState(null); // e.g. 2025, "Feb", week#, etc.
  const [chartData, setChartData] = useState([]);

  useEffect(() => {
  if (selectedTab && selectedValue) {
    // Fetch or prepare chart data based on both
    setChartData(staticData);
  }
}, [selectedTab, selectedValue]);

  return (
    <div className="flex flex-col min-h-full">
      <div className="flex-1">
        {/* Date Tabs */}
        <div className="mb-6">
          <DateTabCard
            selectedTab={selectedTab}
            setSelectedTab={setSelectedTab}
            selectedValue={selectedValue}
            setSelectedValue={setSelectedValue}
          />
        </div>

        {/* Chart Section */}
        <div className="grid grid-cols-1 gap-6 mb-6">
          <SalesAnalyticsChartCard
            tab={selectedTab}
            value={selectedValue}
            data={getChartData(chartData)} // temporary static data
          />
        </div>

        {/* Accordions (one per salesperson) */}
        <div className="grid grid-cols-1 gap-6">
          <Accordion
            data={staticData} // temporary static data
          />
        </div>
      </div>
    </div>
  );
};

export default Analytics;
