import { DollarSign, Users, ShoppingCart } from "lucide-react";

export const kpis = [
  {
    title: "Total Sales",
    value: "$45,000",
    change: "+12.5%",
    icon: DollarSign,
    isPositive: true,
  },
  {
    title: "New Customers",
    value: "320",
    change: "-4.2%",
    icon: Users,
    isPositive: false,
  },
  {
    title: "Orders",
    value: "812",
    change: "+8.9%",
    icon: ShoppingCart,
    isPositive: true,
  },
  {
    title: "Total Revenue",
    value: "$45,000",
    change: "+12.5%",
    icon: DollarSign,
    isPositive: true,
  },
  {
    title: "New Products",
    value: "320",
    change: "-4.2%",
    icon: Users,
    isPositive: false,
  },
  {
    title: "Capital Burn",
    value: "812",
    change: "+8.9%",
    icon: ShoppingCart,
    isPositive: true,
  },
];

export const kpiChartData = [
  {
    title: "Total Sales",
    statement: "Monthly sales trend",
    update: "updated 1 hour ago",
    type: "line",
    data: [12000, 15000, 13000, 17000, 20000, 22000, 24000],
    labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul"],
    options: {
      responsive: true,
      scales: {
        x: { ticks: { color: "#f8fafc" } },
        y: { ticks: { color: "#f8fafc" } },
      },
      plugins: {
        legend: { labels: { color: "#e2e8f0" } },
        tooltip: { enabled: true },
      },
    },
  },
  {
    title: "New Customers",
    statement: "Weekly new users",
    update: "last synced yesterday",
    type: "bar",
    data: [40, 55, 30, 60, 50, 45, 70],
    labels: ["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"],
    options: {
      responsive: true,
      scales: {
        x: { ticks: { color: "#f8fafc" } },
        y: { ticks: { color: "#f8fafc" } },
      },
      plugins: {
        legend: { labels: { color: "#e2e8f0" } },
        tooltip: { enabled: true },
      },
    },
  },
  {
    title: "Orders",
    statement: "Distribution by category",
    update: "refreshed 30 mins ago",
    type: "pie",
    data: [300, 150, 100, 50],
    labels: ["Electronics", "Clothing", "Home", "Books"],
    options: {
      responsive: true,
      plugins: {
        legend: { labels: { color: "#f8fafc" } },
        tooltip: { enabled: true },
      },
    },
  },
  {
    title: "Total Revenue",
    statement: "Quarterly revenue report",
    update: "updated just now",
    type: "bar",
    data: [15000, 18000, 22000, 26000],
    labels: ["Q1", "Q2", "Q3", "Q4"],
    options: {
      responsive: true,
      scales: {
        x: { ticks: { color: "#f8fafc" } },
        y: { ticks: { color: "#f8fafc" } },
      },
      plugins: {
        legend: { labels: { color: "#e2e8f0" } },
        tooltip: { enabled: true },
      },
    },
  },
  {
    title: "New Products",
    statement: "Product launches over months",
    update: "synced 10 min ago",
    type: "line",
    data: [5, 10, 8, 15, 12, 14, 16],
    labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul"],
    options: {
      responsive: true,
      scales: {
        x: { ticks: { color: "#f8fafc" } },
        y: { ticks: { color: "#f8fafc" } },
      },
      plugins: {
        legend: { labels: { color: "#e2e8f0" } },
        tooltip: { enabled: true },
      },
    },
  },
  {
    title: "Capital Burn",
    statement: "Cost breakdown by department",
    update: "latest update received",
    type: "pie",
    data: [40, 25, 20, 15],
    labels: ["Operations", "Marketing", "R&D", "HR"],
    options: {
      responsive: true,
      plugins: {
        legend: { labels: { color: "#f8fafc" } },
        tooltip: { enabled: true },
      },
    },
  },
];
