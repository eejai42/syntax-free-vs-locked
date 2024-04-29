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
    <div>
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
                  rowKey={true}
                />
              </div>
            </td>
            <td valign="top">
              <div key={index}>
                <TranspilerNodeComponent
                  transpilerItem={item}
                  syntaxLocked={true}
                />
              </div>
            </td>
            <td valign="top">
              <div key={index}>
                <TranspilerNodeComponent transpilerItem={item} />
              </div>
            </td>
          </tr>
        ))}
      </table>
    </div>
  );
};

export default TechShouldFlowPage;
