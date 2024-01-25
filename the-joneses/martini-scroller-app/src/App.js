import React, { useState, useEffect, useRef } from 'react';
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

  const currentStoryIdRef = useRef(currentStoryId);
  const storyListRef = useRef(storyList);

  // Update the ref whenever the state changes
  useEffect(() => {
    currentStoryIdRef.current = currentStoryId;
    storyListRef.current = storyList;
  }, [currentStory]);


    // Function to handle key press
    const handleKeyPress = (event) => {
      if (event.keyCode === 37) { // Left arrow key
        handlePreviousStory();
      } else if (event.keyCode === 39) { // Right arrow key
        handleNextStory();
      }
    };
  
    // Adding event listener when component mounts
    useEffect(() => {
      window.addEventListener('keydown', handleKeyPress);
  
      // Removing event listener when component unmounts
      return () => {
        window.removeEventListener('keydown', handleKeyPress);
      };
    }, []);
  
  
  

  useEffect(() => {
//    fetch('https://raw.githubusercontent.com/eejai42/syntax-free-vs-locked/master/the-joneses/martini-scroller-app/public/data.json')
    fetch('data.json')
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
    const _storyList = storyListRef.current;
    const _currentStoryId = currentStoryIdRef.current;
    console.error('StoryList: ', _storyList, "StoryId", _currentStoryId)
    const currentIndex = _storyList.findIndex(story => story.id === _currentStoryId);
    const nextIndex = (currentIndex + 1) % _storyList.length;
    console.error('NEXT: ', currentIndex, nextIndex, _storyList.length)
    setCurrentStoryId(_storyList[nextIndex].id);
  };

  const handlePreviousStory = () => {
    const _storyList = storyListRef.current;
    const _currentStoryId = currentStoryIdRef.current;
    console.error('StoryList: ', _storyList, _currentStoryId)
    const currentIndex = _storyList.findIndex(story => story.id === _currentStoryId);
    const prevIndex = (currentIndex - 1 + _storyList.length) % _storyList.length;
    console.error('PREV: ', currentIndex, prevIndex, _storyList.length)
    setCurrentStoryId(_storyList[prevIndex].id);
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
