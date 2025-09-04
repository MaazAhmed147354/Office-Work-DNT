import { useState } from "react";
import authService from "../../services/authService";
import { useNavigate } from "react-router-dom";
import { Lock, User } from "lucide-react";

const LoginForm = () => {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [errorMsg, setErrorMsg] = useState("");
  const [isLoading, setIsLoading] = useState(false);
  const navigate = useNavigate();

  const handleSubmit = async (e) => {
    e.preventDefault();
    setIsLoading(true);
    const res = await authService.loginUser(username, password);
    setIsLoading(false);

    if (res.success) {
      if (res.roleText === "Admin" || res.roleText === "Seller") {
        navigate("/dashboard");
      } else {
        navigate("/products");
      }
    } else {
      setErrorMsg(res.message);
    }
  };

  return (
    <div className="flex justify-center items-center h-screen bg-login">
      <form
        onSubmit={handleSubmit}
        className="login-form p-8 rounded-xl shadow-2xl border border-[#38384a] w-full max-w-md backdrop-blur-xl animate-fadeIn"
      >
        {/* Header */}
        <div className="flex flex-col items-center mb-6">
          <img
            src="/logo.png" /* Place logo in public folder */
            alt="App Logo"
            className="w-14 h-14 mb-2 drop-shadow-lg"
          />
          <h2 className="typewriter text-2xl font-bold text-[#8a4fff] drop-shadow-lg">
            Welcome User
          </h2>
        </div>

        {/* Error */}
        {errorMsg && (
          <div className="mb-4 p-3 bg-[#ff6b6b]/10 text-[#ff6b6b] text-sm rounded-md border border-[#ff6b6b]/30">
            {errorMsg}
          </div>
        )}

        {/* Username */}
        <div className="mb-4 group">
          <label className="block text-sm font-medium text-[#BEB7DF] mb-2 group-focus-within:text-[#8a4fff] transition-all">
            Username
          </label>
          <div className="relative">
            <div className="absolute inset-y-0 left-0 pl-3 flex items-center pointer-events-none">
              <User className="h-5 w-5 text-[#8a4fff] transition-colors duration-300 group-focus-within:text-purple-300" />
            </div>
            <input
              type="text"
              placeholder="Enter your username"
              className="w-full pl-10 pr-3 py-2.5 bg-[#1e1e2d]/90 border border-[#38384a] rounded-lg focus:outline-none focus:ring-2 focus:ring-[#8a4fff] focus:border-transparent text-[#BEB7DF] placeholder-[#4A4B5A] transition-all duration-300 hover:shadow-[0_0_10px_rgba(138,79,255,0.3)]"
              value={username}
              onChange={(e) => setUsername(e.target.value)}
            />
          </div>
        </div>

        {/* Password */}
        <div className="mb-6 group">
          <label className="block text-sm font-medium text-[#BEB7DF] mb-2 group-focus-within:text-[#8a4fff] transition-all">
            Password
          </label>
          <div className="relative">
            <div className="absolute inset-y-0 left-0 pl-3 flex items-center pointer-events-none">
              <Lock className="h-5 w-5 text-[#8a4fff] transition-colors duration-300 group-focus-within:text-purple-300" />
            </div>
            <input
              type="password"
              placeholder="Enter your password"
              className="w-full pl-10 pr-3 py-2.5 bg-[#1e1e2d]/90 border border-[#38384a] rounded-lg focus:outline-none focus:ring-2 focus:ring-[#8a4fff] focus:border-transparent text-[#BEB7DF] placeholder-[#4A4B5A] transition-all duration-300 hover:shadow-[0_0_10px_rgba(138,79,255,0.3)]"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
            />
          </div>
        </div>

        {/* Button */}
        <button
          type="submit"
          disabled={isLoading}
          className={`w-full py-3 px-4 rounded-lg font-medium text-white transition-all duration-300 bg-gradient-to-r from-[#8a4fff] to-[#7a3fe6] bg-size-200 bg-pos-0 hover:bg-pos-100 ${
            isLoading
              ? "opacity-70 cursor-not-allowed"
              : "hover:shadow-lg hover:shadow-[#8a4fff]/20"
          }`}
        >
          {isLoading ? (
            <span className="flex items-center justify-center">
              <svg
                className="animate-spin -ml-1 mr-3 h-5 w-5 text-white"
                xmlns="http://www.w3.org/2000/svg"
                fill="none"
                viewBox="0 0 24 24"
              >
                <circle
                  className="opacity-25"
                  cx="12"
                  cy="12"
                  r="10"
                  stroke="currentColor"
                  strokeWidth="4"
                ></circle>
                <path
                  className="opacity-75"
                  fill="currentColor"
                  d="M4 12a8 8 0 018-8V0C5.373 0 0 5.373 0 12h4zm2 5.291A7.962 7.962 0 014 12H0c0 3.042 1.135 5.824 3 7.938l3-2.647z"
                ></path>
              </svg>
              Signing in...
            </span>
          ) : (
            "Sign In"
          )}
        </button>
      </form>
    </div>
  );
};

export default LoginForm;
