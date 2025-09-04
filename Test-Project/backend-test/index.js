const express = require("express");
const cors = require("cors");
const PORT = 3001;
const {
  chartCardData,
  statCardData,
  projectsData,
} = require("./dashboardData");

const app = express();
app.use(cors());

app.get("/", (req, res) => {
  res.send("Hello, Express!");
});

app.get("/dashboard/charts-data", (req, res) => {
  try {
    res.status(200).json({
      success: true,
      message: "Chart cards fetched successfully",
      data: chartCardData,
    });
  } catch (error) {
    console.log(`Error: ${error.message}`);
    res.status(500).json({
      success: false,
      message: "Chart cards fetching failed.",
      data: error.message,
    });
  }
});

app.get("/dashboard/stats-data", (req, res) => {
  try {
    res.status(200).json({
      success: true,
      message: "Stat cards fetched successfully",
      data: statCardData,
    });
  } catch (error) {
    console.log(`Error: ${error.message}`);
    res.status(500).json({
      success: false,
      message: "Stat cards fetching failed.",
      data: error.message,
    });
  }
});

app.get("/dashboard/projects-data", (req, res) => {
  try {
    res.status(200).json({
      success: true,
      message: "Projects fetched successfully",
      data: projectsData,
    });
  } catch (error) {
    console.log(`Error: ${error.message}`);
    res.status(500).json({
      success: false,
      message: "Projects fetching failed.",
      data: error.message,
    });
  }
});

app.listen(PORT, () => {
  console.log(`Server running at http://localhost:${PORT}`);
});
