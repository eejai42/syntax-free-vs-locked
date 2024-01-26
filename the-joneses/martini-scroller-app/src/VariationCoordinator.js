import React, { useEffect, useState } from 'react';

const VariationCoordinator = ({ data, currentStory, currentLanguage, currentKeyword, onVariationUpdate }) => {
  const [variations, setVariations] = useState([]);
  const [currentVariationIndex, setCurrentVariationIndex] = useState(0);

  // Generate and update variations when dependencies change
  useEffect(() => {
    if (currentStory && data) {
      updateVariations();
    }
  }, [currentStory?.id, currentLanguage, currentKeyword, data]); // Using currentStory.id for a more explicit dependency check

  // Function to update variations
  const updateVariations = () => {
    const languageData = currentStory.languages[currentLanguage];
    console.error('UPDATED Variations.', languageData, currentLanguage, currentStory, currentKeyword, data)
    if (languageData) {
      const updatedVariations = languageData.variations.map(variationText => {
        const prefix = getPrefixBeforeColon(variationText);
        const finalVariationText = getVariationTextAfterColon(variationText);
        const randomMethod = prefix ?? getRandomMethod(data);
      
        return {
          title: randomMethod,
          text: finalVariationText, // Plain text
          htmlText: highlightKeyword(finalVariationText, currentKeyword, data), // HTML highlighted text
        };
      });        
      setVariations(updatedVariations);
      setCurrentVariationIndex(0); // Reset the variation index
    }
  };

  // Emit a single variation every N seconds
  useEffect(() => {
    const interval = setInterval(() => {
      if (variations.length > 0) {
        const variationToEmit = variations[currentVariationIndex];
        onVariationUpdate(variationToEmit);
        const nextIndex = (currentVariationIndex + 1) % variations.length;
        setCurrentVariationIndex(nextIndex);
      }
    }, 2000); // N seconds

    return () => clearInterval(interval);
  }, [variations, currentVariationIndex, onVariationUpdate]);


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

  const highlightKeyword = (text, keyword, data) => {
    const keywordText = getKeywordText(keyword, data);
    return text.replace(new RegExp(keywordText, 'gi'), `<span style="font-weight:bold;background-color:yellow;">${keywordText}</span>`);
  };

  const getKeywordText = (keywordName, data) => {
    const keywords = data.story.keywords;
    const keyword = keywords.find(k => k.name === keywordName);
    if (!keyword) return keywordName;
    return currentLanguage === 'Greek' ? keyword.greek : currentLanguage === 'Chinese' ? keyword.chinese : keyword.name;
  };

  return null; // This component does not render anything itself
};

export default VariationCoordinator;
