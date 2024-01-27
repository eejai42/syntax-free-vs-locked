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
  currentStory,
  currentLanguage,
  currentKeyword,
  onVariationUpdate,
  updateCurrentKeywordCounter,
  onTimeUpdate,
}) => {
  const [variations, setVariations] = useState([]);
  const [currentVariationIndex, setCurrentVariationIndex] = useState(0);
  const [keywordCounters, setKeywordCounters] = useState({}); // Global keyword counters
  const [currentKeywordCounter, setCurrentKeywordCounter] = useState(0);

  const [timeState, setTimeState] = useState({
    calendarDay: 1,
    businessDay: 1,
    dayOfWeekIndex: 0, // 0 is Monday, 6 is Sunday
    dayOfWeekName: daysOfWeek[0],
  });

  useEffect(() => {
    if (currentStory && data) {
      updateVariations();
    }
  }, [currentStory?.id, currentLanguage, currentKeyword, data]);

  useEffect(() => {
    // Update the currentKeywordCounter based on the current keyword
    const count = keywordCounters[currentKeyword] || 0;
    setCurrentKeywordCounter(count);
    updateCurrentKeywordCounter(count);
  }, [currentKeyword, keywordCounters]);

  const updateVariations = () => {
    const languageData = currentStory.languages[currentLanguage];
    if (languageData) {
      const updatedVariations = languageData.variations.map((variationText) => {
        const prefix = getPrefixBeforeColon(variationText);
        const finalVariationText = `${getVariationTextAfterColon(
          variationText
        )}`.trim();
        const randomMethod = prefix ?? getRandomMethod(data);
        const highlightedText = highlightKeyword(
          finalVariationText,
          currentKeyword,
          data,
          currentStory["line-through"],
          false // Do not update counters during initial setup
        );
        const refinedVariation = {
          title: randomMethod,
          text: finalVariationText,
          htmlText: highlightedText,
          language: currentLanguage,
          lineThrough: currentStory["line-through"],
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
      setVariations(updatedVariations);
      setCurrentVariationIndex(0);
    }
  };

  useEffect(() => {
    let interval;
    const startInterval = () => {
      if (interval) return;
      interval = setInterval(() => {
        if (variations.length > 0) {
          emitVariation();
        }
      }, 1500);
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
    if (Math.random() < 0.15) {
      // 30% chance to advance a day
      advanceDay();
    }
  }

  function updateKeywordCounters(text) {
    const keywordText = getKeywordText(currentKeyword, data);
    const matches = text.match(new RegExp(keywordText, "gi")) || [];
    const count = matches.length;
    console.error(
      "KEYWORD Counters:",
      keywordCounters,
      "TEXT",
      text,
      "KEYWORD",
      currentKeyword,
      "COUNT",
      count
    );
    setKeywordCounters((prevCounters) => ({
      ...prevCounters,
      [currentKeyword]: (prevCounters[currentKeyword] || 0) + count,
    }));
    const totalKeywordCount = (keywordCounters[currentKeyword] || 0) + count;
    setCurrentKeywordCounter(totalKeywordCount);
    updateCurrentKeywordCounter(totalKeywordCount);
    console.error(
      "Setting CurrentKeywordCounter and Updating the current keyword count: ",
      totalKeywordCount,
      "TEXT",
      text
    );
  }

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

  const highlightKeyword = (text, keyword, data, lineThrough, updateCounter = true) => {
    const keywordText = getKeywordText(keyword, data);
    let lineThroughKeywords = [];
    let highlightKeywords = [];
  
    if (lineThrough && lineThrough.length > 0) {
      lineThrough.forEach(item => {
        const [lineThroughWord, highlightWord] = item.split(':');
        if (lineThroughWord) {
          lineThroughKeywords.push(lineThroughWord);
        }
        if (highlightWord) {
          highlightKeywords.push(highlightWord);
        }
      });
    } else {
      highlightKeywords = [keywordText]; // No line-through, only highlighting
    }
  
    // Process line-through keywords
    lineThroughKeywords.forEach(ltKeyword => {
      text = text.replace(new RegExp(ltKeyword, "gi"), `<span class="staleKeyword">${ltKeyword}</span>`);
    });
  
    // Process highlight keywords
    return text.replace(new RegExp(highlightKeywords.join("|"), "gi"), (match) => {
      if (updateCounter) {
        setKeywordCounters((prevCounters) => {
          const currentCount = prevCounters[match] ? prevCounters[match] + 1 : 1;
          if (match === currentKeyword) {
            setCurrentKeywordCounter(currentCount);
          }
          return { ...prevCounters, [match]: currentCount };
        });
      }
      return `<span class="highlightedKeyword">${match}</span>`;
    });
  };
  
  

  const getKeywordText = (keywordName, data) => {
    const keywords = data.story.keywords;
    const keyword = keywords.find((k) => k.name === keywordName);
    if (!keyword) return keywordName;
    return currentLanguage === "Greek"
      ? keyword.greek
      : currentLanguage === "Chinese"
      ? keyword.chinese
      : keyword.name;
  };

  return null; // This component does not render anything itself
};

export default VariationCoordinator;
