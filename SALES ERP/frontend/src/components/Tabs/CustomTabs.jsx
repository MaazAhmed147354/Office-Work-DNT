const CustomTabs = ({ tabs, activeTab, onTabChange }) => {
  return (
    <div className="rounded-xl p-0 mb-4">
      <div className="flex space-x-1">
        {tabs.map((tab) => (
          <button
            key={tab.id}
            onClick={() => onTabChange(tab.id)}
            className={`relative px-4 py-2 flex items-center gap-2 transition-colors ${
              activeTab === tab.id
                ? "text-white"
                : "text-gray-300 hover:text-white"
            }`}
          >
            {/* Icon always visible */}
            {tab.icon && <span>{tab.icon}</span>}

            {/* Label hidden on small screens, visible on md+ */}
            <span className="hidden lg:inline">{tab.label}</span>

            {/* Underline element */}
            <span
              className={`absolute left-0 bottom-0 h-[3px] bg-[#8a4fff] transition-all duration-500 ease-out ${
                activeTab === tab.id ? "w-full" : "w-0"
              }`}
            />
          </button>
        ))}
      </div>
    </div>
  );
};

export default CustomTabs;
