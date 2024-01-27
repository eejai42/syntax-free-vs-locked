import React from 'react';

const TextToSpeech = ({ currentStory, charlieCounter }) => {
    const columnStyle = {
        flex: '1',         // Each column takes equal space
        width: '25%',      // Each column is 25% of the total width
        padding: '10px',   // Some padding for aesthetics
        boxSizing: 'border-box' // Include padding and border in the element's total width and height
    };

    // Function to replace #charlieCounter# with charlieCounter value
    const replaceCharlieCounter = (text) => {
        return text.replace(/#charlieCounter#/g, `almost ${(Math.floor(charlieCounter / 10) + 1) * 10}`);
    };

    return (
        <div style={{ display: 'flex', width: '100%' }}>
            <div style={columnStyle}>
                <h3>Intro</h3>
                <p>{replaceCharlieCounter(currentStory.intro)}</p>
            </div>
            <div style={columnStyle}>
                <h3>Syntax-Locked Intro</h3>
                <p>{replaceCharlieCounter(currentStory['syntax-locked-intro'])}</p>
            </div>
            <div style={columnStyle}>
                <h3>Mantra</h3>
                <p>{replaceCharlieCounter(currentStory.mantra)}</p>
            </div>
            <div style={columnStyle}>
                <h3>Syntax-Free Intro</h3>
                <p>{replaceCharlieCounter(currentStory['syntax-free-intro'])}</p>
            </div>
        </div>
    );
};

export default TextToSpeech;
