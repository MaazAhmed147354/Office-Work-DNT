import axios from "axios";

// const BASE_API_URL = "https://localhost:7185/api";
// const BASE_API_URL = "http://103.134.239.26:2025/api";
const BASE_API_URL = import.meta.env.VITE_API_URL;

class ProductService {
  async getProductsList() {
    try {
      const token = localStorage.getItem("token");
      if (!token) return false;

      const res = await axios.get(`${BASE_API_URL}/Product/GetProductsList`, {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      });

      console.log(res.data); // Full response from API
      return res.data; // This will be your ProductsList
    } catch (err) {
      console.error("Error fetching products list:", err);
      throw err;
    }
  }
}

export default new ProductService();
