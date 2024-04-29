import React, { useEffect } from "react";
import { useLocation } from "react-router-dom";
import TranspilerNodeComponent from "./TranspilerNodeComponent";
import TranspilerRowHeaderComponent from "./TranspilerRowHeaderComponent";

const TechShouldFlowPage = ({ demoFlow }) => {
  const data = demoFlow.DataFlow;

  useEffect(() => {
    console.error("Rendering TechShouldFlowPage", TechShouldFlowPage, data);
  });

  return (
    <div style={{fontSize: '0.8em'}}>
      Tech should followAlong
      <table>
        <tr>
          <th>Goal</th>
          <th>Syntax Locked</th>
          <th>Syntax Free</th>
        </tr>
        {data.map((item, index) => (
          <tr>
            <td valign="top">
              <div key={index}>
                <TranspilerRowHeaderComponent
                  transpilerItem={item}
                />
              </div>
            </td>
            <td valign="top">
              <div key={index} style={{maxwidth: '45em', width: '38em', marginTop: '-1em'}}>
                <TranspilerNodeComponent
                  transpilerItem={item}
                  isSyntaxLocked={true}
                />
              </div>
            </td>
            <td valign="top">
              <div key={index}  style={{maxwidth: '45em', width: '38em', marginTop: '-1em'}}>
                <TranspilerNodeComponent transpilerItem={item}
                  isSyntaxLocked={false}
                  />
              </div>
            </td>
          </tr>
        ))}
      </table>
    </div>
  );
};

export default TechShouldFlowPage;
