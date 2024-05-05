import React from "react";

const NodeWithChildren = ({ node }) => {
    return (
        <React.Fragment key={node.NodeName}>
            <tr>
                <td colSpan="2"><div>{node.Name}</div></td>
            </tr>
            {node.Children && node.Children.map(childNode => (
                <NodeWithChildren key={childNode.NodeName} node={childNode} />
            ))}
        </React.Fragment>
    );
};

export default NodeWithChildren;
