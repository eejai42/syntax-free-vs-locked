import React, { useState, useEffect } from 'react';

const TextScroller = ({ data, languageName, currentKeyword, story }) => {
  const [activeVariationIndices, setActiveVariationIndices] = useState([0, 1, 2]);
  const [variations, setVariations] = useState([]);
  const totalVariations = variations.length;
  const scrollSpeed = 8000; // Duration of each scroll, e.g., 10 seconds
  const staggerDuration = scrollSpeed / 4; // Stagger duration for starting next variation
  const [keywordCounts, setKeywordCounts] = useState({});

  

  useEffect(() => {
    if (story) {
      const languageVariations = story.languages[languageName];
      if (languageVariations) {
        setVariations(languageVariations.variations);
      }
    }
  }, [data, languageName, story]);

  useEffect(() => {
    if (totalVariations > 0) {
      // Introduce the second and third variations with a delay
      const timeouts = [
        setTimeout(() => setActiveVariationIndices([0, 1, -1]), staggerDuration),
        setTimeout(() => setActiveVariationIndices([0, 1, 2]), staggerDuration * 2),
      ];
  
      const interval = setInterval(() => {
        setActiveVariationIndices(currentIndices => 
          currentIndices.map(index => (index + 1) % totalVariations)
        );
      }, staggerDuration);
  
      return () => {
        clearInterval(interval);
        timeouts.forEach(clearTimeout);
      };
    }
  }, [totalVariations, staggerDuration]);

  const updateKeywordCount = (newIndex) => {
    // Check if newIndex is a valid index in the variations array
    if (newIndex >= 0 && newIndex < variations.length) {
      const keywordText = getKeywordText(currentKeyword);
      const variation = variations[newIndex];
      const matches = (variation.match(new RegExp(keywordText, 'gi')) || []).length;
  
      setKeywordCounts(prevCounts => ({
        ...prevCounts,
        [currentKeyword]: (prevCounts[currentKeyword] || 0) + matches
      }));
    }
  };
  

  useEffect(() => {
    // Get the most recently added index
    const mostRecentIndex = activeVariationIndices[activeVariationIndices.length - 1];
    updateKeywordCount(mostRecentIndex);
  }, [activeVariationIndices, currentKeyword]);

  const getKeywordText = (keywordName) => {
    const keywords = data.story.keywords;
    const keyword = keywords.find(k => k.name === keywordName);
    console.error('Checking: ', keyword.name, "in ", languageName, "greek", keyword.greek, "chinese", keyword.chinese);
    {if (languageName === 'Greek') return keyword.greek;
    else if (languageName == 'Chinese') return keyword.chinese
    else return keyword.name}
  }

 const highlightKeyword = (text, keywordName) => {
    const keywords = data.story.keywords;
    const keyword = keywords.find(k => k.name === keywordName);
    const keywordText = getKeywordText(keyword.name);
  
    console.error('HIGHLIGHTING ');

    let highlightedText = [];
    let lastIndex = 0;

    text.split(keywordText).forEach((part, index, array) => {
      highlightedText.push(part);

      if (index < array.length - 1) {
        highlightedText.push(
          <span key={index} style={{ fontWeight: 'bold', backgroundColor: 'yellow' }}>
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
      <div>
        {currentKeyword} Counter: {keywordCounts[currentKeyword] || 0}
      </div>
      {variations.map((variation, index) => (
        <p key={index} className={`TextScroller ${activeVariationIndices.includes(index) ? 'active' : ''}`} style={{animationDuration: `${scrollSpeed}ms`, minHeight: '4em'}}>
          {highlightKeyword(variation, currentKeyword)}
        </p>
      ))}
    </div>
  );
};

export default TextScroller;
