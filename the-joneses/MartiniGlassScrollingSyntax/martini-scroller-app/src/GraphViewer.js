// GraphViewer.js
import React from "react";

const GraphViewer = ({ data, story }) => {
  const containerStyle = {
    marginTop: "2rem",
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
      <img src={imagePath} alt="Knowledge Graph" style={graphStyle} />
    </div>
  );
};

export default GraphViewer;
