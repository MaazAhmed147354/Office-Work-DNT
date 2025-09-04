import {
  Dehaze,
  Dashboard,
  TableChart,
  ReceiptLong,
  Notifications,
  AccountCircle,
  Login,
  AppRegistration,
  Language,
} from "@mui/icons-material";
import { useState } from "react";

const navItems = [
  { label: "Dashboard", icon: <Dashboard />, active: true },
  { label: "Tables", icon: <TableChart /> },
  { label: "Billing", icon: <ReceiptLong /> },
  { label: "RTL", icon: <Language /> },
  { label: "Notifications", icon: <Notifications /> },
  { label: "Profile", icon: <AccountCircle /> },
  { label: "Sign In", icon: <Login /> },
  { label: "Sign Up", icon: <AppRegistration /> },
];

export default function Sidebar() {
  const [collapsed, setCollapsed] = useState(false);

  return (
    <div
      className={`h-[97vh] ${
        collapsed ? "w-20" : "w-50"
      } bg-gray-900 text-white fixed z-100 w-fit flex flex-col justify-between rounded-xl m-2 p-4 shadow-lg transition-all duration-300`}
    >
      {/* Top Section */}
      <div>
        <div
          className="border-b-2 border-gray-500 pb-8 text-md font-bold mb-8 flex items-center justify-center gap-4 cursor-pointer tracking-widest"
          onClick={() => setCollapsed(!collapsed)}
        >
          <span className="text-white">
            <Dehaze />
          </span>
          {!collapsed && <span>Sidebar</span>}
        </div>

        <ul className="space-y-2">
          {navItems.map(({ label, icon, active }) => (
            <li
              key={label}
              className={`flex items-center gap-3 px-4 py-2 text-[12px] rounded-lg cursor-pointer transition-colors ${
                active
                  ? "bg-blue-500 text-white"
                  : "hover:bg-gray-800 text-gray-300"
              }`}
            >
              <span>{icon}</span>
              {!collapsed && <span>{label}</span>}
            </li>
          ))}
        </ul>
      </div>

      {/* Bottom Section */}
      <div className="px-0">
        {!collapsed && (
          <button className="w-full bg-blue-600 hover:bg-blue-700 text-white py-2 rounded-lg text-sm font-semibold">
            UPGRADE TO PRO
          </button>
        )}
      </div>
    </div>
  );
}
