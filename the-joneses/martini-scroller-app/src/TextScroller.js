import React, { useState, useEffect } from "react";

const TextScroller = ({ currentVariation }) => {
  const [variationQueue, setVariationQueue] = useState([]);
  const scrollSpeed = 8000; // Duration of each scroll
  const maxQueueSize = 4; // Maximum number of variations to display

  // Add new variation to the queue
  useEffect(() => {
    if (currentVariation) {
      console.error("RECEIVED NEW VARIATION!");
      setVariationQueue((prevQueue) => {
        const newQueue = [...prevQueue, currentVariation];
        return newQueue.length > maxQueueSize ? newQueue.slice(1) : newQueue;
      });
    }
  }, [currentVariation]);

  return (
    <div style={{ position: "relative" }}>
      <div className="FullHeightContainer" style={{ minHeight: "65vh" }}>
        {variationQueue.map((variation, index) => (
          <div
            key={index}
            style={{ opacity: 1, animationDuration: `${scrollSpeed}ms` }}
            className="TextScroller"
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
              <div style={{ whiteSpace: "pre-wrap" }}>{variation.text}</div>{" "}
              {/* Using plain text */}
            </div>
          </div>
        ))}
      </div>
    </div>
  );
};

export default TextScroller;
