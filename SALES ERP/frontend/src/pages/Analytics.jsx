import { useState } from "react";
import { AnalyticsTabs } from "../components";
import AnalyticsSales from "./AnalyticsSales";
import AnalyticsProducts from "./AnalyticsProducts";
import AnalyticsSalesperson from "./AnalyticsSalesperson";

const Analytics = () => {
  const [activeTab, setActiveTab] = useState("sales"); // default tab

  return (
    <div className="flex flex-col min-h-full">
      <div className="flex-1">
        {/* Tabs only control state */}
        <AnalyticsTabs activeTab={activeTab} onTabChange={setActiveTab} />

        {/* Analytics decides what to render */}
        {activeTab === "sales" && <AnalyticsSales />}
        {activeTab === "salespersons" && <AnalyticsSalesperson />}
        {activeTab === "products" && <AnalyticsProducts />}
      </div>
    </div>
  );
};

export default Analytics;
