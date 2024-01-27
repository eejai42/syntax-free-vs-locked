// LanguagePicker.js
import React from "react";

const StoryLine = ({
    languageName, 
    currentKeyword,
    story
}) => {
    

    const statementStyle = {
        marginTop: "0",
        marginBottom: "0",
        width: '100%',
        fontSize: '1.4em',
        textAlign: 'center',
    }

  return (
    <div style={{padding: '0.25em', position: 'relative', minHeight: "5em"}}>
        <div style={statementStyle}>{story.statement}</div>
        <div style={{clear: 'both'}}></div>
    </div>
  );
};

export default StoryLine;
