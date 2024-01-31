import React, { useEffect, useState } from 'react';
import './TextScroller.css';
import KeywordCounter from './KeywordCounter';

const TextScroller = ({ currentVariation, currentTime, keywordCounters }) => {
  const [queue, setQueue] = useState([]);

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
        <div className="WhiteHeader" >
          <h3>Syntax-Locked <span>documents</span></h3>
          <h4>Descriptions of the Idea</h4>
        </div>

      <div className="CharlieCounterBlock Paper" style={{zIndex: 100}}> 
        <div style={{position: 'absolute', right: '10px', fontSize:'0.6em', paddingRight: '0.25em'}}>{currentTime.dayOfWeekName || 'Monday'}
        {currentTime.calendarDay > 7 ? `, Week #${Math.floor(currentTime.calendarDay / 7) + 1}` : null}
        </div>
        &nbsp;
        <div className="Paper" style={{position: 'absolute', right: '0em', top: '0.0em', borderRadius: '0.25em', zIndex: -1}}>
        <KeywordCounter keywordCounters={keywordCounters} keywordName={'charlie'} showCounterLabel={true} />
        <KeywordCounter keywordCounters={keywordCounters} keywordName={'alice'} />
        <KeywordCounter keywordCounters={keywordCounters} keywordName={'bob'} />
        <KeywordCounter keywordCounters={keywordCounters} keywordName={'markus'} />
        <KeywordCounter keywordCounters={keywordCounters} keywordName={'frank'} />
        <KeywordCounter keywordCounters={keywordCounters} keywordName={'dingo'} />
        </div>
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
