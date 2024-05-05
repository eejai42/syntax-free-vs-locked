import React from "react";

const NodeWithChildren = ({ node }) => {
    return (
        <table className="node-table">
            <tbody>
                {/* Display the current node's main details */}
                <tr>
                    <td colSpan={node.Children ? node.Children.length : 1}>
                        <div>
                            <strong>Name:</strong> {node.Name}<br/>
                            <strong>FQNChoiceName:</strong> {node.FQNChoiceName}<br/>
                            <strong>ToolName:</strong> {node.ToolName}<br/>
                            <strong>NodeName:</strong> {node.NodeName}<br/>
                            <strong>ExpectedColor:</strong> {node.ExpectedColor}<br/>
                            <strong>Notes:</strong> {node.Notes || "No notes provided."}
                        </div>
                    </td>
                </tr>
                {/* Display children in separate cells if they exist */}
                {node.Children && node.Children.length > 0 && (
                    <tr>
                        {node.Children.map(childNode => (
                            <td key={childNode.NodeName}>
                                <NodeWithChildren node={childNode} />
                            </td>
                        ))}
                    </tr>
                )}
            </tbody>
        </table>
    );
};

export default NodeWithChildren;
