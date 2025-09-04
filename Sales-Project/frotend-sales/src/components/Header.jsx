import { useLocation } from "react-router-dom";
import { Bell, Settings, User } from "lucide-react";

const Header = () => {
  const location = useLocation();

  // Extract route name from path
  const routeTitle =
    location.pathname === "/"
      ? "Dashboard"
      : location.pathname.slice(1).charAt(0).toUpperCase() +
        location.pathname.slice(2);

  return (
    <header className="w-full px-4 py-4 flex items-center justify-between backdrop-blur-md bg-white/5 sticky top-0 z-30 text-[#f8fafc] rounded-bl-xl">
      {/* Left: Title + Path */}
      <div>
        <h2 className="text-lg font-semibold dark:text-gray-100">
          {routeTitle}
        </h2>
        <p className="text-sm dark:text-gray-100">{location.pathname}</p>
      </div>

      {/* Right: Search + Icons */}
      <div className="flex items-center gap-4">
        {/* Search Input */}
        <input
          type="text"
          placeholder="Search..."
          className="px-3 py-1.5 text-sm rounded-md bg-white/10 text-[#f8fafc] border border-white/10 focus:ring-2 focus:ring-[#60a5fa]"
        />

        {/* Icons */}
        <button className="text-[#e2e8f0] hover:text-[#60a5fa]">
          <Settings size={20} />
        </button>
        <button className="text-[#e2e8f0] hover:text-[#60a5fa]">
          <Bell size={20} />
        </button>
        <button className="text-[#e2e8f0] hover:text-[#60a5fa]">
          <User size={20} />
        </button>
      </div>
    </header>
  );
};

export default Header;
