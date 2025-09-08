import axios from "axios";

// const BASE_API_URL = "https://localhost:7185/api";
// const BASE_API_URL = "http://103.134.239.26:2025/api";
const BASE_API_URL = import.meta.env.VITE_API_URL;

class AnalyticsService {
  async GetSalesAnalysis(salesIds, rangeType, referenceDate) {
    try {
      const token = localStorage.getItem("token");
      const roleid = localStorage.getItem("roleid");
      if (!token) return false;

      const res = await axios.post(
        `${BASE_API_URL}/Sales/GetSalesAnalysisPerSalesperson`,
        {
          roleId: roleid,
          salesIds: salesIds,
          rangeType: rangeType,
          referenceDate: referenceDate,
        },
        {
          headers: {
            Authorization: `Bearer ${token}`,
          },
        }
      );
      console.log("In Service file:", res.data);

      return res.data;
    } catch (err) {
      console.error("Error fetching Sales Analytics data:", err);
      throw err;
    }
  }

  async getSalespersonList() {
    try {
      const token = localStorage.getItem("token");
      if (!token) return false;

      const res = await axios.get(
        `${BASE_API_URL}/Sales/GetCustomersByRoles?roleIds=21&roleIds=7`,
        {
          // params: {
          //   roleIds: 21,
          //   roleIds: 7,
          // },
          headers: {
            Authorization: `Bearer ${token}`,
          },
        }
      );
      console.log(res.data);

      return res.data;
    } catch (err) {
      console.error("Error fetching sales data:", err);
      throw err;
    }
  }
}

export default new AnalyticsService();
