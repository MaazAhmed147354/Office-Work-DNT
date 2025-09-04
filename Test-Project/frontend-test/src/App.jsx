import Dashboard from "./pages/dashboard";
import {
  BrowserRouter as Router,
  Routes,
  Route,
  useNavigate,
} from "react-router-dom";

function App() {
  return (
    <>
      <Router>
        <Routes>
          <Route path="/" element={<Dashboard />} />
        </Routes>
      </Router>
    </>
  );
}

export default App;
