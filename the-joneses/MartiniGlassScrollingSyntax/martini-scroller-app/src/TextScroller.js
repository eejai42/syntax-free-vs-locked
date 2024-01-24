import React, { useState, useEffect } from "react";

const TextScroller = ({ data, languageName, currentKeyword, story }) => {
  const [activeVariationIndices, setActiveVariationIndices] = useState([
    0, 1, 2, 3
  ]);
  //const [variations, setVariations] = useState([]);
  const [variationsWithPrefix, setVariationsWithPrefix] = useState([]);
  const totalVariations = variationsWithPrefix.length;
  const scrollSpeed = 6000; // Duration of each scroll, e.g., 10 seconds
  const staggerDuration = scrollSpeed / 4; // Stagger duration for starting next variation
  const [keywordCounts, setKeywordCounts] = useState({});
 
  useEffect(() => {
    if (story) {
      const language = story.languages[languageName];
      if (language) {
        // Assign a random communication method to each variation
        const updatedVariations = language.variations.map(variationText => {
          const prefix = getPrefixBeforeColon(variationText); 
          const finalVariationText = getVariationTextAfterColon(variationText);  
          const randomMethod = prefix === undefined ? data.story['communication-methods'][Math.floor(Math.random() * data.story['communication-methods'].length)] : prefix;
          console.error('FINDING METHOD ---------', language, language.variations, "VARIATION TEXT: ", finalVariationText, 'RANDOM METHOD: ', randomMethod)
  
          return { 
            text: finalVariationText, 
            method: randomMethod,
            ...language
          };
        });
        console.error('assigning variations with prefixes now')
        setVariationsWithPrefix(updatedVariations);
      }
    }
  }, [data, languageName, story]);
  

  useEffect(() => {
    if (totalVariations > 0) {
      // Introduce the second and third variations with a delay
      const timeouts = [
        setTimeout(
          () => setActiveVariationIndices([0, 1, -1]),
          staggerDuration
        ),
        setTimeout(
          () => setActiveVariationIndices([0, 1, 2]),
          staggerDuration * 2
        ),
      ];

      const interval = setInterval(() => {
        setActiveVariationIndices((currentIndices) =>
          currentIndices.map((index) => (index + 1) % totalVariations)
        );
      }, staggerDuration);

      return () => {
        clearInterval(interval);
        timeouts.forEach(clearTimeout);
      };
    }
  }, [totalVariations, staggerDuration]);

  const getPrefixBeforeColon = (variationText) => {
    const colonIndex = `${variationText}`.indexOf(':');
    if (colonIndex == -1) return undefined;
    else return variationText.substring(0, colonIndex);
  }

  const getVariationTextAfterColon = (variationText) =>  {
    const colonIndex = `${variationText}`.indexOf(':');
    if (colonIndex == -1) return variationText;
    else return variationText.substring(colonIndex + 1);
  }

  const updateKeywordCount = (newIndex) => {
    // Check if newIndex is a valid index in the variations array
    if (newIndex >= 0 && newIndex < variationsWithPrefix.length) {
      const keywordText = getKeywordText(currentKeyword);
      const variation = variationsWithPrefix[newIndex];
      const matches = (`${variation.text}`.match(new RegExp(keywordText, "gi")) || [])
        .length;

      setKeywordCounts((prevCounts) => ({
        ...prevCounts,
        [currentKeyword]: (prevCounts[currentKeyword] || 0) + matches,
      }));
    }
  };

  useEffect(() => {
    // Get the most recently added index
    const mostRecentIndex =
      activeVariationIndices[activeVariationIndices.length - 1];
    updateKeywordCount(mostRecentIndex);
  }, [activeVariationIndices, currentKeyword]);

  const getKeywordText = (keywordName) => {
    const keywords = data.story.keywords;
    const keyword = keywords.find((k) => k.name === keywordName);    

    if (languageName === "Greek") return keyword.greek;
    else if (languageName == "Chinese") return keyword.chinese;
    else return keyword.name;

  };

  const addPrefix = (randomMethod, text) => {  
    return <span><b>{randomMethod}:</b> <em>...{text}...</em></span>
  };
  
  const highlightKeyword = (text, keywordName) => {
    const keywords = data.story.keywords;
    const keyword = keywords.find((k) => k.name === keywordName);
    const keywordText = getKeywordText(keyword.name);

    let highlightedText = [];
    let lastIndex = 0;

    `${text}`.split(keywordText).forEach((part, index, array) => {
      highlightedText.push(part);

      if (index < array.length - 1) {
        highlightedText.push(
          <span
            key={index}
            style={{ fontWeight: "bold", backgroundColor: "yellow" }}
          >
            {keywordText}
          </span>
        );
      }

      lastIndex += part.length + keywordText.length;
    });

    return <span>{highlightedText}</span>;
  };

  return (
    <div className="FullHeightContainer">
      <div className="CharlieCounter">
        {currentKeyword} Counter: {keywordCounts[currentKeyword] || 0}
      </div>
      {variationsWithPrefix.map((variation, index) => (
        <div>
            <p
              key={index}
              className={`TextScroller ${activeVariationIndices.includes(index) ? "active" : ""}`}
              style={{
                position: "absolute",
                whiteSpace: "pre-wrap",
                animationDuration: `${scrollSpeed}ms`,
                minHeight: "10em",
                zIndex: 1,
                fontSize: variation['font-size'] ?? '1.5em',
                fontFamily: variation['font-family'] ?? 'sans-serif',
                textAlign: variation['text-align'] ?? 'center',
                minHeight: variation['min-height'] ?? '10em',
                maxHeight: variation['max-height'] ?? '10em',
              }}
            >
              {addPrefix(variation.method, highlightKeyword(variation.text, currentKeyword))}
            </p>
        </div>
      ))}
    </div>
  );
};

export default TextScroller;
