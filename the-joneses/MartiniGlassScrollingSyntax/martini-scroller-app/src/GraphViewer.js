// GraphViewer.js
import React from 'react';

const GraphViewer = ({ data, storyId }) => {
  const containerStyle = {
    background: 'red',
    minHeight: '100vh'
    // Add more styles as needed
  };

  const block = {
    minHeight: '10em'
  };

  // Find the matching story
  const story = data.story["syntax-locked-vs-unlocked"].find(s => s.id === storyId);
  const storyName = story ? story.name : "story has no name";
  const storyStatement = story ? story.statement : "story has no statement";
  const imagePath = story ? story.image : 'default/path/to/image.png'; // Replace 'default/path/to/image.png' with a default image path

  return (
    <div style={containerStyle}>
        <h1>{storyName}</h1>
        <div><b>
            {storyStatement}
            </b></div>
      <img src={imagePath} alt="Knowledge Graph" />

      <div style={block}>
        This is the knowledge graph pane
      </div>
    </div>
  );
};

export default GraphViewer;
