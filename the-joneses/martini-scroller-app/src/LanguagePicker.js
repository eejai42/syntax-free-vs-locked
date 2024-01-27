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
    {
      if (currentLanguage === "Greek") return keyword.greek;
      else if (currentLanguage == "Chinese") return keyword.chinese;
      else return keyword.name;
    }
  };
  return (
    <div style={{ padding: "1em" }}>
      <div>
        {data.story.languages.map((language, index) => (          
          <button
            className={`btn btn-${language.name}`.toLowerCase()}
            key={index}
            onClick={() => onLanguageChange(language.name)}
            disabled={currentLanguage === language.name}
          >
            {language.name}
          </button>
        ))}
      </div>
      <div style={{padding: '0.5em'}}>
        {data.story.keywords
          .flatMap((keyword) => keyword)
          .map((keyword, index) => (
            <button
              className={`btn btn-primary`}
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
