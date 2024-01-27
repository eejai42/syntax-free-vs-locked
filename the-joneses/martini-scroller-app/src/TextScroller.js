import React, { useEffect, useState } from 'react';
import './TextScroller.css';

const TextScroller = ({ currentVariation, currentKeywordCounter, currentKeyword, currentTime }) => {
  const [queue, setQueue] = useState([]);
  const [keywordCounter, setKeywordCounter] = useState(15);

  useEffect(() => {
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
    <div className="TextScrollerContainer">
      <div className="CharlieCounter"> 
      <div style={{position: 'absolute', right: '10', fontSize:'0.8em', paddingRight: '0.25em'}}>{currentTime.dayOfWeekName}
      {currentTime.calendarDay > 7 ? `, Week #${Math.floor(currentTime.calendarDay / 7) + 1}` : null}
      </div>
        {currentKeyword} Counter: <span>{keywordCounter}</span>

      </div>
      <div
          style={{ minHeight: "3em", maxHeight: "3em" }}
          className="WhiteHeader"
        >
          <h3 style={{ margin: 0 }}>Syntax-Locked Descriptions</h3>
          <h4 style={{ margin: 0 }}>Descriptions of the Idea</h4>
        </div>
      {queue.map(variation => (
        <div
          key={variation.key}
          className="TextScrollerItem"
          style={variation.style} // Apply the style defined in each variation
        >
          <div className="languageTag">{variation.language}</div>
          <div className="CardTitle">{variation.title}</div>
          <div dangerouslySetInnerHTML={{ __html: variation.htmlText }}></div>
        </div>
      ))}
    </div>
  );
};

export default TextScroller;
