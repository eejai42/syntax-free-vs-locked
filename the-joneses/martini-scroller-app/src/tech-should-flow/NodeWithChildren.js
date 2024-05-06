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
                                {node.MOFLayerNumber === 0 && !node.OutputIsDocs && <td style={{width: '10em'}}>RIGHT</td>}
                                <td>
                                    <div style={{border: node.MOFLayerNumber < 2 ? 'solid black 1px' : 'none'}}>
                                        <strong>{node.FQNChoiceName}</strong>
                                        {node.MOFLayerNumber === 2 && <span>
                                            
                                            </span>}<br/>
                                        <div>
                                            {node.ExpectedColor && <span><strong>ExpectedColor:</strong> {node.ExpectedColor}<br/></span>}
                                        </div>
                                    </div>
                                </td>
                                {node.MOFLayerNumber === 0 && node.OutputIsDocs && <td style={{width: '10em'}}>LEFT</td>}
                            </tr>
                            <tr>
                                <td colSpan="2">

                                    <div>
                                        {node.ToolName ? (<span><strong></strong> {node.ToolName} </span>) : null}
                                        {node.InputChoiceFileName ? <span> -i<strong> {node.InputChoiceFileName}</strong></span> : null}
                                        {node.NodeDefaultFileName ? <span> -o<strong> {node.NodeDefaultFileName}</strong></span> : null}
                                    </div>
                                </td>
                            </tr>
                            {node.MOFLayerNumber === 0 &&<tr>
                                <td colSpan="2">
                                {node.ToolName} <br/>
                                </td>
                            </tr>}
                        </table>                                    
                    </td>
                </tr>
                {/* <tr><td></td></tr> */}
                {/* Display children in separate cells if they exist */}
                {node.Children && node.Children.length > 0 && (
                    <tr>
                        {node.Children.map((childNode, index) => (                            
                            <React.Fragment>
                                {(childNode.MOFLayerNumber !== 1) || index === 1 ?
                                <td key={childNode.NodeName}>   
                                <table style={{width: '100%'}}>
                                    <tr>
                                        <td>
                                            <NodeWithChildren node={childNode} />
                                        </td>
                                    </tr>
                                </table>
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
