// LanguagePicker.js
import React from "react";

const LanguagePicker = ({
  data,
  currentLanguage,
  onLanguageChange,
  currentKeyword,
  onKeywordSelect,
}) => {

  const getKeywordText = (keyword) => {
    {if (currentLanguage === 'Greek') return keyword.greek;
    else if (currentLanguage == 'Chinese') return keyword.chinese
    else return keyword.name}
  }
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
        {data.story.keywords
          .flatMap((keyword) => keyword)
          .map((keyword, index) => (
            <button
              key={index}
              onClick={() => onKeywordSelect(keyword.name)}
              disabled={currentKeyword === keyword.name}
            >
              {getKeywordText(keyword)}
            </button>
          ))}
      </div>
    </div>
  );
};

export default LanguagePicker;
