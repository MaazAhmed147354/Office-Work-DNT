import { useSidebar } from "../context/SidebarContext";
import { Header, Sidebar } from "../components";
import { Outlet } from "react-router-dom";

const MainLayout = () => {
  const { isCollapsed } = useSidebar();

  return (
    <div className="flex h-screen text-white bg-[#1e1e2d]">
      <Sidebar />
      <div
        className={`flex-1 flex flex-col transition-all duration-300 ${
          isCollapsed ? "ml-20" : "ml-64"
        }`}
      >
        <Header />
        <main className="p-6 flex-1 overflow-auto max-h-fit no-scrollbar">
          <Outlet />
        </main>
      </div>
    </div>
  );
};

export default MainLayout;
