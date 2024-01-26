import React, { useState, useEffect, useRef } from "react";
import "./App.css";
import GraphViewer from "./GraphViewer";
import TextScroller2 from "./TextScroller2";
import LanguagePicker from "./LanguagePicker";
import StoryNavigator from "./StoryNavigator";
import AppHeader from "./AppHeader";
import VariationCoordinator from "./VariationCoordinator";
function App() {
  const [data, setData] = useState(null);
  const [currentLanguage, setCurrentLanguage] = useState("English");
  const [currentKeyword, setCurrentKeyword] = useState("Charlie");
  const [currentStoryId, setCurrentStoryId] = useState("meet-the-joneses");
  const [currentStory, setCurrentStory] = useState(null);
  const [storyList, setStoryList] = useState([]);

  const currentStoryIdRef = useRef(currentStoryId);
  const storyListRef = useRef(storyList);

  const [currentVariation, setCurrentVariation] = useState(null);

  // Function to handle the variation update from VariationCoordinator
  const handleCurrentVariation = (variation) => {
    setCurrentVariation(variation);
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
    //    fetch('https://raw.githubusercontent.com/eejai42/syntax-free-vs-locked/master/the-joneses/martini-scroller-app/public/data.json')
    fetch("data.json")
      .then((response) => response.json())
      .then((data) => {
        setData(data);
        setStoryList(data.story["syntax-locked-vs-unlocked"]);
        const currentStory = data.story["syntax-locked-vs-unlocked"].find(
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
      const currentStory = data.story["syntax-locked-vs-unlocked"].find(
        (s) => s.id === currentStoryId
      );
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
      <AppHeader
        story={currentStory}
        currentLanguage={currentLanguage}
        currentKeyword={currentKeyword}
      />
      <div>
        <StoryNavigator
          onPrevious={handlePreviousStory}
          onNext={handleNextStory}
          storyList={storyList}
          currentStoryId={currentStoryId}
        />
      </div>
      <div className="SplitScreen">
        <div className="RightPane">
          <GraphViewer
            data={data}
            languageName={currentLanguage}
            story={currentStory}
            currentKeyword={currentKeyword}
          />
        </div>
        <div className="LeftPane">
          <VariationCoordinator
            data={data}
            currentStory={currentStory}
            currentLanguage={currentLanguage}
            currentKeyword={currentKeyword}
            onVariationUpdate={setCurrentVariation}
          />
          {/* Legacy Version */}
          {/* <TextScroller data={data} languageName={currentLanguage} story={currentStory} currentKeyword={currentKeyword} /> */}
          <TextScroller2 currentVariation={currentVariation} /> // pass the
          current variation to TextScroller
          <LanguagePicker
            data={data}
            currentLanguage={currentLanguage}
            onLanguageChange={handleLanguageChange}
            currentKeyword={currentKeyword}
            onKeywordSelect={handleKeywordSelect}
          />
        </div>
      </div>
    </div>
  );
}

export default App;
