import React, { useState, useEffect } from 'react';
import { HashRouter as Router, Route, Routes } from 'react-router-dom';
import HomePage from './HomePage';
import DemoPage from './DemoPage';
import ScriptPage from './ScriptPage';
import WaterColorsPage from './WaterColorsPage';
import TechShouldFlowPage from './tech-should-flow/TechShouldFlowPage';

const App = () => {
  const [data, setData] = useState(null);
  const [error, setError] = useState(null);
  const [mofData, setMofData] = useState(null);
  const [syntaxLockedChoices, setSyntaxLockedChoices] = useState(null);
  const [syntaxFreeChoices, setSyntaxFreeChoices] = useState(null);

  useEffect(() => {
    // Fetch data here and set it with setData
    fetch("data.json")
      .then((response) => {
        if (!response.ok) {
          throw new Error('Network response was not ok');
        }
        return response.json();
      })
      .then((loadedData) => {
        setData(loadedData);
      })
      .catch((error) => {
        console.error("Error fetching data: ", error);
        setData({"story":{ "chapters": [], keywords: [], "languages": []}});
        setError(error.toString());
        return {};
      });

      fetch("mof-data.json")
      .then((response) => {
        if (!response.ok) {
          throw new Error('Network response was not ok');
        }
        return response.json();
      })
      .then((loadedData) => {
        console.error("loaded demo flow", loadedData);  
        setMofData(loadedData.Airtable);
        setSyntaxLockedChoices(loadedData.Airtable.MOFChoices.filter(choice => !choice.IsSyntaxFree))
        setSyntaxFreeChoices(loadedData.Airtable.MOFChoices.filter(choice => !!choice.IsSyntaxFree))
      })
      .catch((error) => {
        console.error("Error fetching data: ", error);
        setData({"DataFLow": []});
        setError(error.toString());
        return {};
      });
  }, []);

  if (error) {
    return <div>Error: {error}</div>;
  }

  if (!data) {
    return <div>Loading...</div>;
  }

  return (
    <Router>
      <Routes>
        <Route path="/" element={<HomePage />} />
        <Route path="/tech-should-flow"  element={<TechShouldFlowPage mofData={mofData} syntaxLockedChoices={syntaxLockedChoices} syntaxFreeChoices={syntaxFreeChoices}/>} />
        <Route path="/syntax-locked"  element={<WaterColorsPage />} />
        <Route path="/syntax-free"  element={<WaterColorsPage  />} />
        <Route path="/demo" element={<DemoPage data={data} />} />
        <Route path="/script" element={<ScriptPage chapters={data.story?.chapters} />} />
      </Routes>
    </Router>
  );
};

export default App;
