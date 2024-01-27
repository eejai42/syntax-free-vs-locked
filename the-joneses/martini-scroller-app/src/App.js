import React, { useState, useEffect, useRef } from "react";
import "./App.css";
import GraphViewer from "./GraphViewer";
import TextScroller from "./TextScroller";
import LanguagePicker from "./LanguagePicker";
import StoryNavigator from "./StoryNavigator";
import AppHeader from "./AppHeader";
import VariationCoordinator from "./VariationCoordinator";
import StoryLine from "./StoryLine";
import TextToSpeech from "./TextToSpeech";

function App() {
  const [data, setData] = useState(null);
  const [currentLanguage, setCurrentLanguage] = useState("English");
  const [currentKeyword, setCurrentKeyword] = useState("Charlie");
  const [currentStoryId, setCurrentStoryId] = useState("meet-the-joneses");
  const [currentStory, setCurrentStory] = useState(null);
  const [storyList, setStoryList] = useState([]);
  const [currentTime, setCurrentTime] = useState([]);

  const currentStoryIdRef = useRef(currentStoryId);
  const storyListRef = useRef(storyList);

  const [currentVariation, setCurrentVariation] = useState(null);
  const [keywordCounters, setKeywordCounters] = useState({});
  const [currentKeywordCounter, setCurrentKeywordCounter] = useState(0);

  // Function to handle the variation update from VariationCoordinator
  const handleCurrentKeywordCounter = (variation) => {
    setCurrentKeywordCounter(variation);
  };

  const handleKeywordCounters = (counters) => {
    setKeywordCounters(counters);
  };

  // Update the ref whenever the state changes
  useEffect(() => {
    currentStoryIdRef.current = currentStoryId;
    storyListRef.current = storyList;
  }, [currentStory]);

  // Function to handle key press
  const handleKeyPress = (event) => {
    if (event.keyCode === 37) {
      // Left arrow key
      handlePreviousStory();
    } else if (event.keyCode === 39) {
      // Right arrow key
      handleNextStory();
    }
  };

  // Adding event listener when component mounts
  useEffect(() => {
    window.addEventListener("keydown", handleKeyPress);

    // Removing event listener when component unmounts
    return () => {
      window.removeEventListener("keydown", handleKeyPress);
    };
  }, []);

  useEffect(() => {
    //fetch('https://raw.githubusercontent.com/eejai42/syntax-free-vs-locked/master/the-joneses/martini-scroller-app/public/data.json')
    fetch("data.json")
      .then((response) => response.json())
      .then((data) => {
        setData(data);
        setStoryList(data.story["chapters"]);
        const currentStory = data.story["chapters"].find(
          (s) => s.id === currentStoryId
        );
        setCurrentStory(currentStory);
      })
      .catch((error) => {
        console.error("Error fetching data: ", error);
      });
  }, []);

  useEffect(() => {
    if (data) {
      const currentStory = data.story["chapters"].find(
        (s) => s.id === currentStoryId
      );
      setCurrentStory(currentStory);
    }
  }, [currentStoryId, data]);

  const handleLanguageChange = (language) => {
    console.error("CHANGING LANGUAGE: ", language);
    setCurrentLanguage(language);
  };

  const handleKeywordSelect = (keyword) => {
    setCurrentKeyword(keyword);
  };

  const handleNextStory = () => {
    const _storyList = storyListRef.current;
    const _currentStoryId = currentStoryIdRef.current;
    const currentIndex = _storyList.findIndex(
      (story) => story.id === _currentStoryId
    );

    if (currentIndex < _storyList.length - 1) {
      // Check if not at the last story
      const nextIndex = currentIndex + 1;
      setCurrentStoryId(_storyList[nextIndex].id);
    }
  };

  const handlePreviousStory = () => {
    const _storyList = storyListRef.current;
    const _currentStoryId = currentStoryIdRef.current;
    const currentIndex = _storyList.findIndex(
      (story) => story.id === _currentStoryId
    );

    if (currentIndex > 0) {
      // Check if not at the first story
      const prevIndex = currentIndex - 1;
      setCurrentStoryId(_storyList[prevIndex].id);
    }
  };

  if (!data) {
    return <div>Loading...</div>;
  }

  return (
    <div className="App">
      <div className="SplitScreen">
        <div className="LeftPane">
          <StoryLine
            story={currentStory}
            currentLanguage={currentLanguage}
            currentKeyword={currentKeyword}
          />
          <VariationCoordinator
            data={data}
            currentStory={currentStory}
            currentLanguage={currentLanguage}
            currentKeyword={currentKeyword}
            onVariationUpdate={setCurrentVariation}
            updateKeywordCounters={handleKeywordCounters} // New callback
            updateCurrentKeywordCounter={handleCurrentKeywordCounter} // New callback
            onLanguageChange={handleLanguageChange}
            onTimeUpdate={(currentTime) => {
              setCurrentTime(currentTime);
            }}
          />
          {/* Legacy Version */}
          {/* <TextScroller data={data} languageName={currentLanguage} story={currentStory} currentKeyword={currentKeyword} /> */}
          <TextScroller
            currentVariation={currentVariation}
            currentKeywordCounter={currentKeywordCounter}
            currentKeyword={currentKeyword}
            currentLanguage={currentLanguage}
            currentTime={currentTime}
          />
          <LanguagePicker
            data={data}
            currentLanguage={currentLanguage}
            onLanguageChange={handleLanguageChange}
            currentKeyword={currentKeyword}
            onKeywordSelect={handleKeywordSelect}
            currentVariation={currentVariation}
            keywordCounters={keywordCounters} // Pass keyword counters
            currentKeywordCounter={currentKeywordCounter} // Pass current keyword counter
          />
        </div>
        <div className="RightPane">
          <div style={{ position: "relative", height: "6em" }}>
            <StoryNavigator
              onPrevious={handlePreviousStory}
              onNext={handleNextStory}
              storyList={storyList}
              currentStoryId={currentStoryId}
            />
            <AppHeader
              style={{ zIndex: 1 }}
              story={currentStory}
              currentLanguage={currentLanguage}
              currentKeyword={currentKeyword}
            />
          </div>
          <GraphViewer
            data={data}
            languageName={currentLanguage}
            story={currentStory}
            currentKeyword={currentKeyword}
          />
        </div>
      </div>
      <div></div>
      <div style={{marginTop: '3em', paddingTop: '3em'}}>
        <TextToSpeech currentStory={currentStory} charlieCounter={currentKeywordCounter} />
      </div>
    </div>
  );
}

export default App;
