import "./App.css";
import { BrowserRouter as Router } from "react-router-dom";
import Header from "./components/Header";
import Dashboard from "./pages/Dashboard";

function App() {
  return (
    <>
      <Router>
        <div
          className="min-h-screen p-4 liquid-bg"
          style={{
            background:
              "linear-gradient(135deg, #2b2d42 0%, #1a1a2e 25%, #16213e 50%, #0f0f1a 75%, #000000 100%)",
          }}
        >
          {/* Header */}
          <Header title="PLECTO" />
          <Dashboard />
        </div>
      </Router>
    </>
  );
}

export default App;
