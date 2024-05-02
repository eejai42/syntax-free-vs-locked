import React, { useState, useEffect } from "react";
import LockedAndFreeSyntaxComparisonTable from "./LockedAndFreeSyntaxComparisonTable";
import "./TechShouldFlow.css";

const TechShouldFlowPage = ({ initialTranspilerNodes }) => {
  const [transpilerNodes, setTranspilerNodes] = useState(initialTranspilerNodes);

  const handleColorChange = (node, newColor) => {
    if (node.ExpectedColor === newColor) return;  // No update needed if the color hasn't changed

    let updatedNodes = [...transpilerNodes];  // Create a shallow copy of nodes for immutability

    // Recursive function to update color
    const updateNodeColor = (edgeName, newColor) => {
      updatedNodes = updatedNodes.map(n => {
        if (n.EdgeName === edgeName) {
          return { ...n, ExpectedColor: newColor };  // Update the current node's color
        }
        return n;
      });

      // Recursively update grandchildren
      let childNodes = updatedNodes.filter(n => n.SyntaxFreeEdgeName === edgeName);
      childNodes.forEach(childNode => {
        updateNodeColor(childNode.EdgeName, newColor);
      });
    };

    updateNodeColor(node.EdgeName, newColor);
    console.error('UPDATED NODES', updatedNodes);
    setTranspilerNodes(updatedNodes);  // Update the state once all color updates are completed
  };

  const handleUpdateGuess = (transpilerNode) => {
    // let updatedNodes = [...transpilerNodes];  // Create a shallow copy of nodes for immutability

    // updatedNodes = updatedNodes.map(n => {
    //   if (n.EdgeName === transpilerNode.EdgeName) {
    //     return { ...n, SyntaxFreeColor: n.ExpectedColor, LockedColor: n.ExpectedColor };  // Update the current node's color
    //   }
    //   return n;    
    // });
    // setTranspilerNodes(updatedNodes);  // Update the state once all color updates are completed
  };

  return (
    <div style={{fontSize: '0.8em', margin: '1em'}}>
      <div style={{maxWidth: '100rem'}}>
        <h1>Tech should Follow Along</h1>
        <LockedAndFreeSyntaxComparisonTable transpilerNodes={transpilerNodes} 
                      onUpdateGuess={handleUpdateGuess} 
                      onTranspilerNodeChange={handleColorChange} showUsed={true} />
      </div>
      <div style={{maxWidth: '95rem', marginTop: '35em'}}>
        <h1>Unused Technologies</h1>
        <div style={{backgroundColor: '#dddddd', fontSize: '1em'}}>
          <LockedAndFreeSyntaxComparisonTable transpilerNodes={transpilerNodes} 
                      onUpdateGuess={handleUpdateGuess} 
                      onTranspilerNodeChange={handleColorChange} showUsed={false} />
        </div>
      </div>
    </div>
  );
};

export default TechShouldFlowPage;
