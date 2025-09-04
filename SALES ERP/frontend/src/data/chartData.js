// Polar area static data (used by PolarAreaChartCard)
export const polarAreaData = {
  labels: ["React", "Vue", "Angular", "Svelte", "Solid"],
  datasets: [
    {
      label: "Tech usage",
      data: [35, 25, 20, 15, 5],
      backgroundColor: [
        "rgba(138,79,255,0.5)",
        "rgba(74,222,255,0.5)",
        "rgba(77,124,255,0.5)",
        "rgba(168,85,247,0.5)",
        "rgba(255,107,107,0.5)",
      ],
      borderColor: ["#8a4fff", "#4adeff", "#4d7cff", "#a855f7", "#ff6b6b"],
      borderWidth: 1,
    },
  ],
};

// Radar static data (used by RadarChartCard)
export const radarData = {
  labels: ["Speed", "Reliability", "Comfort", "Safety", "Efficiency"],
  datasets: [
    {
      label: "Model S",
      data: [90, 85, 95, 80, 70],
      backgroundColor: "rgba(138,79,255,0.25)",
      borderColor: "#8a4fff",
      borderWidth: 2,
      pointBackgroundColor: "#8a4fff",
    },
    {
      label: "Model 3",
      data: [70, 82, 91, 92, 89],
      backgroundColor: "rgba(74,222,255,0.2)",
      borderColor: "#4adeff",
      borderWidth: 2,
      pointBackgroundColor: "#4adeff",
    },
  ],
};

// Progress (hours spent) static data (used by ProgressChartCard)
// kept same labels/data as your original ProgressChart.jsx
export const progressData = {
  labels: ["M", "T", "W", "F", "S", "M", "W", "S", "T", "F", "S", "M"],
  datasets: [
    {
      label: "Hours Spent",
      data: [4, 10, 2, 6, 3, 7, 5, 4, 4.5, 14, 5.5, 4],
      backgroundColor: "rgba(138,79,255,0.7)",
      borderColor: "#8a4fff",
      borderWidth: 2,
      // note: original used a gradient; for simplicity we use a solid rgba here
    },
  ],
};
