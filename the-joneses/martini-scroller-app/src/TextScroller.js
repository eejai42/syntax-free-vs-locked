import React, { useEffect, useState } from 'react';
import './TextScroller.css';

const TextScroller = ({ currentVariation, currentKeywordCounter, currentKeyword }) => {
  const [queue, setQueue] = useState([]);
  const [keywordCounter, setKeywordCounter] = useState(0);

  useEffect(() => {
    console.error('UPDATED TextScroller.', currentKeywordCounter, Date.now())
    setKeywordCounter(currentKeywordCounter);
  }, [currentKeywordCounter]);

  useEffect(() => {
    if (currentVariation) {
      console.error('FOUND NEW VARIATION: ', currentVariation, Date.now())
      setQueue(prevQueue => {
        const newVariation = { ...currentVariation, key: Date.now() + Math.random() };
        const newQueue = [...prevQueue, newVariation];
        if (newQueue.length > 5) {
          newQueue.shift(); // Remove the oldest item if queue length exceeds 5
        }
        return newQueue;
      });
    }
  }, [currentVariation]);

  return (
    <div className="TextScrollerContainer">
      <div className="CharlieCounter"> {currentKeyword} Counter: {keywordCounter} </div>
      {queue.map(variation => (
        <div
          key={variation.key}
          className="TextScrollerItem"
          style={variation.style} // Apply the style defined in each variation
        >
          <div className="CardTitle">{variation.title} - {variation.lineThrough}</div>
          <div dangerouslySetInnerHTML={{ __html: variation.htmlText }}></div>
        </div>
      ))}
    </div>
  );
};

export default TextScroller;
