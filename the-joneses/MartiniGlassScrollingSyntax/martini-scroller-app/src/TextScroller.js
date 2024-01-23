import React, { useState, useEffect } from 'react';

const TextScroller = ({ data, languageName, currentKeyword, story }) => {
  const [activeVariationIndices, setActiveVariationIndices] = useState([0, 1, 2]);
  const [variations, setVariations] = useState([]);
  const totalVariations = variations.length;
  const scrollSpeed = 10000; // Duration of each scroll, e.g., 10 seconds
  const staggerDuration = scrollSpeed / 4; // Stagger duration for starting next variation

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
  
      if (index < array.length - 1) { // Don't add keyword after the last part
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
      {variations.map((variation, index) => (
        <p key={index} className={`TextScroller ${activeVariationIndices.includes(index) ? 'active' : ''}`} style={{animationDuration: `${scrollSpeed}ms`}}>
          {highlightKeyword(variation, currentKeyword)}
        </p>
      ))}
    </div>
  );
};

export default TextScroller;
