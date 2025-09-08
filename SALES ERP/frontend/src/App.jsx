import { SidebarProvider } from "./context/SidebarContext";
import { BrowserRouter, Routes, Route, Navigate } from "react-router-dom";
import MainLayout from "./layouts/MainLayout";
import { LoginForm, PrivateRoute } from "./components";
import {
  Dashboard,
  Analytics,
  Warranty,
  Employees,
  Products,
  Settings,
  Unauthorized,
  NotFound,
} from "./pages";
import "./App.css";

function App() {
  return (
    <div className="min-h-screen p-0 bg-[#1e1e2d] custom-scrollbar">
      <SidebarProvider>
        <BrowserRouter>
          <Routes>
            <Route path="/" element={<Navigate to="/login" />} />
            <Route path="/login" element={<LoginForm />} />
            <Route element={<MainLayout />}>
              <Route element={<PrivateRoute routePath="/dashboard" />}>
                <Route path="/dashboard" element={<Dashboard />} />
              </Route>

              <Route element={<PrivateRoute routePath="/analytics" />}>
                <Route path="/analytics" element={<Analytics />} />
              </Route>

              <Route element={<PrivateRoute routePath="/warranty" />}>
                <Route path="/warranty" element={<Warranty />} />
              </Route>

              <Route element={<PrivateRoute routePath="/employees" />}>
                <Route path="/employees" element={<Employees />} />
              </Route>

              <Route element={<PrivateRoute routePath="/products" />}>
                <Route path="/products" element={<Products />} />
              </Route>

              <Route element={<PrivateRoute routePath="/settings" />}>
                <Route path="/settings" element={<Settings />} />
              </Route>

              <Route path="/unauthorized" element={<Unauthorized />} />

              <Route path="*" element={<NotFound />} />
            </Route>
          </Routes>
        </BrowserRouter>
      </SidebarProvider>
    </div>
  );
}

export default App;
