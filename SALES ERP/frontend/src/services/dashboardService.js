import axios from "axios";

// const BASE_API_URL = "https://localhost:7185/api";
// const BASE_API_URL = "http://103.134.239.26:2025/api";
const BASE_API_URL = import.meta.env.VITE_API_URL;

class DashboardService {
  async getProductContribution(startingDate, endingDate) {
    try {
      const token = localStorage.getItem("token");
      if (!token) return false;

      const res = await axios.get(
        `${BASE_API_URL}/Order/GetProductContributionInOrder`,
        {
          params: {
            startingDate,
            endingDate,
          },
          headers: {
            Authorization: `Bearer ${token}`,
          },
        }
      );

      return res.data.result.result;
    } catch (err) {
      console.error("Error fetching product contribution:", err);
      throw err;
    }
  }

  async getSalesBySalesperson() {
    try {
      const token = localStorage.getItem("token");
      const userid = localStorage.getItem("userid");
      const roleid = localStorage.getItem("roleid");
      if (!token) return false;

      const res = await axios.get(
        `${BASE_API_URL}/Sales/GetSalesBySalesperson`,
        {
          params: {
            userid,
            roleid,
          },
          headers: {
            Authorization: `Bearer ${token}`,
          },
        }
      );

      return res.data;
    } catch (err) {
      console.error("Error fetching sales data:", err);
      throw err;
    }
  }

  async getSalesByProduct() {
    try {
      const token = localStorage.getItem("token");
      const userid = localStorage.getItem("userid");
      const roleid = localStorage.getItem("roleid");
      if (!token) return false;

      const res = await axios.get(`${BASE_API_URL}/Sales/GetSalesByProduct`, {
        params: {
          userid,
          roleid,
        },
        headers: {
          Authorization: `Bearer ${token}`,
        },
      });

      return res.data;
    } catch (err) {
      console.error("Error fetching sales data:", err);
      throw err;
    }
  }

  async getMonthlySales() {
    try {
      const token = localStorage.getItem("token");
      const userid = localStorage.getItem("userid");
      const roleid = localStorage.getItem("roleid");
      if (!token) return false;

      const res = await axios.get(
        `${BASE_API_URL}/sales/GetSalesBySalesPersonMonthWise`,
        {
          params: {
            userid,
            roleid,
          },
          headers: {
            Authorization: `Bearer ${token}`,
          },
        }
      );

      return res.data;
    } catch (err) {
      console.error("Error fetching sales data:", err);
      throw err;
    }
  }
}

export default new DashboardService();
