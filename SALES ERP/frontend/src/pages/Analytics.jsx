import { useState } from "react";
import { CircleDollarSign, PackageOpen } from "lucide-react";
import { ToggleSwitch } from "../components";
import AnalyticsSales from "./AnalyticsSales";
import AnalyticsProducts from "./AnalyticsProducts";

const Analytics = () => {
  const [activeTab, setActiveTab] = useState("sales"); // "sales" | "products"

  return (
    <div className="flex flex-col min-h-[84.6vh]">
      <div className="flex-1">
        {/* Top-Level Toggle (Sales | Products) */}
        <ToggleSwitch
          active={activeTab}
          onToggle={setActiveTab}
          options={[
            {
              id: "sales",
              label: "Sales",
              icon: <CircleDollarSign size={18} />,
            },
            {
              id: "products",
              label: "Products",
              icon: <PackageOpen size={18} />,
            },
          ]}
          position="justify-center"
          customWidth="min-w-[10vw]"
        />

        {/* Render Parent Page */}
        {activeTab === "sales" && <AnalyticsSales />}
        {activeTab === "products" && <AnalyticsProducts />}
      </div>
    </div>
  );
};

export default Analytics;
