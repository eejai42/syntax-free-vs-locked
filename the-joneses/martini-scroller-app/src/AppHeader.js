// LanguagePicker.js
import React from "react";
import StoryNavigator from "./StoryNavigator";

const AppHeader = ({
    languageName, 
    currentKeyword,
    story
}) => {
    
    const nameStyle  = {
        padding: "0.25em",
        marginTop: "0",
        marginBottom: "-1em",
        fontSize: '2em',
        fontWeight: 'bold',
        maxWidth: '50vw',
        minWidth: '50vw'        

    }

  return (
    <div style={{padding: '0.25em', position: 'relative', minHeight: "5em"}}>
        <div style={nameStyle}>{story.name}</div>
        <div style={{clear: 'both'}}></div>
    </div>
  );
};

export default AppHeader;
