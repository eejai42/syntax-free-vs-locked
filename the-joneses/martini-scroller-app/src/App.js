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
  const [storyList, setStoryList] = useState([]);

  useEffect(() => {
    fetch('https://raw.githubusercontent.com/eejai42/syntax-free-vs-locked/master/the-joneses/martini-scroller-app/public/data.json')
//    fetch('data.json')
      .then(response => response.json())
      .then(data => {
        setData(data);
        setStoryList(data.story["syntax-locked-vs-unlocked"]);
        const currentStory = data.story["syntax-locked-vs-unlocked"].find(s => s.id === currentStoryId);
        setCurrentStory(currentStory);
      })
      .catch(error => {
        console.error('Error fetching data: ', error);
      });
  }, []);

  useEffect(() => {
    if (data) {
      const currentStory = data.story["syntax-locked-vs-unlocked"].find(s => s.id === currentStoryId);
      setCurrentStory(currentStory);
    }
  }, [currentStoryId, data]);

  const handleLanguageChange = (language) => {
    setCurrentLanguage(language);
  };

  const handleKeywordSelect = (keyword) => {
    setCurrentKeyword(keyword);
  };

  const handleNextStory = () => {
    const currentIndex = storyList.findIndex(story => story.id === currentStoryId);
    const nextIndex = (currentIndex + 1) % storyList.length;
    setCurrentStoryId(storyList[nextIndex].id);
  };

  const handlePreviousStory = () => {
    const currentIndex = storyList.findIndex(story => story.id === currentStoryId);
    const prevIndex = (currentIndex - 1 + storyList.length) % storyList.length;
    setCurrentStoryId(storyList[prevIndex].id);
  };

  if (!data) {
    return <div>Loading...</div>;
  }

  return (
    <div className="App">
      <AppHeader story={currentStory} currentLanguage={currentLanguage} currentKeyword={currentKeyword} />
      <button onClick={handlePreviousStory}>Previous Story</button>
      <button onClick={handleNextStory}>Next Story</button>
      <div className="SplitScreen">
        <div className="RightPane">
          <GraphViewer data={data} languageName={currentLanguage} story={currentStory} currentKeyword={currentKeyword} />
        </div>
        <div className="LeftPane">
          <TextScroller data={data} languageName={currentLanguage} story={currentStory} currentKeyword={currentKeyword} />
          <LanguagePicker data={data} currentLanguage={currentLanguage} onLanguageChange={handleLanguageChange} currentKeyword={currentKeyword} onKeywordSelect={handleKeywordSelect} />
        </div>
      </div>
    </div>
  );
}

export default App;
