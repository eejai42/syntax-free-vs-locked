import React, { useState, useEffect } from 'react';
import { HashRouter as Router, Route, Routes } from 'react-router-dom';
import HomePage from './HomePage';
import DemoPage from './DemoPage';
import ScriptPage from './ScriptPage';

const App = () => {
  const [data, setData] = useState(null);

  useEffect(() => {
    // Fetch data here and set it with setData
    fetch("data.json")
      .then((response) => response.json())
      .then((loadedData) => {
        setData(loadedData);
      })
      .catch((error) => {
        console.error("Error fetching data: ", error);
      });
  }, []); // Empty dependency array means this runs once on mount

  if (!data) {
    return <div>Loading...</div>;
  }

  return (
    <Router>
      <Routes>
        <Route path="/" element={<HomePage />} />
        <Route path="/demo" element={<DemoPage data={data} />} />
        <Route path="/script" element={<ScriptPage chapters={data.story.chapters} />} />
      </Routes>
    </Router>
  );
};

export default App;
