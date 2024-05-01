import React, { useState, useEffect } from "react";
import LockedOrFreeCellComponent from "./LockedOrFreeCellComponent";
import RowHeaderComponent from "./RowHeaderComponent";

const LockedAndFreeSyntaxComparisonTable = ({ transpilerNodes, onTranspilerNodeChange, showUsed }) => {



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
              />
            </td>
            <td valign="top">
              <RowHeaderComponent
                transpilerNode={transpilerNode}
                onTranspilerNodeChange={onTranspilerNodeChange}
              />
            </td>
            <td valign="top">
              <LockedOrFreeCellComponent
                transpilerNode={transpilerNode}
                isSyntaxLocked={false}
              />
            </td>
          </tr>
        ))}
      </tbody>
    </table>
  );
};

export default LockedAndFreeSyntaxComparisonTable;
