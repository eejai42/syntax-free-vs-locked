// LanguagePicker.js
import React from "react";

const AppHeader = ({
    languageName, 
    currentKeyword,
    story
}) => {
    const headerStyle = {
        marginTop: "0",
        marginBottom: "0",
    }
  return (
    <div>
        <h1 style={headerStyle}>{story.name}</h1>
        <h3 style={headerStyle}>{story.statement}</h3>
    </div>
  );
};

export default AppHeader;
