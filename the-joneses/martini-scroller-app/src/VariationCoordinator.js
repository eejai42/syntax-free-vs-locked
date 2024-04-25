import { useState, useEffect } from "react";
const daysOfWeek = [
  "Monday",
  "Tuesday",
  "Wednesday",
  "Thursday",
  "Friday",
  "Saturday",
  "Sunday",
];

const VariationCoordinator = ({
  data,
  currentChapter,
  currentLanguage,
  onVariationUpdate,
  onTimeUpdate,
  onLanguageChange,
  handleKeywordCounters
}) => {

  
  const initializeKeywordCounters = () => {
    const counters = {};
    if (!data.story.keywords) return;
    console.error(data.story.keywords);
    data.story.keywords.forEach((keyword) => {
      const key = keyword.name.toLowerCase();
      counters[key] = {
        name: keyword.name,
        greek: keyword.greek,
        chinese: keyword.chinese,
        isStale: false,
        isHighlightable: true,
        lockedCount: 0,
        staleCount: 0
      };
    });
    return counters;
  };

  const [variations, setVariations] = useState([]);
  const [currentVariationIndex, setCurrentVariationIndex] = useState(0);
  const [keywordCounters, setKeywordCounters] = useState(initializeKeywordCounters());
  const [forceUpdate, setForceUpdate] = useState(0); // New state for forcing update

  const [timeState, setTimeState] = useState({
    calendarDay: 1,
    businessDay: 1,
    dayOfWeekIndex: 0, // 0 is Monday, 6 is Sunday
    dayOfWeekName: daysOfWeek[0],
  });

  useEffect(() => {
    if (currentChapter && data) {
      updateVariations();
    }
  }, [currentChapter?.id, currentLanguage, data]);

  useEffect(() => {
    handleKeywordCounters(keywordCounters);
  }, [keywordCounters]);
      

  const updateVariations = () => {
    const languageData = currentChapter?.languages[currentLanguage];
    if (languageData) {
      const updatedVariations = languageData.variations.map((variationText) => {
        const prefix = getPrefixBeforeColon(variationText);
        const finalVariationText = `${getVariationTextAfterColon(
          variationText
        )}`.trim();        
        const randomMethod = prefix ?? getRandomMethod(data);
        const highlightedText = highlightKeyword(finalVariationText);
        const refinedVariation = {
          title: randomMethod,
          text: finalVariationText,
          htmlText: highlightedText,
          language: currentLanguage,
          lineThrough: currentChapter["line-through"],
          style: {
            animationDuration: `${6000}ms`,
            fontSize: languageData["font-size"] ?? "1.5em",
            fontFamily: languageData["font-family"] ?? "sans-serif",
            textAlign: languageData["text-align"] ?? "center",
            minHeight: languageData["min-height"] ?? '10em',
            maxHeight: languageData["max-height"] ?? '15em',
          },
        };
        return refinedVariation;
      });
      if (currentChapter["start-language"] && (currentLanguage != 'English')) {
        onLanguageChange(currentChapter["start-language"]);
      }
      setVariations(updatedVariations);
      setCurrentVariationIndex(0);
    }
  };

  useEffect(() => {
    console.error('FORCING UPDATE: ', forceUpdate);
    updateVariations();
  }, [forceUpdate]);

  useEffect(() => {
    if (!currentChapter) return; // Exit if currentChapter is not defined
  
    const newCounters = { ...keywordCounters };
    const highlightableKeywords = new Set((currentChapter.keywords || []).map(keyword => keyword.toLowerCase())); // Normalize and create a Set for easier checking
    const staleKeywords = new Set((currentChapter.staleKeywords || []).map(keyword => keyword.toLowerCase())); // Normalize and create a Set for easier checking
  
    Object.entries(newCounters).forEach(([key, counter]) => {
      counter.isHighlightable = highlightableKeywords.has(key);
      counter.isStale = staleKeywords.has(key);
    });
  
    setKeywordCounters(newCounters); // Update the state with the modified counters
  }, [currentChapter]);

  useEffect(() => {
    setForceUpdate(prev => prev + 1); // Trigger a re-render
  }, [currentChapter]);
  

  useEffect(() => {
    let interval;
    const startInterval = () => {
      if (interval) return;
      interval = setInterval(() => {
        if (variations.length > 0) {
          emitVariation();
        }
      }, 1350);
    };

    const stopInterval = () => {
      clearInterval(interval);
      interval = null;
    };

    startInterval();

    const handleVisibilityChange = () => {
      if (document.visibilityState === "hidden") {
        stopInterval();
      } else {
        startInterval();
      }
    };

    document.addEventListener("visibilitychange", handleVisibilityChange);

    return () => {
      stopInterval();
      document.removeEventListener("visibilitychange", handleVisibilityChange);
    };
  }, [variations, currentVariationIndex, onVariationUpdate]);




  function advanceDay() {
    setTimeState((prevState) => {
      let { calendarDay, businessDay, dayOfWeekIndex } = prevState;

      calendarDay += 1;
      dayOfWeekIndex = (dayOfWeekIndex + 1) % 7;

      if (dayOfWeekIndex < 5) {
        // Weekday
        businessDay += 1;
      } else if (dayOfWeekIndex === 5) {
        // Saturday
        calendarDay += 2; // Skip to Monday
        dayOfWeekIndex = 0;
      }

      onTimeUpdate({
        // Assuming you want to send this data to App.js
        calendarDay,
        businessDay,
        dayOfWeekIndex,
        dayOfWeekName: daysOfWeek[dayOfWeekIndex],
      });

      return {
        calendarDay,
        businessDay,
        dayOfWeekIndex,
        dayOfWeekName: daysOfWeek[dayOfWeekIndex],
      };
    });
  }

  function emitVariation() {
    const variationToEmit = variations[currentVariationIndex];
    updateKeywordCounters(variationToEmit.text); // Update keyword counters based on the emitted variation
    onVariationUpdate(variationToEmit);
    const nextIndex = (currentVariationIndex + 1) % variations.length;
    setCurrentVariationIndex(nextIndex);
    if (Math.random() < 0.05) {
      // 30% chance to advance a day
      advanceDay();
    }
  }

  const updateKeywordCounters = (text) => {
    const newCounters = { ...keywordCounters };
    Object.entries(newCounters).forEach(([key, keyword]) => {
      // Extend to check for Greek and Chinese variations
      const namesToCheck = [keyword.name, keyword.greek, keyword.chinese].filter(Boolean); // Filter out any undefined or empty values
      let totalCount = 0;
      namesToCheck.forEach((name) => {
        const regex = new RegExp(name, "gi");
        const count = (text.match(regex) || []).length;
        totalCount += count;
      });
  
      if (totalCount > 0) {
        if (keyword.isStale) {
          keyword.staleCount += totalCount;
        } else {
          keyword.lockedCount += totalCount;
        }
      }
    });
    setKeywordCounters(newCounters);
  };
  
  const highlightKeyword = (text) => {
    Object.entries(keywordCounters).forEach(([key, keywordData]) => {
      if (keywordData.isHighlightable) {
        [keywordData.name, keywordData.greek, keywordData.chinese].filter(Boolean).forEach((name) => {
          const regex = new RegExp(name, "gi");
          text = text.replace(regex, (match) => {
            if (keywordData.isStale) {
              return `<span className="staleKeyword">${match}</span>`;
            } else {
              return `<span className="highlightedKeyword">${match}</span>`;
            }
          });
        });
      }
    });
    return text;
  };
  

  const getPrefixBeforeColon = (text) => {
    const colonIndex = text.indexOf(":");
    return colonIndex !== -1 ? text.substring(0, colonIndex) : undefined;
  };

  const getVariationTextAfterColon = (text) => {
    const colonIndex = text.indexOf(":");
    return colonIndex !== -1 ? text.substring(colonIndex + 1) : text;
  };

  const getRandomMethod = (data) => {
    const methods = data.story["communication-methods"];
    return methods[Math.floor(Math.random() * methods.length)];
  };

  
  return <div>
   {/* Variation Controller
    {Object.entries(keywordCounters).map((counter, index) => (
      <div key={index}>
          <div>{index}: {counter[0]} - {counter[1].name} - {counter[1].greek}** {counter[1].isStale} - {counter[1].lockedCount}</div>
      </div>
    ))}
     */}
    </div> // This component does not render anything itself
};

export default VariationCoordinator;
