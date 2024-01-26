import { useState, useEffect } from "react";

const VariationCoordinator = ({
  data,
  currentStory,
  currentLanguage,
  currentKeyword,
  onVariationUpdate,
}) => {
  const [variations, setVariations] = useState([]);
  const [currentVariationIndex, setCurrentVariationIndex] = useState(0);
  const [keywordCounters, setKeywordCounters] = useState({}); // Global keyword counters
  const [currentKeywordCounter, setCurrentKeywordCounter] = useState(0);

  useEffect(() => {
    if (currentStory && data) {
      updateVariations();
    }
  }, [currentStory?.id, currentLanguage, currentKeyword, data]);

  useEffect(() => {
    // Update the currentKeywordCounter based on the current keyword
    setCurrentKeywordCounter(keywordCounters[currentKeyword] || 0);
  }, [currentKeyword, keywordCounters]);

  const updateVariations = () => {
    const languageData = currentStory.languages[currentLanguage];
    console.error(
      "UPDATED Variations.",
      languageData,
      currentLanguage,
      currentStory,
      currentKeyword,
      data
    );
    if (languageData) {
      const updatedVariations = languageData.variations.map((variationText) => {
        const prefix = getPrefixBeforeColon(variationText);
        const finalVariationText = `${getVariationTextAfterColon(variationText)}`.trim();
        const randomMethod = prefix ?? getRandomMethod(data);
        console.error("UPDATED randomMethod.", randomMethod, variationText, data.story.keywords);
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
        console.error("UPDATED refinedVariation.", currentStory, refinedVariation);
        return refinedVariation;
      });
      setVariations(updatedVariations);
      setCurrentVariationIndex(0);
    }
  };
  useEffect(() => {
    const interval = setInterval(() => {
      if (variations.length > 0) {
        emitVariation();
      }
    }, 1500);

    return () => clearInterval(interval);
  }, [variations, currentVariationIndex, onVariationUpdate]);

  function emitVariation() {
    const variationToEmit = variations[currentVariationIndex];
    onVariationUpdate(variationToEmit);
    const nextIndex = (currentVariationIndex + 1) % variations.length;
    setCurrentVariationIndex(nextIndex);
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
    console.error("COMMUNICATIOn METHODS --------------------", methods);
    return methods[Math.floor(Math.random() * methods.length)];
  };

  const highlightKeyword = (text, keyword, data, lineThrough) => {
    console.error("UPDATED highlightKeyword.", text, "Keyword", keyword, "Data",  data, "Line Through: ", currentStory.lineThrough);
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
  
        const styleClass = lineThrough ? "staleKeyword" : "highlightedKeyword";
        return `<span class="${styleClass}">${match}</span>`;
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
