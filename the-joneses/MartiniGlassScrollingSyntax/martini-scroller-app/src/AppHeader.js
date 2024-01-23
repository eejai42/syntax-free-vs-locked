// LanguagePicker.js
import React from "react";

const AppHeader = ({
    languageName, 
    currentKeyword,
    story
}) => {
  return (
    <div>
        <h1>{story.name}</h1>
        <h3>{story.statement}</h3>
    </div>
  );
};

export default AppHeader;
