import React, { useEffect, useState } from 'react';
import './TextScroller2.css';

const TextScroller2 = ({ currentVariation, currentKeywordCounter }) => {
  const [queue, setQueue] = useState([]);
  const [keywordCounter, setKeywordCounter] = useState(0);

  useEffect(() => {
    console.error('UPDATED TextScroller2.', currentKeywordCounter, Date.now())
    setKeywordCounter(currentKeywordCounter);
  }, [currentKeywordCounter]);

  useEffect(() => {
    if (currentVariation) {
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
    <div className="TextScroller2Container">
      <div className="CharlieCounter"> {keywordCounter} TEST </div>
      {queue.map(variation => (
        <div
          key={variation.key}
          className="TextScroller2Item"
          style={variation.style} // Apply the style defined in each variation
        >
          <p>{variation.title}</p>
          <p dangerouslySetInnerHTML={{ __html: variation.htmlText }}></p>
        </div>
      ))}
    </div>
  );
};

export default TextScroller2;
