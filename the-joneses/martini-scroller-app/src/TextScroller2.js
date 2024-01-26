import React, { useEffect, useState } from 'react';
import './TextScroller2.css';

const TextScroller2 = ({ currentVariation }) => {
  const [queue, setQueue] = useState([]);

  useEffect(() => {
    if (currentVariation) {
      setQueue(prevQueue => {
        // Assign a unique key to the new variation
        const newVariation = { ...currentVariation, key: Date.now() + Math.random() };

        const newQueue = [...prevQueue, newVariation];
        if (newQueue.length > 25) {
          newQueue.shift(); // Remove the oldest item if queue length exceeds 25
        }
        return newQueue;
      });
    }
  }, [currentVariation]);

  return (
    <div className="TextScroller2Container">
      {queue.map(variation => (
        <div key={variation.key} className="TextScroller2Item">
          <p>{variation.title}</p>
          <p>{variation.text}</p>
        </div>
      ))}
    </div>
  );
};

export default TextScroller2;
