// Base Bar Chart Config
export const barChartBaseConfig = {
  options: {
    responsive: true,
    maintainAspectRatio: false,
    plugins: {
      legend: { labels: { color: "#BEB7DF" } },
      tooltip: {
        backgroundColor: "#252538",
        titleColor: "#ffffff",
        bodyColor: "#e0e0e0",
        borderColor: "#38384a",
        borderWidth: 1,
        padding: 12,
      },
    },
    scales: {
      x: {
        ticks: { color: "#b0b0b0" },
        grid: { color: "#38384a" },
      },
      y: {
        ticks: { color: "#b0b0b0" },
        grid: { color: "#38384a" },
      },
    },
  },
};

// Base Line Chart Config
export const lineChartBaseConfig = {
  options: {
    responsive: true,
    maintainAspectRatio: false,
    plugins: {
      legend: { labels: { color: "#BEB7DF" } },
      tooltip: {
        backgroundColor: "#252538",
        titleColor: "#ffffff",
        bodyColor: "#e0e0e0",
        borderColor: "#38384a",
        borderWidth: 1,
        padding: 12,
      },
    },
    scales: {
      x: { ticks: { color: "#b0b0b0" }, grid: { color: "#38384a" } },
      y: { ticks: { color: "#b0b0b0" }, grid: { color: "#38384a" } },
    },
  },
};

// Base Radar Chart Config
export const radarChartBaseConfig = {
  options: {
    plugins: {
      legend: { labels: { color: "#BEB7DF" } },
    },
    scales: {
      r: {
        angleLines: { color: "#38384a" },
        grid: { color: "#38384a" },
        pointLabels: { color: "#BEB7DF" },
        ticks: { display: false, backdropColor: "transparent" },
      },
    },
  },
};

// Base Polar Area Chart Config
export const polarAreaChartBaseConfig = {
  options: {
    responsive: true,
    maintainAspectRatio: false,
    plugins: {
      legend: {
        position: "right",
        labels: { color: "#BEB7DF" },
      },
    },
    scales: {
      r: {
        grid: { color: "#38384a" },
        angleLines: { color: "#38384a" },
        pointLabels: { color: "#BEB7DF" },
        ticks: { display: false, backdropColor: "transparent" },
      },
    },
  },
};
