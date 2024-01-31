import React, { useRef, useEffect } from "react";

const TextToSpeech = ({ currentChapter, keywordCounters }) => {
  const columnStyle = {
    flex: "1",
    width: "25%",
    padding: "10px",
    boxSizing: "border-box",
  };

  const contentRef = useRef(null); // Ref for the content div
  const mantraTextRef = useRef(null); // Ref for the mantra text div

  // Function to replace #charlieCounter# with charlieCounter value
  const replaceCharlieCounter = (text) => {
    console.error(
      "replaceCharlieCounter",
      text,
      "keywordCounters",
      keywordCounters
    );
    var charlieCounter =
      keywordCounters && keywordCounters["charlie"]
        ? keywordCounters["charlie"].lockedCount
        : 0;
    const next50 = Math.ceil((charlieCounter + 1) / 50) * 50;
    const difference = next50 - charlieCounter;
    const under25 = Math.floor(charlieCounter / 10) * 10;

    if (difference <= 25) {
      return text.replace(/#charlieCounter#/g, `almost ${next50}`);
    } else if (charlieCounter < 10) {
      return text.replace(/#charlieCounter#/g, `2`);
    } else {
      return text.replace(/#charlieCounter#/g, `over ${under25}`);
    }
  };

  // Function to handle the selection of text
  const selectText = (event, selectMantraOnly = false) => {
    if (window.getSelection) {
      const selection = window.getSelection();
      const range = document.createRange();
      if (selectMantraOnly) {
        range.selectNodeContents(mantraTextRef.current);
      } else {
        range.setStart(contentRef.current.firstChild, 0); // Start at the first child of the content div
        range.setEndBefore(mantraTextRef.current); // End before the mantra text
      }
      selection.removeAllRanges();
      selection.addRange(range);
    }
    event.target.blur(); // This removes focus from the button after clicking
  };

  const autoSelectText = (selectMantraOnly = false) => {
    if (window.getSelection) {
      const selection = window.getSelection();
      const range = document.createRange();
      if (selectMantraOnly) {
        range.selectNodeContents(mantraTextRef.current);
      } else {
        range.setStart(contentRef.current.firstChild, 0);
        range.setEndBefore(mantraTextRef.current);
      }
      selection.removeAllRanges();
      selection.addRange(range);
    }
  };

  // Automatically select intro when a new story loads
  useEffect(() => {
    autoSelectText();
    const mantraTimer = setTimeout(() => {
      autoSelectText(true);
    }, 35000); // 35 seconds later

    return () => clearTimeout(mantraTimer); // Cleanup on component unmount or currentChapter change
  }, [currentChapter]);

  return (
    <div style={{ zIndex: 0 }}>
      <div style={{ marginBottom: "3em", marginTop: "-3em" }}>
        <button
          className="btn btn-small btn-primary"
          style={{ userSelect: "none" }}
          onClick={(e) => selectText(e)}
        >
          Read Script
        </button>
        <button
          className="btn btn-small btn-primary"
          style={{ marginLeft: "10px", userSelect: "none" }}
          onClick={(e) => selectText(e, true)}
        >
          Read Mantra
        </button>
      </div>
      <div style={{ display: "flex", width: "100%" }}>
        <div style={columnStyle}>
          <h3>Intro</h3>
        </div>
        <div style={columnStyle}>
          <h3>Syntax-Locked Intro</h3>
        </div>
        <div style={columnStyle}>
          <h3>Syntax-Free Intro</h3>
        </div>
        <div style={columnStyle}>
          <h3>Mantra</h3>
        </div>
      </div>
      <div style={{ display: "flex", width: "100%" }} ref={contentRef}>
        <div style={columnStyle}>
          <p>{replaceCharlieCounter(currentChapter.intro)}</p>
        </div>
        <div style={columnStyle}>
          <p>{replaceCharlieCounter(currentChapter["syntax-locked-intro"])}</p>
        </div>
        <div style={columnStyle}>
          <p>{replaceCharlieCounter(currentChapter["syntax-free-intro"])}</p>
        </div>
        <div style={columnStyle} ref={mantraTextRef}>
          <p>{replaceCharlieCounter(currentChapter.mantra)}</p>
        </div>
      </div>
    </div>
  );
};

export default TextToSpeech;
