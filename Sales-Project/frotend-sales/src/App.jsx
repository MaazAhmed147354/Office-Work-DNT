import "./App.css";
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import MainLayout from './layouts/MainLayout';
import Dashboard from './pages/Dashboard';
import Sales from './pages/Sales';
import Customers from './pages/Customers';
import Reports from './pages/Reports';

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route element={<MainLayout />}>
          <Route path="/" element={<Dashboard />} />
          <Route path="/sales" element={<Sales />} />
          <Route path="/customers" element={<Customers />} />
          <Route path="/reports" element={<Reports />} />
        </Route>
      </Routes>
    </BrowserRouter>
  );
}

export default App;
