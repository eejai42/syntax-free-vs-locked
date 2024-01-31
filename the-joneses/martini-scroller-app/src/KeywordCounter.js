import './KeywordCounter.css';

function KeywordCounter({ keywordCounters, keywordName, showCounterLabel = false, alwaysShow1 = false}) {
    const keyword = keywordCounters[keywordName.toLowerCase()] || {};
  
    if (keyword.lockedCount <= 0) {
      return null; // Don't render if lockedCount is 0 or undefined
    }
  
    const keywordStyle = keyword.isStale && !alwaysShow1 ? 'staleKeyword' : 'lockedKeyword';
    const alwaysShow1Value = alwaysShow1 && keyword.isStale ? 0 : 1;
  
    return (
      <span className={' charlieCounter ' + (keywordName == 'charlie' ? 'theCharlieCounter' : 'otherCounters')} style={{display:keyword.isHighlightable ? '' : 'none'}}>
        <span className={keywordStyle}>{keyword.name}{ showCounterLabel ? ' Counter' : '' }:</span><span>{alwaysShow1 ? alwaysShow1Value : keyword.lockedCount}</span>
      </span>
    );
  }
  

  export default KeywordCounter;