// LanguagePicker.js
import React from "react";

const AppHeader = ({
    languageName, 
    currentKeyword,
    story
}) => {
    
    const nameStyle  = {
        padding: "0.25em",
        marginTop: "0",
        marginBottom: "0",
        float: 'left',
        marginRight: '2em',
        fontSize: '1.5em',
        fontWeight: 'bold',
        maxWidth: '35vw',
        minWidth: '35vw'


    }
    const statementStyle = {
        marginTop: "0",
        marginBottom: "0"
    }
  return (
    <div style={{padding: '1em', position: 'relative', minHeight: "4em"}}>
        <div style={nameStyle}>{story.name}</div>
        <div style={statementStyle}>{story.statement}</div>
    </div>
  );
};

export default AppHeader;
