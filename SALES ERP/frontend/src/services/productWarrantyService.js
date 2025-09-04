import axios from "axios";

// const BASE_API_URL = "https://localhost:7185/api";
// const BASE_API_URL = "http://103.134.239.26:2025/api";
const BASE_API_URL = import.meta.env.VITE_API_URL;

class ProductWarrantyService {
  async getProductWarranty(macAddress) {
    try {
      const token = localStorage.getItem("token");
      if (!token) return false;

      const res = await axios.get(
        `${BASE_API_URL}/ProductWarranty/GetProductWarrantyByMac`,
        {
          params: { macAddress },
          headers: {
            Authorization: `Bearer ${token}`,
          },
        }
      );

      console.log(res.data); // Full response from API
      return res.data; // This will be your ProductWarrantyResponseDTO
    } catch (err) {
      console.error("Error fetching product warranty:", err);
      throw err;
    }
  }
}

export default new ProductWarrantyService();
