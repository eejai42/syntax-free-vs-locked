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
  const [currentStoryId, setCurrentStoryId] = useState("meet-the-joneses");
  const [currentStory, setCurrentStory] = useState(null);
  const [storyList, setStoryList] = useState([]);
  const [currentTime, setCurrentTime] = useState([]);
  const [keywordCounters, setKeywordCounters] = useState({});
  const [currentVariation, setCurrentVariation] = useState(null);

  const currentStoryIdRef = useRef(currentStoryId);
  const storyListRef = useRef(storyList);

  // Function to handle the variation update from VariationCoordinator
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
        <div className="RightPane">
          <StoryLine
            story={currentStory}
            currentLanguage={currentLanguage}
          />
          <VariationCoordinator
            data={data}
            currentStory={currentStory}
            currentLanguage={currentLanguage}
            onVariationUpdate={setCurrentVariation}
            handleKeywordCounters={handleKeywordCounters} // New callback
            onLanguageChange={handleLanguageChange}
            onTimeUpdate={(currentTime) => {
              setCurrentTime(currentTime);
            }}
          />
          {/* Legacy Version */}
          {/* <TextScroller data={data} languageName={currentLanguage} story={currentStory} currentKeyword={currentKeyword} /> */}
          <img src="parchment.png" className="EraIcon" style={{left: 0, zIndex: 99999999999, marginTop: '3em', fontSize: '1.6em' }} />
          <TextScroller
            currentVariation={currentVariation}
            keywordCounters={keywordCounters}
            currentLanguage={currentLanguage}
            currentTime={currentTime}
          />
          <LanguagePicker
            data={data}
            currentLanguage={currentLanguage}
            onLanguageChange={handleLanguageChange}
            currentVariation={currentVariation}
            keywordCounters={keywordCounters} // Pass keyword counters
          />
        </div>
        <div className="LeftPane">
          <div style={{ position: "relative", height: "6em" }}>
            <AppHeader
              style={{ zIndex: 1 }}
              story={currentStory}
              currentLanguage={currentLanguage}
              keywordCounters={keywordCounters} // Pass keyword counters
            />
          </div>
          <GraphViewer
            data={data}
            languageName={currentLanguage}
            story={currentStory}
            keywordCounters={keywordCounters} // Pass keyword counters
          />
        </div>
      </div>
      <div></div>
      <div style={{position: 'relative', minHeight: '2em', zIndex: 10}}>
      <StoryNavigator
              onPrevious={handlePreviousStory}
              onNext={handleNextStory}
              storyList={storyList}
              currentStoryId={currentStoryId}
            />

      </div>
      <div style={{marginTop: '10em'}}>
        <TextToSpeech currentStory={currentStory} keywordCounters={keywordCounters} />
      </div>

    </div>
  );
}

export default App;
