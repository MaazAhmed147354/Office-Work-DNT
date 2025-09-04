import { Navigate, Outlet } from "react-router-dom";
import authService from "../../services/authService";
import { useEffect, useState } from "react";

const PrivateRoute = ({ routePath }) => {
  const [authStatus, setAuthStatus] = useState("checking");

  useEffect(() => {
    const checkAuth = async () => {
      const result = await authService.validateAccess(routePath);
      setAuthStatus(result ? "authorized" : "unauthorized");
    };
    checkAuth();
  }, [routePath]);

  if (authStatus === "checking") {
    return <div>Checking access...</div>;
  }

  if (authStatus === "unauthorized") {
    return <Navigate to="/unauthorized" />;
  }

  return <Outlet />;
};

export default PrivateRoute;
