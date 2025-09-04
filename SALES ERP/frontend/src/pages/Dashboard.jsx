import { useEffect, useState } from "react";
import DashboardAdmin from "./DashboardAdmin";
import DashboardSeller from "./DashboardSeller";

const Dashboard = () => {
  const [role, setRole] = useState(null);

  useEffect(() => {
    const roleText = localStorage.getItem("roleText");
    setRole(roleText);
  }, []);

  return role == "Admin" ? <DashboardAdmin /> : <DashboardSeller />;
};

export default Dashboard;
