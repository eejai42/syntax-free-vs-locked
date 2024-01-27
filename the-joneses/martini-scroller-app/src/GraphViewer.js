// GraphViewer.js
import React from "react";
import "./App.css";

const GraphViewer = ({ data, story, currentKeyword }) => {
  const containerStyle = {
    marginTop: "0rem",
    minHeight: "50vh",
    // Add more styles as needed
  };

  // Add more styles as needed
  const graphStyle = {
    height: "60vh",
    maxHeight: "60vh",
  };

  // Find the matching story
  const storyName = story ? story.name : "story has no name";
  const storyStatement = story ? story.statement : "story has no statement";
  const imagePath = story ? story.image : "default/path/to/image.png"; // Replace 'default/path/to/image.png' with a default image path

  return (
    <div style={containerStyle}>
      <div className="WhiteHeader" style={{zIndex: 999999999999}}>
        <img src="e-everything.png" className="EraIcon" style={{ right: 0 }} />
        {/* <img src="parchment.png" style={{width: '3em', float: 'right', display: 'hidden'}} /> */}
        <h3>
          <span>One</span> Syntax-Free <span>model</span>
        </h3>
        <h4>A Digital Mirror of Reality</h4>
      </div>
      <div className="CharlieCounter">
        {currentKeyword} Counter: <span>1</span>
      </div>

      <div style={{ padding: "1em", fontSize: "0.8em" }}>
        <img src={imagePath} alt="Knowledge Graph" style={graphStyle} />
      </div>
    </div>
  );
};

export default GraphViewer;
