import React from 'react';

function StoryNavigator({ onPrevious, onNext, storyList, currentStoryId }) {
  const findStoryHint = (offset) => {
    const currentIndex = storyList.findIndex(story => story.id === currentStoryId);
    const newIndex = (currentIndex + offset + storyList.length) % storyList.length;
    return storyList[newIndex].hint;
  };

  const currentIndex = storyList.findIndex(story => story.id === currentStoryId);

  return (
    <div style={{ display: 'flex', justifyContent: 'space-between' }}>
      <button 
        onClick={onPrevious}
        disabled={currentIndex === 0}
        style={{ visibility: currentIndex > 0 ? 'visible' : 'hidden' }}
      >
        &lt;&lt; {findStoryHint(-1)}
      </button>
      <button 
        onClick={onNext}
        disabled={currentIndex === storyList.length - 1}
        style={{ visibility: currentIndex < storyList.length - 1 ? 'visible' : 'hidden' }}
      >
        {findStoryHint(1)} &gt;&gt;
      </button>
    </div>
  );
}

export default StoryNavigator;