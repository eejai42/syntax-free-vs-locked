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
  const [currentChapterId, setCurrentChapterId] = useState("meet-the-joneses");
  const [currentChapter, setCurrentChapter] = useState(null);
  const [chapterList, setChapterList] = useState([]);
  const [currentTime, setCurrentTime] = useState([]);
  const [keywordCounters, setKeywordCounters] = useState({});
  const [currentVariation, setCurrentVariation] = useState(null);

  const currentChapterIdRef = useRef(currentChapterId);
  const chapterListRef = useRef(chapterList);

  // Function to handle the variation update from VariationCoordinator
  const handleKeywordCounters = (counters) => {
    setKeywordCounters(counters);
  };

  // Update the ref whenever the state changes
  useEffect(() => {
    currentChapterIdRef.current = currentChapterId;
    chapterListRef.current = chapterList;
  }, [currentChapter]);

  // Function to handle key press
  const handleKeyPress = (event) => {
    if (event.keyCode === 37) {
      // Left arrow key
      handlePreviousChapter();
    } else if (event.keyCode === 39) {
      // Right arrow key
      handleNextChapter();
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
        setChapterList(data.story["chapters"]);
        const currentChapter = data.story["chapters"].find(
          (s) => s.id === currentChapterId
        );
        setCurrentChapter(currentChapter);
      })
      .catch((error) => {
        console.error("Error fetching data: ", error);
      });
  }, []);

  useEffect(() => {
    if (data) {
      const currentChapter = data.story["chapters"].find(
        (s) => s.id === currentChapterId
      );
      console.error("currentChapter", currentChapter);
      setCurrentChapter(currentChapter);
    }
  }, [currentChapterId, data]);

  const handleLanguageChange = (language) => {
    console.error("CHANGING LANGUAGE: ", language);
    setCurrentLanguage(language);
  };

  const handleNextChapter = () => {
    const _chapterList = chapterListRef.current;
    const _currentChapterId = currentChapterIdRef.current;
    const currentIndex = _chapterList.findIndex(
      (chapter) => chapter.id === _currentChapterId
    );

    if (currentIndex < _chapterList.length - 1) {
      // Check if not at the last story
      const nextIndex = currentIndex + 1;
      setCurrentChapterId(_chapterList[nextIndex].id);
    }
  };

  const handlePreviousChapter = () => {
    const _chapterList = chapterListRef.current;
    const _currentChapterId = currentChapterIdRef.current;
    const currentIndex = _chapterList.findIndex(
      (chapter) => chapter.id === _currentChapterId
    );

    if (currentIndex > 0) {
      // Check if not at the first story
      const prevIndex = currentIndex - 1;
      setCurrentChapterId(_chapterList[prevIndex].id);
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
            story={currentChapter}
            currentLanguage={currentLanguage}
          />
          <VariationCoordinator
            data={data}
            currentChapter={currentChapter}
            currentLanguage={currentLanguage}
            onVariationUpdate={setCurrentVariation}
            handleKeywordCounters={handleKeywordCounters} // New callback
            onLanguageChange={handleLanguageChange}
            onTimeUpdate={(currentTime) => {
              setCurrentTime(currentTime);
            }}
          />
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
              story={currentChapter}
              currentLanguage={currentLanguage}
              keywordCounters={keywordCounters} // Pass keyword counters
            />
          </div>
          <GraphViewer
            data={data}
            languageName={currentLanguage}
            story={currentChapter}
            keywordCounters={keywordCounters} // Pass keyword counters
          />
        </div>
      </div>
      <div></div>
      <div style={{position: 'relative', minHeight: '2em', zIndex: 10}}>
      <StoryNavigator
              onPrevious={handlePreviousChapter}
              onNext={handleNextChapter}
              chapterList={chapterList}
              currentChapterId={currentChapterId}
            />

      </div>
      <div style={{marginTop: '10em'}}>
        <TextToSpeech currentChapter={currentChapter} keywordCounters={keywordCounters} />
      </div>

    </div>
  );
}

export default App;
