// LanguagePicker.js
import React from "react";

const LanguagePicker = ({
  data,
  currentLanguage,
  onLanguageChange
}) => {
  const getKeywordText = (keyword) => {
    {
      if (currentLanguage === "Greek") return keyword.greek;
      else if (currentLanguage == "Chinese") return keyword.chinese;
      else return keyword.name;
    }
  };
  return (
    <div style={{ padding: "1em", marginTop: '2.5em' }}>
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
    </div>
  );
};

export default LanguagePicker;
