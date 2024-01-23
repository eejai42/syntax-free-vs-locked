import React, { useState, useEffect } from 'react';
import './App.css';
import GraphViewer from './GraphViewer';
import TextScroller from './TextScroller';
import LanguagePicker from './LanguagePicker';
import AppHeader from './AppHeader';

function App() {
  const [data, setData] = useState(null);
  const [currentLanguage, setCurrentLanguage] = useState('English');
  const [currentKeyword, setCurrentKeyword] = useState('Charlie');
  const [currentStoryId, setCurrentStoryId] = useState('meet-the-joneses');
  const [currentStory, setCurrentStory] = useState(null);
  useEffect(() => {
    // Fetch the JSON data when the component mounts
    fetch('/data.json')
      .then(response => response.json())
      .then(data => {
        // Set the data to state
        setData(data);
        const currentStory = data.story["syntax-locked-vs-unlocked"].find(s => s.id === currentStoryId)

        setCurrentStory(currentStory);
      })
      .catch(error => {
        console.error('Error fetching data: ', error);
      });
  }, []);

  // Handler for language change
  const handleLanguageChange = (language) => {
    setCurrentLanguage(language);
  };

  // Handler for keyword select
  const handleKeywordSelect = (keyword) => {
    setCurrentKeyword(keyword);
  };

  // Check if data is loaded
  if (!data) {
    return <div>Loading...</div>; // Or any other loading indicator
  }

  return (
    <div className="App">
      <AppHeader story={currentStory} currentLanguage={currentLanguage} currentKeyword={currentKeyword} />
      <div className="SplitScreen">
        <div className="LeftPane">
          <LanguagePicker data={data} 
                currentLanguage={currentLanguage} onLanguageChange={handleLanguageChange} 
                currentKeyword={currentKeyword} onKeywordSelect={handleKeywordSelect} />
          <TextScroller data={data} languageName={currentLanguage} story={currentStory} currentKeyword={currentKeyword} />
        </div>
        <div className="RightPane">
          <GraphViewer data={data} languageName={currentLanguage} story={currentStory} currentKeyword={currentKeyword} />
        </div>
      </div>
    </div>
  );
}

export default App;
