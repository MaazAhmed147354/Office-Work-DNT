import { useState } from "react";
import {
  LayoutDashboard,
  BarChart,
  Users,
  FileText,
  ChevronLeft,
  ChevronRight,
} from "lucide-react";
import { Link, useLocation } from "react-router-dom";
import { useSidebar } from "../context/SidebarContext";

const Sidebar = () => {
  const { collapsed, toggleSidebar } = useSidebar();
  const { pathname } = useLocation();

  const navItems = [
    { name: "Dashboard", path: "/", icon: <LayoutDashboard size={20} /> },
    { name: "Sales", path: "/sales", icon: <BarChart size={20} /> },
    { name: "Customers", path: "/customers", icon: <Users size={20} /> },
    { name: "Reports", path: "/reports", icon: <FileText size={20} /> },
  ];

  return (
    <div
      className={`h-screen bg-white/5 backdrop-blur-md border-r border-white/10 text-[#e2e8f0] fixed top-0 left-0 z-40 ${
        collapsed ? "w-16" : "w-64"
      } transition-all`}
    >
      {/* Header */}
      <div className="flex items-center justify-between px-4 py-4 border-b border-gray-200 dark:border-gray-700">
        {!collapsed && (
          <h1 className="text-xl font-bold text-[#f8fafc]">Salesforce</h1>
        )}
        <button
          onClick={toggleSidebar}
          className="text-[#e2e8f0] hover:text-[#60a5fa] hover:bg-white/10 p-1 rounded-full transition"
        >
          {collapsed ? <ChevronRight size={20} /> : <ChevronLeft size={20} />}
        </button>
      </div>

      {/* Nav Links */}
      <nav className="mt-4 space-y-2">
        {navItems.map((item) => (
          <Link
            key={item.name}
            to={item.path}
            className={`flex items-center gap-3 px-4 py-2 rounded-md text-sm font-medium transition-colors ${
              pathname === item.path
                ? "bg-[#60a5fa]/20 text-[#60a5fa]"
                : "hover:bg-white/10"
            }`}
            title={collapsed ? item.name : ""}
          >
            {item.icon}
            {!collapsed && <span>{item.name}</span>}
          </Link>
        ))}
      </nav>
    </div>
  );
};

export default Sidebar;
