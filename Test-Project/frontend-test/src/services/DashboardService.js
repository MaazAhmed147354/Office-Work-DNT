import axios from "axios";

const BASE_API_URL = "http://localhost:3001";

class DashboardService {
  async getStatsData() {
    try {
      const res = await axios.get(BASE_API_URL + "/dashboard/stats-data");
      return res;
    } catch (error) {
      console.log("Error: ", error.message);
    }
  }

  async getChartsData() {
    try {
      const res = await axios.get(BASE_API_URL + "/dashboard/charts-data");
      return res;
    } catch (error) {
      console.log("Error: ", error.message);
    }
  }

  async getProjectsData() {
    try {
      const res = await axios.get(BASE_API_URL + "/dashboard/projects-data");
      return res;
    } catch (error) {
      console.log("Error: ", error.message);
    }
  }
}

export default new DashboardService();
