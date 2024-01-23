import React, { useState, useEffect } from 'react';

const TextScroller = ({ data, languageName, storyId }) => {
  const [currentVariationIndex, setCurrentVariationIndex] = useState(0);
  const [variations, setVariations] = useState([]);
  const [keywords, setKeywords] = useState([]);

  const scrollSpeed = 3000; // Adjust this value for different scroll speeds

  useEffect(() => {
    // Find the matching story and language
    const story = data.story["syntax-locked-vs-unlocked"].find(s => s.id === storyId);
    if (story) {
      const languageVariations = story.languages[languageName.toLowerCase()];
      if (languageVariations) {
        setVariations(languageVariations.variations);
        const languageKeywords = data.story.languages.find(lang => lang.name.toLowerCase() === languageName.toLowerCase());
        if (languageKeywords) {
          setKeywords(languageKeywords.keywords);
        }
      }
    }
  }, [data, languageName, storyId]);

  useEffect(() => {
    const interval = setInterval(() => {
      setCurrentVariationIndex(currentIndex => 
        (currentIndex + 1) % variations.length
      );
    }, scrollSpeed);

    return () => clearInterval(interval);
  }, [variations, scrollSpeed]);

  return (
    <div className="TextScroller">
      <p>{variations[currentVariationIndex]}</p>
    </div>
  );
};

export default TextScroller;
