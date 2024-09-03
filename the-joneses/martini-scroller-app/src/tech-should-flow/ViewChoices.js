import React, { useState, useEffect } from "react";
import "./TechShouldFlow.css";
import NodeWithChildren from "./NodeWithChildren";
import NodeDomainDisplay from "./NodeDomainDisplay";

const ViewChoices = ({ choices, isSyntaxFree, selectedIndex, onSetSelectedIndex }) => {
    const [structuredData, setStructuredData] = useState(null);

    useEffect(() => {
      if (choices) {
          // Function to recursively build the nested structure
          const buildNestedStructure = (parentNodeName, depth) => {
            if (depth > 5) return;
            const nestedData = [];
            choices.forEach(choice => {
                if (choice.ParentChoiceName === parentNodeName) {
                    const node = {
                        ...choice,
                        Children: buildNestedStructure(choice.FQNChoiceName, ++depth)
                    };
                    nestedData.push(node);
                }
            });
            return nestedData;
        };

          // Find root nodes (nodes with no parent)
          const rootNodes = choices.filter(choice => !choice.ParentChoiceName);
  
          // Call the buildNestedStructure function for each root node
          const structuredData = rootNodes.map(rootNode => {
              return {
                  ...rootNode,
                  Children: buildNestedStructure(rootNode.FQNChoiceName, 0)
              };
          });

          console.error('GOT STRUCTURED DATA', structuredData);
          setStructuredData(structuredData);
      }
  }, [choices]);

  return (
    <div>
        <h2>
          {isSyntaxFree ? 'Syntax Free' : 'Syntax Locked'}</h2>
       

        <table className="choices-table">
            <tbody>
              <tr>
                <td style={{width: 0}}>   
                  {structuredData && structuredData.map(rootNode => (
                    <NodeDomainDisplay node={rootNode} selectedIndex={selectedIndex} onSetSelectedIndex={onSetSelectedIndex} />
                  ))}
                </td>
                <td>
                  {structuredData && structuredData.map(rootNode => (
                      <NodeWithChildren key={rootNode.NodeName} node={rootNode} selectedIndex={selectedIndex} />
                  ))}
                </td>
              </tr>
            </tbody>
        </table>
    </div>
  );
};

export default ViewChoices;
