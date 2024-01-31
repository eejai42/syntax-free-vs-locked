// LanguagePicker.js
import React from "react";

const AppHeader = ({
    languageName, 
    currentKeyword,
    story
}) => {
    
    const nameStyle  = {
        padding: "0.25em",
        fontSize: '2em',
        fontWeight: 'bold',
        maxWidth: '50%',
        minWidth: '50vh',
        marginTop: "0",
        marginBottom: "-1em",
        marginLeft: '20vh',
        marginRight: '20%',
        textAlign: 'center',
    }

  return (
    <div style={{ 
        padding: '0.25em', 
        position: 'absolute', 
        top: 0, 
        left: 0, 
        right: 0}}>
        <div style={nameStyle}>{story.name}</div>
        <div style={{clear: 'both'}}></div>
    </div>
  );
};

export default AppHeader;
