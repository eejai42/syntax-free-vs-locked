import React, { useEffect } from "react";
import { useLocation } from "react-router-dom";
import TranspilerNodeComponent from "./TranspilerNodeComponent";

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
          <td valign="top">
            <h3>Syntax Locked</h3>
            {data.map((item, index) => (
              <div key={index}>
                <TranspilerNodeComponent transpilerItem={item} syntaxLocked={true} />
              </div>
            ))}
          </td>
          <td valign="top">
            <h3>Syntax Free</h3>
            {data.map((item, index) => (
              <div key={index}>
                <TranspilerNodeComponent transpilerItem={item} />
              </div>
            ))}
          </td>
        </tr>
      </table>
    </div>
  );
};

export default TechShouldFlowPage;
