import { X } from "lucide-react";

const LogoutModal = ({ isOpen, onClose, onConfirm }) => {
  if (!isOpen) return null;

  return (
    <div className="fixed inset-0 z-50 flex items-center justify-center bg-black/50 backdrop-blur-sm">
      <div className="relative bg-[#252538] rounded-xl border border-[#38384a] p-6 w-full max-w-md mx-4">
        {/* Close button */}
        <button
          onClick={onClose}
          className="absolute top-4 right-4 p-1 rounded-full hover:bg-[#38384a] transition-colors"
        >
          <X className="w-5 h-5 text-[#BEB7DF]" />
        </button>

        {/* Modal content */}
        <div className="text-center">
          <h3 className="text-xl font-semibold text-[#BEB7DF] mb-2">
            Confirm Logout
          </h3>
          <p className="text-gray-300 mb-6">
            Are you sure you want to sign out?
          </p>

          <div className="flex justify-center gap-4">
            <button
              onClick={onClose}
              className="px-6 py-2 bg-[#38384a] text-[#BEB7DF] rounded-lg hover:bg-[#4A4B5A] transition-colors"
            >
              Cancel
            </button>
            <button
              onClick={onConfirm}
              className="px-6 py-2 bg-[#8a4fff] text-white rounded-lg hover:bg-[#7a3fe6] transition-colors"
            >
              Logout
            </button>
          </div>
        </div>
      </div>
    </div>
  );
};

export default LogoutModal;
