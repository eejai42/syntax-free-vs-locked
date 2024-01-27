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
        marginBottom: "-1em",
        float: 'left',
        fontSize: '2em',
        fontWeight: 'bold',
        maxWidth: '50vw',
        minWidth: '50vw'        

    }
    const statementStyle = {
        marginTop: "0",
        marginBottom: "0",
        width: '50%',
        maxWidth: '45vw',
        minWidth: '30vw',
        fontSize: '1.4em',
        float: 'left',
        textAlign: 'center',

    }
  return (
    <div style={{padding: '0.25em', position: 'relative', minHeight: "4em"}}>
        <div style={nameStyle}>{story.name}</div>
        <div style={statementStyle}>{story.statement}</div>
        <div style={{clear: 'both'}}></div>
    </div>
  );
};

export default AppHeader;
