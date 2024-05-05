import React from "react";

const NodeWithChildren = ({ node }) => {
    return (
        <table className="node-table">
            <tbody>
                {/* Display the current node's main details */}
                <tr>
                    <td colSpan={node.Children ? node.Children.length * 2 : 1} style={{border: 'none'}}>
                        <table class="node-header">
                            <tr>
                                <td>
                                <div style={{border: node.MOFLayerNumber < 2 ? 'solid black 1px' : 'none'}}>
                                    <strong>{node.FQNChoiceName}</strong><br/>
                                    <div>
                                        <strong>ExpectedColor:</strong> {node.ExpectedColor}<br/>
                                    </div>
                                    <div>
                                        <strong>MOFLayer:</strong> {node.MOFLayerNumber}<br/>
                                    </div>
                                </div>

                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div>
                                        {node.ToolName ? (<span><strong></strong> {node.ToolName} </span>) : null}
                                        {node.InputChoiceFileName ? <span> -i<strong> {node.InputChoiceFileName}</strong></span> : null}
                                        {node.NodeDefaultFileName ? <span> -o<strong> {node.NodeDefaultFileName}</strong></span> : null}
                                    </div>
                                </td>
                            </tr>
                        </table>                                    
                    </td>
                </tr>
                {/* <tr><td></td></tr> */}
                {/* Display children in separate cells if they exist */}
                {node.Children && node.Children.length > 0 && (
                    <tr>
                        {node.Children.map((childNode, index) => (                            
                            <React.Fragment>
                                {(childNode.MOFLayerNumber !== 1) || index === 0 ?
                                <td key={childNode.NodeName}>   
                                    Parentalyer: {node.ParentMOFLayerNumber || '--'} / {childNode.ParentMOFLayerNumber || '--'} / LayerNumber: {childNode.MOFLayerNumber || '--'}
                                    <NodeWithChildren node={childNode} />
                                </td> : <td key={childNode.NodeName} style={{border: 'none'}}></td>}
                            </React.Fragment>
                        ))}
                    </tr>
                )}
            </tbody>
        </table>
    );
};

export default NodeWithChildren;
