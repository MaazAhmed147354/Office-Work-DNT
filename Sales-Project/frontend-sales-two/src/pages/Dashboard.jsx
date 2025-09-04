import ProfileCard from "./../components/ProfileCard";
import MeterCard from "./../components/MeterCard";
import MetricCard from "./../components/MetricCard";
import Table from "./../components/Table";
import {
  salesRepData,
  companyData,
  meterData,
  metricData,
  profilesData,
} from "../data/dataImport";

const Dashboard = () => {
  return (
    <div>
      {/* Main Content */}
      <div className="mt-0 space-y-3">
        {/* Upper Section: 5 Cards */}
        <div className="sm:grid-cols-4 md:grid-cols-4 lg:grid-cols-6 grid grid-cols-1 gap-3">
          {/* Leftmost Card (Profile Card) */}
          <div className="sm:col-span-4 md:col-span-4 lg:col-span-2">
            <ProfileCard
              title={profilesData.title}
              period={profilesData.period}
              profiles={profilesData.profiles}
            />
          </div>

          {/* Two Meter Cards */}
          <div className="sm:col-span-2 md:col-span-2 lg:col-span-2 grid grid-cols-2 gap-3">
            {meterData.map((meter) => (
              <MeterCard
                key={meter.id}
                title={meter.title}
                period={meter.period}
                value={meter.value}
                max={meter.max}
                unit={meter.unit}
                gaugeColor={meter.gaugeColor}
              />
            ))}
          </div>

          {/* Two Metric Cards */}
          <div className="sm:col-span-2 md:col-span-2 lg:col-span-2 grid grid-cols-2 gap-3">
            {metricData.map((metric) => (
              <MetricCard
                key={metric.id}
                title={metric.title}
                value={metric.value}
                unit={metric.unit}
                isCurrency={metric.isCurrency}
                period={metric.period}
                textColor={metric.textColor}
                bgColor={metric.bgColor}
              />
            ))}
          </div>
        </div>

        {/* Lower Section: Tables */}
        <div className="grid grid-cols-1 lg:grid-cols-2 gap-3 mt-0 overflow-y-auto">
          {/* First Table Card */}
          <div className="p-4 rounded-xl backdrop-blur-md bg-[#1a1a2e]/70 border border-[#4A4B5A]/50 hover:bg-[#16213e]/80 min-h-fit">
            <h3 className="sm:text-sm lg:text-lg font-bold text-[#BEB7DF] mb-2">
              Opportunities by Sales Rep
            </h3>
            <Table
              data={salesRepData}
              columns={[
                { header: "Employee", field: "employee", style: "text-left" },
                {
                  header: "Opps Created",
                  field: "oppsCreated",
                  style: "text-right",
                },
                {
                  header: "Opps Accepted",
                  field: "oppsAccepted",
                  style: "text-right",
                },
                {
                  header: "Acceptance Rate",
                  field: "acceptanceRate",
                  style: "text-right",
                },
                { header: "Won Opp", field: "wonOpps", style: "text-right" },
              ]}
            />
          </div>

          {/* Second Table Card */}
          <div className="p-4 rounded-xl backdrop-blur-md bg-[#1a1a2e]/70 border border-[#4A4B5A]/50 hover:bg-[#16213e]/80 min-h-fit">
            <h3 className="sm:text-sm lg:text-lg font-bold text-[#BEB7DF] mb-[10px]">
              Opportunities by Company
            </h3>
            <Table
              data={companyData}
              columns={[
                { header: "Name", field: "name", style: "text-left" },
                { header: "Amount", field: "amount", style: "text-left" },
                { header: "Stage", field: "stage", style: "text-left" },
              ]}
            />
          </div>
        </div>
      </div>
    </div>
  );
};

export default Dashboard;
