import { useState } from "react";
import { useSidebar } from "../../context/SidebarContext";
import { NavLink, useLocation, useNavigate } from "react-router-dom";
import { LogOut, ChevronLeft, ChevronRight } from "lucide-react";
import {
  LayoutDashboard,
  ChartNoAxesCombined,
  ClipboardList,
  Users,
  Component,
  Settings,
} from "../../custom-icons";
import LogoutModal from "../Modals/LogoutModal";
import authService from "../../services/authService";

const Sidebar = () => {
  const { isCollapsed, toggleSidebar } = useSidebar();
  const [showLogoutModal, setShowLogoutModal] = useState(false);
  const role = localStorage.getItem("roleText");
  const location = useLocation();
  const navigate = useNavigate();

  const isActive = (path) => location.pathname === path;

  const navItems = [
    {
      name: "Dashboard",
      icon: LayoutDashboard,
      path: "/dashboard",
      roles: ["Admin", "Seller"],
    },
    {
      name: "Analytics",
      icon: ChartNoAxesCombined,
      path: "/analytics",
      roles: ["Admin", "Seller"],
    },
    {
      name: "Products",
      icon: Component,
      path: "/products",
      roles: ["Admin", "Seller", "BasicUser"],
    },
    {
      name: "Warranty",
      icon: ClipboardList,
      path: "/warranty",
      roles: ["Admin", "Seller", "BasicUser"],
    },
    {
      name: "Employees",
      icon: Users,
      path: "/employees",
      roles: ["Admin", "Seller"],
    },
    { name: "Settings", icon: Settings, path: "/settings", roles: ["Admin"] },
  ];

  const handleLogout = () => {
    authService.logoutUser();
    navigate("/login");
  };

  return (
    <aside
      className={`fixed top-0 left-0 h-screen ${
        isCollapsed ? "w-20" : "w-64"
      } bg-[#252538] text-white flex flex-col justify-between shadow-lg border-r border-[#38384a] transition-all duration-300 z-20`}
    >
      {/* Top Logo */}
      <div className="flex items-center justify-center py-5 relative">
        {isCollapsed ? (
          <div>
            <h1 className="text-2xl font-bold tracking-wide text-[#8a4fff]">
              D
            </h1>
            <h1 className="text-2xl font-bold tracking-wide text-[#8a4fff]">
              N
            </h1>
            <h1 className="text-2xl font-bold tracking-wide text-[#8a4fff]">
              T
            </h1>
          </div>
        ) : (
          <h1 className="text-2xl font-bold tracking-wide text-[#8a4fff]">
            Dreams Network
          </h1>
        )}

        {/* Collapse Button */}
        <button
          onClick={toggleSidebar}
          className="absolute -right-3 top-1/2 transform -translate-y-1/2 bg-[#252538] rounded-full p-1 border border-[#38384a] hover:bg-violet-600/70 transition-colors"
        >
          {isCollapsed ? (
            <ChevronRight className="w-4 h-4 text-purple-300" />
          ) : (
            <ChevronLeft className="w-4 h-4 text-purple-300" />
          )}
        </button>
      </div>

      {/* Nav Links */}
      <nav className="flex-1 mt-0 px-0 space-y-5 flex flex-col justify-center">
        {navItems
          .filter((item) => item.roles.includes(role))
          .map(({ name, icon: Icon, path }) => (
            <NavLink
              key={name}
              to={path}
              className={`flex items-center gap-3 ${
                isCollapsed ? "justify-center px-0 mx-0" : "px-4 mx-4"
              } py-3 rounded-md text-sm font-medium transition-all duration-200 ${
                isActive(path)
                  ? "bg-[#38384a] border-l-4 border-[#8a4fff] text-white"
                  : "hover:bg-[#38384a] text-gray-300"
              }`}
              title={isCollapsed ? name : ""}
            >
              <Icon size={20} />
              {!isCollapsed && <span className="text-purple-300">{name}</span>}
            </NavLink>
          ))}
      </nav>

      {/* Logout Button */}
      <div className={`p-5 ${isCollapsed ? "flex justify-center" : ""}`}>
        <button
          // onClick={handleLogout}
          onClick={() => setShowLogoutModal(true)}
          className={`flex items-center gap-3 text-gray-400 hover:text-[#8a4fff] transition-colors ${
            isCollapsed ? "justify-center" : "w-full"
          }`}
          title={isCollapsed ? "Logout" : ""}
        >
          <LogOut size={20} />
          {!isCollapsed && <span>Logout</span>}
        </button>
      </div>
      {/* Logout Confirmation Modal */}
      <LogoutModal
        isOpen={showLogoutModal}
        onClose={() => setShowLogoutModal(false)}
        onConfirm={handleLogout}
      />
    </aside>
  );
};

export default Sidebar;
