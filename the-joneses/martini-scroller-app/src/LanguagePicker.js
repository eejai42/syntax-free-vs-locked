import React from "react";

const LanguagePicker = ({
  data,
  currentChapter,
  currentLanguage,
  onLanguageChange
}) => {

  return (
    <div style={{ padding: "1em", marginTop: '2.5em' }}>
      <div>
        {data.story.languages.filter(language => currentChapter?.visibleLanguages.includes(language.name)).map((language, index) => (
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
