import BookIcon from "@mui/icons-material/Book";
import PersonAddIcon from "@mui/icons-material/PersonAdd";
import BarChartIcon from "@mui/icons-material/BarChart";
import StoreIcon from "@mui/icons-material/Store";

import Navbar from "../components/navbar";
import Sidebar from "../components/sidebar";
import StatCard from "../components/StatCard";
import ChartCard from "../components/ChartCard";
// import { statCardData, chartCardData } from "../data/dashboardData";
import { useEffect, useState } from "react";
import DashboardService from "../services/DashboardService";
import ProjectCard from "../components/ProjectCard";

const Dashboard = () => {
  const icons = [BookIcon, BarChartIcon, StoreIcon, PersonAddIcon];
  const chartBgColors = ["bg-blue-500", "bg-green-500", "bg-gray-800"];
  const [isloading, setIsLoading] = useState(true);
  const [statCards, setStatCards] = useState([]);
  const [chartCards, setChartCards] = useState([]);
  const [projects, setProjects] = useState([]);

  const fetchDashboardData = async () => {
    try {
      setIsLoading(true);
      const statRes = await DashboardService.getStatsData();
      setStatCards(statRes.data.data);
      const chartRes = await DashboardService.getChartsData();
      setChartCards(chartRes.data.data);
      const projectRes = await DashboardService.getProjectsData();
      setProjects(projectRes.data.data);
    } catch (error) {
      console.log("Error in fetching Dashboard Data!!");
    } finally {
      setIsLoading(false);
    }
  };

  useEffect(() => {
    fetchDashboardData();
  }, []);

  return (
    <div className="flex min-h-screen bg-gray-100">
      {/* Sidebar */}
      <Sidebar />

      <div className="flex-1">
        {/* Navbar */}
        <Navbar />

        <main className="px-6 py-2 ml-45">
          {/* Top Stat Cards */}
          {!isloading && statCards && (
            <section className="grid grid-cols-1 md:grid-cols-4 gap-6">
              {statCards.map(
                ({ label, value, percentage, comparison, icolor }, index) => {
                  const Icon = icons[index];
                  return (
                    <StatCard
                      key={index}
                      label={label}
                      value={value}
                      percentage={percentage}
                      comparison={comparison}
                      icolor={icolor}
                      icon={Icon ? <Icon /> : null}
                    />
                  );
                }
              )}
            </section>
          )}

          {/* Charts */}
          {!isloading && chartCards && (
            <section className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6 mt-10">
              {chartCards.map((chart, index) => (
                <ChartCard
                  key={index}
                  title={chart.title}
                  statement={chart.statement}
                  update={chart.update}
                  type={chart.type}
                  chartBgColor={chartBgColors[index]}
                  data={{
                    labels: chart.labels,
                    datasets: [
                      {
                        label: chart.title,
                        data: chart.data,
                        borderColor: "white",
                        backgroundColor: "white",
                        barThickness: 5,
                        borderRadius: 5,
                        tension: 0, // Smooth curve
                      },
                    ],
                  }}
                  options={chart.options}
                />
              ))}
            </section>
          )}

          {/* Projects and Orders Overview */}
          <section className="grid grid-cols-1 lg:grid-cols-2 gap-6 mt-6">
            {!isloading && projects && (
              <div className="bg-white rounded shadow-md w-[55vw] z-50">
                <ProjectCard projects={projects} />
              </div>
            )}
            <div className="bg-white p-6 rounded shadow-md">
              <h3 className="font-semibold text-lg">Orders Overview</h3>
              {/* Orders overview component */}
            </div>
          </section>
        </main>
      </div>
    </div>
  );
};

export default Dashboard;
