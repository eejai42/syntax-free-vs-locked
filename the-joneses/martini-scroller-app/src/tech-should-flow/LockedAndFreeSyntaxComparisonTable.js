import React, { useState, useEffect } from "react";
import LockedOrFreeCellComponent from "./LockedOrFreeCellComponent";
import RowHeaderComponent from "./RowHeaderComponent";

const LockedAndFreeSyntaxComparisonTable = ({ transpilerNodes, onUpdateGuess, onTranspilerNodeChange, showUsed }) => {

  const handleUpdateClick = (transpilerNode) => {
    console.log("Update clicked for: ", transpilerNode);
    onUpdateGuess(transpilerNode)
  };

  return (
    <table>
      <tbody>
        <tr>
          <th>Syntax Locked</th>
          <th>Technology</th>
          <th>Syntax Free</th>
        </tr>
        {transpilerNodes?.filter(node => (node.IsUsed === 1) === showUsed).map((transpilerNode, index) => (
          <tr key={index} style={{borderTop: 'solid black 3px', padding: '0.5rem'}}>
            <td valign="top">
              <LockedOrFreeCellComponent
                transpilerNode={transpilerNode}
                isSyntaxLocked={true}
                onUpdateClick={handleUpdateClick}
              />
            </td>
            <td valign="top">
              <RowHeaderComponent
                transpilerNode={transpilerNode}
                onUpdateClick={handleUpdateClick}
                onTranspilerNodeChange={onTranspilerNodeChange}
              />
            </td>
            <td valign="top">
              <LockedOrFreeCellComponent
                transpilerNode={transpilerNode}
                isSyntaxLocked={false}
                onUpdateClick={handleUpdateClick}
              />
            </td>
          </tr>
        ))}
      </tbody>
    </table>
  );
};

export default LockedAndFreeSyntaxComparisonTable;
