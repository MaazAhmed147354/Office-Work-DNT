import { useEffect } from "react";
import { Info, CheckCircle, AlertTriangle, XCircle } from "lucide-react";

const CustomToast = ({ message, type = "info", onClose, duration = 4000 }) => {
  useEffect(() => {
    const timer = setTimeout(() => {
      onClose();
    }, duration);

    return () => clearTimeout(timer);
  }, [onClose, duration]);

  const bgColor = {
    info: "bg-[#8a4fff]",
    warning: "bg-yellow-600",
    error: "bg-red-600",
    success: "bg-green-600",
  }[type];

  const Icon = {
    info: Info,
    warning: AlertTriangle,
    error: XCircle,
    success: CheckCircle,
  }[type];

  return (
    <div className="fixed bottom-4 right-4 z-50 animate-fade-in-up">
      <div
        className={`${bgColor} text-white px-4 py-3 rounded-lg shadow-lg flex items-center gap-3`}
      >
        <Icon className="w-5 h-5" />
        <span>{message}</span>
        <button
          onClick={onClose}
          className="text-white hover:text-gray-200 text-lg"
        >
          ×
        </button>
      </div>
    </div>
  );
};

export default CustomToast;
