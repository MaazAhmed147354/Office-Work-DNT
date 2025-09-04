import React, { useState } from "react";
import "./SalesTargetCard.css";

const SalesTargetCard = ({ target = 2, achieved = 1 }) => {
  const pctRaw = target === 0 ? 0 : (achieved / target) * 100;
  const percentage = Math.floor(Math.min(Math.max(pctRaw, 0), 100));
  const adjustedHeight = percentage <= 10 ? 2 : percentage - percentage / 12;
  const adjustedWidth = percentage <= 60 ? 370 : 1000;

  return (
    <div className="group battery-target-card flex flex-col items-center justify-center min-w-full h-full p-4">
      {/* Battery head */}
      <div className="w-10 h-3 bg-[#38384a] rounded-t-sm transition-all duration-300 group-hover:scale-110 group-hover:-translate-y-1.75 group-hover:shadow-[0_0_20px_rgba(124,58,237,0.28)]" />

      {/* Battery body */}
      <div className="relative w-full h-full border-4 border-[#38384a] rounded-md overflow-visible transition-all duration-300 transform group-hover:scale-105 group-hover:shadow-[0_0_20px_rgba(124,58,237,0.28)]">
        {/* Liquid Fill wrapper */}
        <div className="absolute bottom-0 left-0 w-full overflow-visible liquid-fill h-full">
          {/* Wave fill */}
          <svg
            className="absolute bottom-0 wave-front"
            style={{
              height: `${percentage + adjustedHeight}%`,
              width: `${adjustedWidth}%`,
            }}
            viewBox="0 0 1200 200"
            preserveAspectRatio="none"
            xmlns="http://www.w3.org/2000/svg"
            aria-hidden
          >
            <g transform="translate(0,0)">
              <path
                d="M0,95 C150,105 350,85 600,95 C850,105 1050,85 1200,95 L1200,200 L0,200 Z"
                fill="rgba(124,58,237,0.92)"
              />
            </g>
            <g transform="translate(1198,0)">
              <path
                d="M0,95 C150,110 350,85 600,95 C850,105 1050,85 1200,95 L1200,200 L0,200 Z"
                fill="rgba(124,58,237,0.92)"
              />
            </g>
          </svg>
        </div>

        {/* Inner sheen */}
        <div
          className="absolute inset-0 pointer-events-none"
          style={{ boxShadow: "inset 0 12px 30px rgba(255,255,255,0.06)" }}
        />

        {/* Text overlay */}
        <div className="absolute inset-0 flex flex-col items-center justify-center text-center px-1 space-y-1 pointer-events-none">
          <span className="text-sm font-bold text-white/60 uppercase tracking-wide">
            Sales Target
          </span>
          <span className="text-purple-200 text-lg font-extrabold">
            {percentage.toFixed(0)}%
          </span>
          <span className="text-[11px] text-white/60 font-semibold wrap-anywhere">
            {achieved.toLocaleString()}/{target.toLocaleString()}
          </span>
        </div>
      </div>
    </div>
  );
};

export default SalesTargetCard;
