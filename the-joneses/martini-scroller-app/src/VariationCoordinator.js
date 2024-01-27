import { useState, useEffect } from "react";
const daysOfWeek = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];

const VariationCoordinator = ({
  data,
  currentStory,
  currentLanguage,
  currentKeyword,
  onVariationUpdate,
  updateCurrentKeywordCounter, 
  onTimeUpdate
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
    updateCurrentKeywordCounter(count)
  }, [currentKeyword, keywordCounters]);

  const updateVariations = () => {
    const languageData = currentStory.languages[currentLanguage];
    if (languageData) {
      const updatedVariations = languageData.variations.map((variationText) => {
        const prefix = getPrefixBeforeColon(variationText);
        const finalVariationText = `${getVariationTextAfterColon(variationText)}`.trim();
        const randomMethod = prefix ?? getRandomMethod(data);
        const highlightedText = highlightKeyword(
          finalVariationText,
          currentKeyword,
          data, 
          currentStory["line-through"]
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
            minHeight: languageData["min-height"] ?? null,
            maxHeight: languageData["max-height"] ?? null,
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
      
      if (dayOfWeekIndex < 5) { // Weekday
        businessDay += 1;
      } else if (dayOfWeekIndex === 5) { // Saturday
        calendarDay += 2; // Skip to Monday
        dayOfWeekIndex = 0;
      }

      onTimeUpdate({ // Assuming you want to send this data to App.js
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
    if (Math.random() < 0.5) { // 30% chance to advance a day
      advanceDay();
    }
  }

  function updateKeywordCounters(text) {
    const keywordText = getKeywordText(currentKeyword, data);
    const matches = text.match(new RegExp(keywordText, "gi")) || [];
    const count = matches.length;
    setKeywordCounters(prevCounters => ({
      ...prevCounters,
      [currentKeyword]: (prevCounters[currentKeyword] || 0) + count
    }));
    const totalKeywordCount = (keywordCounters[currentKeyword] || 0) + count;
    setCurrentKeywordCounter(totalKeywordCount);
    updateCurrentKeywordCounter(totalKeywordCount);
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

  const highlightKeyword = (text, keyword, data, lineThrough) => {
    const keywordText = getKeywordText(keyword, data);
    const highlightedText = text.replace(
      new RegExp(keywordText, "gi"),
      (match) => {
        setKeywordCounters((prevCounters) => {
          const currentCount = prevCounters[match]
            ? prevCounters[match] + 1
            : 1;
  
          // If the match is the current keyword, update the currentKeywordCounter
          if (match === currentKeyword) {
            setCurrentKeywordCounter(currentCount);
          }
  
          return { ...prevCounters, [match]: currentCount };
        });
  
        const replacementText = null //data.story.keywords.find(k => k.name === keyword)?.["replace-with"] || "";
        const crossedOutKeyword = lineThrough ? `<span class="staleKeyword">${match}</span>` : `<span class="highlightedKeyword">${match}</span>`;
        const replacementKeyword = lineThrough && replacementText ? `<span class="highlightedKeyword">${replacementText}</span>` : "";
  
        return `${crossedOutKeyword}${replacementKeyword}`;
      }
    );
    return highlightedText;
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
