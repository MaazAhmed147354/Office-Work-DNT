import {
  Home,
  Notifications,
  Settings,
  Search,
  AccountCircle,
} from "@mui/icons-material";
import { useEffect, useState } from "react";

export default function Navbar() {
  const [scrolled, setScrolled] = useState(false);

  useEffect(() => {
    const handleScroll = () => {
      setScrolled(window.scrollY>0);
    }
    window.addEventListener('scroll', handleScroll);
    return () => {
      window.removeEventListener('scroll', handleScroll);
    }
  }, [])
  return (
    <div className="flex items-center justify-between px-5 py-4 bg-transparent ml-48 w-[84vw]">
      {/* Left side: Breadcrumb and Page Title */}
      <div>
        <div className="flex justify-center align-middle text-sm font-semibold text-gray-400">
          <Home />/ Dashboard
        </div>
        <h1 className="text-md font-semibold text-gray-700">Dashboard</h1>
      </div>

      {/* Right side: Search + Icons */}
      <div className="flex items-center space-x-4">
        {/* Search input */}
        <div className="relative">
          <input
            type="text"
            placeholder="Search here"
            className="pl-10 pr-4 py-2 rounded-md bg-transparent hover:bg-gray-200 shadow text-sm text-gray-600 focus:outline-none focus:ring-2 focus:ring-gray-400"
          />
          <Search className="absolute left-2 top-1/2 transform -translate-y-1/2 text-gray-400 text-sm" />
        </div>

        {/* Icons */}
        <AccountCircle className="text-gray-600 cursor-pointer hover:text-gray-800" />
        <Settings className="text-gray-600 cursor-pointer hover:text-gray-800" />
        <Notifications className="text-gray-600 cursor-pointer hover:text-gray-800" />
      </div>
    </div>
  );
}
