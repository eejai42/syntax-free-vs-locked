import React from 'react';

function StoryNavigator({ onPrevious, onNext, storyList, currentStoryId }) {
  const findStoryHint = (offset) => {
    const currentIndex = storyList.findIndex(story => story.id === currentStoryId);
    const newIndex = (currentIndex + offset + storyList.length) % storyList.length;
    return storyList[newIndex].hint;
  };

  const currentIndex = storyList.findIndex(story => story.id === currentStoryId);

  return (
    <div style={{   display: 'flex', 
    justifyContent: 'space-between', 
    position: 'absolute', 
    top: 0, 
    left: 0, 
    right: 0,
    zIndex: 999 }}>
      <button  className="btn btn-back-story"
        onClick={onPrevious}
        disabled={currentIndex === 0}
        style={{ visibility: currentIndex > 0 ? 'visible' : 'hidden' }}
      >
        &lt; {findStoryHint(-1)}
      </button>
      <button className="btn btn-story"
        onClick={onNext}
        disabled={currentIndex === storyList.length - 1}
        style={{ visibility: currentIndex < storyList.length - 1 ? 'visible' : 'hidden' }}
      >
        {findStoryHint(1)} &gt;
      </button>
    </div>
  );
}

export default StoryNavigator;
