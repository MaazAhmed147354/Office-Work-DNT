import { Outlet } from "react-router-dom";
import Sidebar from "../components/Sidebar";
import Header from "../components/Header";
import { useSidebar } from "../context/SidebarContext";

function MainLayout() {
  const { collapsed } = useSidebar();

  return (
    <div className="flex h-screen bg-gradient-to-b from-[#0f172a] to-[#1e293b] text-[#e2e8f0]">
      <Sidebar />
      <div
        className={`${
          collapsed ? "ml-15" : "md:ml-63"
        } flex-1 flex flex-col transition-all duration-300 pl-2`}
      >
        <Header />
        <main className="flex-1 p-4 h-fit">
          <Outlet />
        </main>
        {/* Footer (optional) */}
      </div>
    </div>
  );
}

export default MainLayout;
