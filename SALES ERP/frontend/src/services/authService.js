import axios from "axios";

// const BASE_API_URL = "https://localhost:7185/api";
// const BASE_API_URL = "http://103.134.239.26:2025/api";
const BASE_API_URL = import.meta.env.VITE_API_URL;

class AuthService {
  async loginUser(username, password) {
    try {
      const response = await axios.post(`${BASE_API_URL}/auth/login`, {
        username: username,
        password: password,
      });
      console.log(response);

      if (response.status === 200 && response.data.data.token) {
        const { id, token, role } = response.data.data;
        const roleText = role === 1 ? "Admin" : role === 21 ? "Seller" : "BasicUser";
        localStorage.setItem("userid", id);
        localStorage.setItem("token", token);
        localStorage.setItem("roleid", role);
        localStorage.setItem("roleText", roleText);
        return { success: true, roleText: roleText };
      }

      return { success: false, message: "Invalid credentials" };
    } catch (err) {
      return {
        success: false,
        message: err?.response?.data?.message || "Login failed",
      };
    }
  }

  async validateAccess(path) {
    try {
      const token = localStorage.getItem("token");
      if (!token) return false;

      const res = await axios.get(`${BASE_API_URL}/pages${path}`, {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      });
      return res.status === 200;
    } catch {
      return false;
    }
  }

  async logoutUser() {
    localStorage.clear();
  }
}

export default new AuthService();
