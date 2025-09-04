export const statCardData = [
  {
    label: "Bookings",
    value: "281",
    percentage: "+55%",
    comparison: "than last week",
    icolor: "bg-black",
  },
  {
    label: "Today's Users",
    value: "2,300",
    percentage: "+3%",
    comparison: "than last month",
    icolor: "bg-blue-500",
  },
  {
    label: "Revenue",
    value: "34k",
    percentage: "+5%",
    comparison: "than yesterday",
    icolor: "bg-green-500",
  },
  {
    label: "Followers",
    value: "+91",
    percentage: "+1%",
    comparison: "Just updated",
    icolor: "bg-pink-500",
  },
];

export const chartCardData = [
  {
    title: "Website Views",
    statement: "Last Campaign Performance",
    update: "campaign sent 2 days ago",
    type: "bar",
    data: [50, 20, 10, 25, 50, 10, 40],
    labels: ["M", "T", "W", "T", "F", "S", "S"],
    options: {
      responsive: true,
      scales: {
        x: {
          ticks: {
            color: "white", // X-axis text color
          },
        },
        y: {
          ticks: {
            color: "white", // Y-axis text color
          },
        },
      },
      plugins: {
        title: {
          display: false,
          text: "Website Views",
        },
        legend: {
          display: false,
        },
        tooltip: {
          enabled: true,
        },
      },
    },
  },
  {
    title: "Daily Weather",
    statement: "(+15%) increase in today sales",
    update: "updated 4 min ago",
    type: "line",
    data: [75, 25, 300, 320, 500, 375, 200, 220, 530],
    labels: ["Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"],
    options: {
      responsive: true,
      scales: {
        x: {
          ticks: {
            color: "white", // X-axis text color
          },
        },
        y: {
          ticks: {
            color: "white", // Y-axis text color
          },
        },
      },
      plugins: {
        title: {
          display: false,
          text: "Daily Sales",
        },
        legend: {
          display: false,
        },
        tooltip: {
          enabled: true,
        },
      },
    },
  },
  {
    title: "Completed Tasks",
    statement: "Last campaign performance",
    update: "just updated",
    type: "line",
    data: [50, 25, 300, 200, 500, 225, 400, 210, 500],
    labels: ["Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"],
    options: {
      responsive: true,
      scales: {
        x: {
          ticks: {
            color: "white", // X-axis text color
          },
        },
        y: {
          ticks: {
            color: "white", // Y-axis text color
          },
        },
      },
      plugins: {
        title: {
          display: false,
          text: "Completed Tasks",
        },
        legend: {
          display: false,
        },
        tooltip: {
          enabled: true,
        },
      },
    },
  },
];

export const projectsData = [
  {
    company: "Material XD Version",
    logo: "xd.png",
    members: ["avatar-1.png", "avatar-2.png", "avatar-3.png"],
    budget: "$14,000",
    completion: 60,
    color: "blue",
  },
  {
    company: "Add Progress Track",
    logo: "google.png",
    members: ["avatar-4.png"],
    budget: "$3,000",
    completion: 10,
    color: "blue",
  },
  {
    company: "Fix Platform Errors",
    logo: "slack.png",
    members: ["avatar-2.png", "avatar-3.png"],
    budget: "Not set",
    completion: 100,
    color: "green",
  },
  {
    company: "Launch our Mobile App",
    logo: "spotify.png",
    members: ["avatar-1.png", "avatar-2.png", "avatar-3.png", "avatar-4.png"],
    budget: "$20,500",
    completion: 100,
    color: "green",
  },
  {
    company: "Add the New Pricing Page",
    logo: "dropbox.png",
    members: ["avatar-4.png"],
    budget: "$500",
    completion: 25,
    color: "blue",
  },
  {
    company: "Redesign New Online Shop",
    logo: "invision.png",
    members: ["avatar-2.png", "avatar-4.png"],
    budget: "$2,000",
    completion: 40,
    color: "blue",
  },
];

export const ordersData = [
  {
    icon: "bell", // map to icon component or emoji
    description: "$2400, Design changes",
    date: "22 DEC",
    time: "7:20 PM",
  },
  {
    icon: "code",
    description: "New order #1832412",
    date: "21 DEC",
    time: "11 PM",
  },
  {
    icon: "cart",
    description: "Server payments for April",
    date: "21 DEC",
    time: "9:34 PM",
  },
  {
    icon: "credit-card",
    description: "New card added for order #4395133",
    date: "20 DEC",
    time: "2:20 AM",
  },
  {
    icon: "unlock",
    description: "Unlock packages for development",
    date: "18 DEC",
    time: "4:54 AM",
  },
  {
    icon: "camera",
    description: "New order #9583120",
    date: "17 DEC",
  },
];
