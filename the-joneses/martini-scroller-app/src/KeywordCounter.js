import './KeywordCounter.css';

function KeywordCounter({ keywordCounters, keywordName, showCounterLabel = false}) {
    const keyword = keywordCounters[keywordName.toLowerCase()] || {};
  
    if (keyword.lockedCount <= 0) {
      return null; // Don't render if lockedCount is 0 or undefined
    }
  
    const keywordStyle = keyword.isStale ? 'staleKeyword' : 'lockedKeyword';
  
    return (
      <span className={' charlieCounter ' + (keywordName == 'charlie' ? 'theCharlieCounter' : 'otherCounters')}>
        <span className={keywordStyle}>{keyword.name}{ showCounterLabel ? ' Counter' : '' }:</span><span>{keyword.lockedCount}</span>
      </span>
    );
  }
  

  export default KeywordCounter;