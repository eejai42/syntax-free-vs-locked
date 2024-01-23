import React, { useState, useEffect } from 'react';
import './App.css';
import GraphViewer from './GraphViewer';
import TextScroller from './TextScroller';
import LanguagePicker from './LanguagePicker';

function App() {
  const [data, setData] = useState(null);
  const [currentLanguage, setCurrentLanguage] = useState('English');

  useEffect(() => {
    // Fetch the JSON data when the component mounts
    fetch('/data.json')
      .then(response => response.json())
      .then(data => {
        // Set the data to state
        setData(data);
      })
      .catch(error => {
        console.error('Error fetching data: ', error);
      });
  }, []);

  // Handler for language change
  const handleLanguageChange = (language) => {
    setCurrentLanguage(language);
  };

  // Check if data is loaded
  if (!data) {
    return <div>Loading...</div>; // Or any other loading indicator
  }

  return (
    <div className="App">
      <div className="SplitScreen">
        <div className="LeftPane">
          <GraphViewer data={data} languageName={currentLanguage} storyId='meet-the-joneses' />
        </div>
        <div className="RightPane">
          <LanguagePicker data={data} currentLanguage={currentLanguage} onLanguageChange={handleLanguageChange} />
          <TextScroller data={data} languageName={currentLanguage} storyId='meet-the-joneses' />
        </div>
      </div>
    </div>
  );
}

export default App;
