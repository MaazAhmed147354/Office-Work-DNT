import React, { useState, useEffect } from "react";
import {
  Wifi,
  Battery,
  BatteryFull,
  BatteryMedium,
  BatteryLow,
} from "lucide-react";
import { motion } from "framer-motion"; // For animations
import { NavLink } from "react-router-dom";

const Header = ({ title = "PLECTO" }) => {
  const [currentTime, setCurrentTime] = useState(new Date());
  const [batteryLevel, setBatteryLevel] = useState(82);
  const [isCharging, setIsCharging] = useState(false);
  const [timeKey, setTimeKey] = useState(0); // Force re-render for animation

  // Navigation items configuration
  const navItems = [
    { name: "Dashboard", path: "/" },
    { name: "Analytics", path: "/analytics" },
    { name: "Settings", path: "/settings" },
  ];

  // Time updater with animation trigger
  useEffect(() => {
    const updateTime = () => {
      const now = new Date();
      setCurrentTime(now);
      setTimeKey((prev) => prev + 1); // Change key to trigger animation
    };

    // Calculate ms until next minute
    const now = new Date();
    const delay = (60 - now.getSeconds()) * 1000;

    const timeoutId = setTimeout(() => {
      updateTime();
      const intervalId = setInterval(updateTime, 60000);
      return () => clearInterval(intervalId);
    }, delay);

    return () => clearTimeout(timeoutId);
  }, []);

  // Battery API (unchanged)
  useEffect(() => {
    const fetchBattery = async () => {
      if ("getBattery" in navigator) {
        try {
          const battery = await navigator.getBattery();
          updateBatteryInfo(battery);
          battery.addEventListener("levelchange", () =>
            updateBatteryInfo(battery)
          );
          battery.addEventListener("chargingchange", () =>
            updateBatteryInfo(battery)
          );
        } catch (error) {
          console.error("Battery API error:", error);
        }
      }
    };

    const updateBatteryInfo = (battery) => {
      setBatteryLevel(Math.round(battery.level * 100));
      setIsCharging(battery.charging);
    };

    fetchBattery();
  }, []);

  const BatteryIcon = () => {
    if (isCharging) return <Battery className="w-4 h-4 text-[#8A4FFF]" />;
    if (batteryLevel > 70) return <BatteryFull className="w-4 h-4" />;
    if (batteryLevel > 30) return <BatteryMedium className="w-4 h-4" />;
    return <BatteryLow className="w-4 h-4 text-[#FF6B6B]" />;
  };

  return (
    <header className="flex justify-between items-center mb-6 p-4 backdrop-blur-md bg-[#1a1a2e]/80 border-b border-[#4A4B5A]/50 sticky top-0 z-10">
      {/* Title */}
      <div className="flex items-center gap-3">
        <div className="relative">
          <div className="absolute -right-1 -top-1 w-2 h-2 bg-[#8A4FFF] rounded-full animate-pulse" />
          <h1 className="text-2xl font-bold text-[#BEB7DF]">{title}</h1>
        </div>
      </div>

      {/* Navigation Links */}
      <nav className="hidden md:flex items-center gap-1">
        {navItems.map((item) => (
          <NavLink
            key={item.path}
            to={item.path}
            className={({ isActive }) =>
              `px-3 py-1.5 rounded-md text-sm font-medium transition-colors ${
                isActive
                  ? "bg-[#6C5CE7]/20 text-[#E0DDFF]"
                  : "text-[#E0DDFF]/70 hover:bg-[#16213e]/30"
              }`
            }
          >
            {item.name}
          </NavLink>
        ))}
      </nav>

      {/* Status bar */}
      <div className="flex items-center gap-4">
        <div className="flex items-center gap-3 text-xs text-[#BEB7DF]/80">
          <span>{batteryLevel}%</span>
          <div className="w-12 h-1.5 rounded-full bg-[#0f0f1a]">
            <div
              className={`h-full rounded-full ${
                batteryLevel < 20 ? "bg-[#FF6B6B]" : "bg-[#6C5CE7]"
              }`}
              style={{ width: `${batteryLevel}%` }}
            />
          </div>
          <BatteryIcon />
          <Wifi className="w-4 h-4" />
        </div>

        {/* Animated time */}
        <motion.span
          key={timeKey}
          initial={{ opacity: 0, y: -2 }}
          animate={{ opacity: 1, y: 0 }}
          transition={{ duration: 0.3 }}
          className="text-sm font-mono text-[#BEB7DF]"
        >
          {currentTime.toLocaleTimeString("en-US", {
            hour: "2-digit",
            minute: "2-digit",
            hour12: true,
          })}
        </motion.span>
      </div>
    </header>
  );
};

export default Header;
