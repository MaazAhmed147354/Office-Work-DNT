import React, { useState, useEffect } from "react";
import {
  Wifi,
  Battery,
  BatteryFull,
  BatteryMedium,
  BatteryLow,
  BellDot,
  Search,
} from "lucide-react";
import { motion } from "framer-motion";

const Header = () => {
  const [currentTime, setCurrentTime] = useState(new Date());
  const [batteryLevel, setBatteryLevel] = useState(82);
  const [isCharging, setIsCharging] = useState(false);
  const [timeKey, setTimeKey] = useState(0);

  useEffect(() => {
    const updateTime = () => {
      const now = new Date();
      setCurrentTime(now);
      setTimeKey((prev) => prev + 1);
    };

    const now = new Date();
    const delay = (60 - now.getSeconds()) * 1000;

    const timeoutId = setTimeout(() => {
      updateTime();
      const intervalId = setInterval(updateTime, 60000);
      return () => clearInterval(intervalId);
    }, delay);

    return () => clearTimeout(timeoutId);
  }, []);

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
    <header className="flex justify-between items-center p-6 py-4 bg-transparent backdrop-blur-md sticky top-0 z-10">
      {/* Left: Search Bar */}
      <div className="flex items-center gap-2 bg-[#1e1e2d] px-3 py-1.5 rounded-md border border-[#38384a] w-full max-w-sm">
        <Search className="w-4 h-4 text-[#8a4fff]" />
        <input
          type="text"
          placeholder="Search..."
          className="bg-transparent text-sm text-white placeholder-gray-400 focus:outline-none w-full"
        />
      </div>

      {/* Right: System Info */}
      <div className="flex items-center gap-4">
        {/* Battery & Wifi */}
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

        {/* Time */}
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

        {/* Notifications */}
        <BellDot className="w-5 h-5 text-gray-300 hover:text-[#8a4fff] cursor-pointer" />
      </div>
    </header>
  );
};

export default Header;
