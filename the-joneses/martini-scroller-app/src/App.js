import React from "react";
import { HashRouter as Router, Route, Routes } from "react-router-dom";
 import HomePage from "./HomePage";
 import DemoPage from "./DemoPage";


const App = () => {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<HomePage />} />
        <Route path="/demo" element={<DemoPage />} />
      </Routes>
    </Router>
  );
};

export default App;
