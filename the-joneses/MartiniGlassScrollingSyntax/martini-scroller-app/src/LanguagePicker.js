// LanguagePicker.js
import React from "react";

const LanguagePicker = ({
  data,
  currentLanguage,
  onLanguageChange,
  currentKeyword,
  onKeywordSelect,
}) => {
  return (
    <div>
      {data.story.languages.map((language, index) => (
        <button
          key={index}
          onClick={() => onLanguageChange(language.name)}
          disabled={currentLanguage === language.name}
        >
          {language.name}
        </button>
      ))}

      <div>
        {data.story.languages
          .filter((language) => currentLanguage === language.name)
          .flatMap((language) => language.keywords)
          .map((keyword, index) => (
            <button
              key={index}
              onClick={() => onKeywordSelect(keyword)}
              disabled={currentKeyword === keyword}
            >
              {keyword}
            </button>
          ))}
      </div>
    </div>
  );
};

export default LanguagePicker;
