import React, { useEffect } from "react";
import TranspilerNodeComponent from "./TranspilerNodeComponent";
import TranspilerRowHeaderComponent from "./TranspilerRowHeaderComponent";

const TechFlowingComponent = ({ demoFlow, showUsed }) => {
    console.error("Rendering TechFlowingComponent", TechFlowingComponent, demoFlow);
  return (
    <table>
        <tr>
        <th>Syntax Locked</th>
          <th>Technology</th>
          <th>Syntax Free</th>
        </tr>
        {demoFlow.reduce((acc, item) => {
            console.error("TechFlowingComponent", item.IsUsed, showUsed)
          if ((item.IsUsed === 1) == showUsed) {
            acc.push(item);
          }
          return acc;
        }, []).map((item, index) => (
          <tr>
            <td valign="top">
              <div key={index} style={{maxwidth: '45em', width: '38em', marginTop: '0em'}}>
                <TranspilerNodeComponent
                  transpilerItem={item}
                  isSyntaxLocked={true}
                />
              </div>
            </td>
            <td valign="top">
              <div key={index}>
                <TranspilerRowHeaderComponent
                  transpilerItem={item}
                />
              </div>
            </td>
            <td valign="top">
              <div key={index}  style={{maxwidth: '45em', width: '38em', marginTop: '0em'}}>
                <TranspilerNodeComponent transpilerItem={item}
                  isSyntaxLocked={false}
                  />
              </div>
            </td>
          </tr>
        ))}
      </table>  );
};

export default TechFlowingComponent;
