import React from 'react';

function StoryNavigator({ onPrevious, onNext, chapterList, currentChapterId }) {
  const findStoryHint = (offset) => {
    const currentIndex = chapterList.findIndex(story => story.id === currentChapterId);
    if (currentIndex === -1) return console.error('Story not found in chapter list');
    const newIndex = (currentIndex + offset + chapterList.length) % chapterList.length;
    return chapterList[newIndex].hint;
  };

  const currentIndex = chapterList.findIndex(story => story.id === currentChapterId);

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
        disabled={currentIndex === chapterList.length - 1}
        style={{ visibility: currentIndex < chapterList.length - 1 ? 'visible' : 'hidden' }}
      >
        {findStoryHint(1)} &gt;
      </button>
    </div>
  );
}

export default StoryNavigator;
