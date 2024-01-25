import React, { useState, useEffect } from "react";

const TextScroller = ({ currentVariation }) => {
  const [variationQueue, setVariationQueue] = useState([]);
  const maxQueueSize = 4; // Maximum number of variations to display

  // Add new variation to the queue
  useEffect(() => {
    if (currentVariation) {
      console.error("GOT NEW VARIATION: ", currentVariation, variationQueue);
      setVariationQueue((prevQueue) => {
        const newQueue = [
          ...prevQueue,
          { ...currentVariation, key: Date.now() },
        ];
        return newQueue.length > maxQueueSize
          ? newQueue.slice(-maxQueueSize)
          : newQueue;
      });
    }
  }, [currentVariation]);

  return (
    <div className="FullHeightContainer" style={{ minHeight: "65vh" }}>
      {variationQueue.map((variation) => (
        <div key={variation.key}>
          <div
            // className="TextScroller"
            style={{
              animationDuration: "8s",
              border: "1px solid red", // Temporary border to visually debug
            }}
          >
            <div style={{ minWidth: "95%" }}>
              <div
                style={{
                  fontWeight: "bold",
                  padding: "0.5em",
                  fontSize: "0.8em",
                  position: "relative",
                }}
              >
                {variation.title}:
              </div>
              <div style={{ whiteSpace: "pre-wrap" }}>{variation.text}</div>
            </div>
          </div>
        </div>
      ))}
    </div>
  );
};

export default TextScroller;
