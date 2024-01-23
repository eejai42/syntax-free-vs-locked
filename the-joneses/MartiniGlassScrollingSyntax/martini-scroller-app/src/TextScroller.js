import React, { useState, useEffect } from 'react';

const TextScroller = ({ data, languageName, currentKeyword, story }) => {
  const [currentVariationIndex, setCurrentVariationIndex] = useState(0);
  const [variations, setVariations] = useState([]);
  const totalVariations = variations.length;
  const scrollSpeed = 10000; // Duration of each scroll, e.g., 10 seconds
  const overlapDuration = 5000; // Time after which next variation starts, e.g., 5 seconds

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
      const interval = setInterval(() => {
        setCurrentVariationIndex(currentIndex => 
          (currentIndex + 1) % totalVariations
        );
      }, overlapDuration); // Start next variation after 2 seconds
  
      return () => clearInterval(interval);
    }
  }, [totalVariations, overlapDuration]);

  const highlightKeyword = (text, keyword) => {
    const regex = new RegExp(`(${keyword})`, 'gi');
    return text.split(regex).map((part, index) => 
      part.toLowerCase() === keyword.toLowerCase() ? 
      <span key={index} style={{ fontWeight: 'bold', backgroundColor: 'yellow' }}>{part}</span> : 
      part
    );
  };

  return (
    <div className="FullHeightContainer">
      {variations.map((variation, index) => (
        <p key={index} className={`TextScroller ${index === currentVariationIndex ? 'active' : ''}`} style={{animationDuration: `${scrollSpeed}ms`}}>
          {highlightKeyword(variation, currentKeyword)}
        </p>
      ))}
    </div>
  );
};

export default TextScroller;
