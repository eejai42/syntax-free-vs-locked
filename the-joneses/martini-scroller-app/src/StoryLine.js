// LanguagePicker.js
import React from "react";

const StoryLine = ({
    languageName, 
    currentKeyword,
    story
}) => {
    
    const parentStyle = {
        display: 'flex', // Using Flexbox
        alignItems: 'center', // Vertically centers the child
        justifyContent: 'center', // Horizontally centers the child
        height: '5em', // Sets the height to exactly 5em
        // Additional styles (like width, background, etc.) can be added here
    };

    const childStyle = {
        fontSize: '1.4em',
    };

    return (
        <div style={parentStyle}>
            <div style={childStyle}>{story.statement}</div>
        </div>
    );
};

export default StoryLine;
