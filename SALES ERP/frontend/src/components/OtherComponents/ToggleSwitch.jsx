const ToggleSwitch = ({
  options,
  active,
  onToggle,
  position = "",
  customWidth = "",
}) => (
  <div className={`flex items-center rounded-lg mb-4 ${position} max-w-full`}>
    {options.map((opt) => (
      <button
        key={opt.id}
        onClick={() => onToggle(opt.id)}
        className={`flex items-center ${customWidth} justify-center gap-2 px-4 py-2 rounded-md transition-colors ${
          active === opt.id
            ? "bg-[#8a4fff] text-white"
            : "text-gray-300 hover:text-white hover:bg-gray-300/10"
        }`}
      >
        {opt.icon && <span>{opt.icon}</span>}
        <span>{opt.label}</span>
      </button>
    ))}
  </div>
);

export default ToggleSwitch;
