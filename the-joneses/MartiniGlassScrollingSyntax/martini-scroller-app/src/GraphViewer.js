// GraphViewer.js
import React from "react";
import './App.css'

const GraphViewer = ({ data, story, currentKeyword }) => {
  const containerStyle = {
    marginTop: "3rem",
    minHeight: "100vh",
    // Add more styles as needed
  };

  // Add more styles as needed
  const graphStyle = {
    width: "90%",
    maxHeight: "40%",
  };

  // Find the matching story
  const storyName = story ? story.name : "story has no name";
  const storyStatement = story ? story.statement : "story has no statement";
  const imagePath = story ? story.image : "default/path/to/image.png"; // Replace 'default/path/to/image.png' with a default image path

  return (
    <div style={containerStyle}>
              <div
        className="CharlieCounter"
      >
        {currentKeyword} Counter: 1
      </div>

      <img src={imagePath} alt="Knowledge Graph" style={graphStyle} />
    </div>
  );
};

export default GraphViewer;
