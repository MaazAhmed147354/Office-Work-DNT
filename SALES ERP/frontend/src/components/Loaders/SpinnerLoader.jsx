const GlobalLoader = ({ fullscreen = false, label = "Loading..." }) => {
  return (
    <div
      className={[
        "flex items-center justify-center",
        fullscreen ? "fixed inset-0 z-50 bg-[#1a1a2e]" : "w-full h-[80vh]",
      ].join(" ")}
      role="status"
      aria-live="polite"
    >
      <div className="flex flex-col items-center gap-3">
        <div className="h-12 w-12 animate-spin rounded-full border-4 border-[#8a4fff]/30 border-t-[#8a4fff]" />
        {label ? <p className="text-[#BEB7DF] text-sm">{label}</p> : null}
      </div>
    </div>
  );
};

export default GlobalLoader;
