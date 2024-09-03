import React, { useState, useEffect } from "react";
import { HexColorPicker } from "react-colorful";
import { hslToHex, hexToHsl } from "../colorUtils";
import { getContrastColor } from "../colorUtils";

const NodeDomainDisplay = ({ node, selectedIndex, onSetSelectedIndex}) => {
    const [currentNode, setCurrentNode] = useState(node.Children[selectedIndex]);

    useEffect(() => {
        setCurrentNode(node.Children[selectedIndex]);
    }, [selectedIndex]);

    return (
        <div style={{position: 'absolute', width: '25em', height: '15em'}}>
            <h3>            <select value={selectedIndex} onChange={(e) => onSetSelectedIndex(e.target.value)}>
              <option value={0}>{node.Children[0].NodeName}</option>
              <option value={1}>{node.Children[1].NodeName}</option>
              <option value={2}>{node.Children[2].NodeName}</option>
            </select>
</h3>
<h3>{node.ToolName}</h3>
            {currentNode?.IsSyntaxFree ? (<div>
                <img src={(currentNode?.NodePlatformAttachments?.length && currentNode?.NodePlatformAttachments[0].url)} 
                            style={{width: '8.5em', marginTop: '2em', paddingLeft: '0em', marginLeft: '0em'}}/>
                <img src={(node?.NodePlatformAttachments?.length > 0 && node.NodePlatformAttachments[0]).url} 
                        style={{width: '8.5em', marginTop: '2em', paddingLeft: '0em', marginLeft: '0em'}}/>
                <img src={(currentNode?.ToolInputChoiceNodeAttachments?.length > 0 && currentNode.ToolInputChoiceNodeAttachments[0]).url} 
                        style={{width: '4.5em', marginTop: '2em', paddingLeft: '0em', marginLeft: '0em'}}/>

            </div>) : (
                <div>
                    <img src={(currentNode?.NodePlatformAttachments?.length && currentNode?.NodePlatformAttachments[0].url)} 
                            style={{width: '8.5em', marginTop: '2em', paddingLeft: '0em', marginLeft: '0em'}}/>
                    <img src={(currentNode?.ToolPlatformAttachments?.length > 0 && node.ToolPlatformAttachments[0]).url} 
                            style={{width: '8.5em', marginTop: '2em', paddingLeft: '0em', marginLeft: '0em'}}/>
            </div>)}

          <div style={{float: 'left', minWidth: '7em', display: 'block'}}><img src=""/></div>

        </div>
    )
}

export default NodeDomainDisplay;
