import React, { useEffect } from "react";
import LockedOrFreeCellComponent from "./LockedOrFreeCellComponent";
import RowHeaderComponent from "./RowHeaderComponent";

const LockedAndFreeSyntaxComparisonTable = ({ transpilerNodes, showUsed }) => {
  return (
    <table>
      <tbody>
        <tr>
        <th>Syntax Locked</th>
          <th>Technology</th>
          <th>Syntax Free</th>
        </tr>
        {transpilerNodes.reduce((acc, transpilerNode) => {
          if ((transpilerNode.IsUsed === 1) == showUsed) {
            acc.push(transpilerNode);
          }
          return acc;
        }, []).map((transpilerNode, index) => (
          (<tr key={index} style={{borderTop: 'solid black 3px', padding: '0.5rem'}}>
            <td valign="top">
              <div style={{maxwidth: '45em', width: '38em', marginTop: '0em'}}>
                <LockedOrFreeCellComponent
                  transpilerNode={transpilerNode}
                  isSyntaxLocked={true}
                />
              </div>
            </td>
            <td valign="top">
              <div>
                <RowHeaderComponent
                  transpilerNode={transpilerNode}
                />
              </div>
            </td>
            <td valign="top">
              <div style={{maxwidth: '45em', width: '38em', marginTop: '0em'}}>
                <LockedOrFreeCellComponent transpilerNode={transpilerNode}
                  isSyntaxLocked={false}
                  />
              </div>
            </td>
          </tr>)
        ))}
        </tbody>
      </table>  );
};

export default LockedAndFreeSyntaxComparisonTable;
