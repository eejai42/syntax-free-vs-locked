// LanguagePicker.js
import React from 'react';

const LanguagePicker = ({ data, currentLanguage, onLanguageChange }) => {

  return (
    <div>
      <h3>Language Picker</h3>
      {data.story.languages.map((language, index) => (
        <button 
          key={index} 
          onClick={() => onLanguageChange(language.name)} 
          disabled={currentLanguage === language.name}
        >
          {language.name}
        </button>
      ))}
    </div>
  );
};

export default LanguagePicker;
