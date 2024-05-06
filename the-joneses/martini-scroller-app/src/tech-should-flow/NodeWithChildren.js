import React, { useEffect, useState } from "react";
import SaturationPicker from "./SaturationPicker";
import { getContrastColor } from "../colorUtils";

const NodeWithChildren = ({ node, selectedIndex, onColorUpdate }) => {
    const [currentColor, setCurrentColor] = useState(node.MOFLayerNumber != 3 ? node.NodeDesiredColor || "#000000" : "#FFFFFF");
    const [mixedColor, setMixedColor] = useState(node.MixedColor || "#000000");

    useEffect(() => {
        setCurrentColor(node.NodeDesiredColor || "#000000");
    }, [node.NodeDesiredColor]);

    useEffect(() => {
        if (onColorUpdate) {
            onColorUpdate(currentColor, mixedColor);
        }
    }, [currentColor, mixedColor, onColorUpdate]);

    const handleHueChange = (color) => {
        setCurrentColor(color);
    };

    const handleMixedColorChange = (color) => {
        setMixedColor(color);
    };

    const pushExpectedColorForward = () => {
        console.error('Pushing expected color forward', currentColor, mixedColor, node, node.Children[selectedIndex]);
        node.Children[selectedIndex].MixedColor = currentColor;  // This directly mutates the node, consider updating state in a more React-friendly way
    }
    
    return (
        <table className="node-table">
            <tbody>
                {/* Display the current node's main details */}
                <tr>
                    <td colSpan={node.Children ? node.Children.length * 2 : 1} style={{border: 'none'}}>
                        <table class="node-header">
                            <tr>
                                {node.MOFLayerNumber <= 0 && node.OutputIsDocs && <td style={{width: '20em', position: 'relative'}}>
                                    <SaturationPicker label={node.InputChoiceFileName} color={mixedColor} src={node?.ToolAttachments[0].url} onColorChange={handleMixedColorChange} isPickerAvailable={true} style={{ height: ''}}></SaturationPicker>
                                </td>}
                                <td>
                                    <div style={{position: 'relative', height: node.MOFLayerNumber === 1 ? '14em' : '14em', border: node.MOFLayerNumber < 2 ? 'solid black 1px' : 'none', backgroundColor: currentColor, color: getContrastColor(currentColor),     
                                                maxWidth: '45em', marginLeft: 'auto', marginRight: 'auto'}}>

                                    {((node.MOFLayerNumber === 13) || (node.MOFLayerNumber === 0)) && !node.OutputIsDocs && <div style={{width: '20em', position: 'absolute', top: '1em', left: '2.5em'}}>
                                        <SaturationPicker color={currentColor} src={node?.NodeAttachments[0].url} onColorChange={handleHueChange} 
                                                        label={node.MOFLayerNumber != 1 ? "change" : node.ParentChoiceName} isPickerAvailable={node.MOFLayerNumber != 3} 
                                                        style={{ height: ''}}></SaturationPicker>
                                    </div>}

                                            <h3>{node.FQNChoiceName}</h3>

                                            {((node.MOFLayerNumber == 13) || (node.MOFLayerNumber >= 1)) && 
                                                    <div style={{width: '45%', marginLeft: 'auto', marginRight: 'auto', height: '15rem'}}>
                                                    <SaturationPicker color={currentColor} src={node?.NodeAttachments[0].url} onColorChange={handleHueChange} 
                                                        label={node.MOFLayerNumber != 1 ? "change" : node.ParentChoiceName} isPickerAvailable={true || (!node.IsSyntaxFree && node.MOFLayerNumber != 3) || (node.IsSyntaxFree && node.MOFLayerNumber != 1)} 
                                                        style={{ height: ''}}></SaturationPicker>
                                            <div>

                                    </div>

                                            </div>}

                                    {((node.MOFLayerNumber !== 13) || (node.MOFLayerNumber === 0)) && node.OutputIsDocs && <div style={{width: '20em', position: 'absolute', top: '1em', right: '4.5em'}}>
                                        <SaturationPicker color={currentColor} src={node?.NodeAttachments[0].url} onColorChange={handleHueChange} 
                                                        label={node.MOFLayerNumber != 1 ? "change" : node.FQNChoiceName} isPickerAvailable={node.MOFLayerNumber != 3} 
                                                        style={{ height: ''}}></SaturationPicker>
                                    </div>}

                                    </div>
                                </td>
                                {node.MOFLayerNumber <= 0 && !node.OutputIsDocs && <td style={{width: '20em', position: 'relative'}}>
                                    <SaturationPicker label={node.InputChoiceFileName} color={mixedColor} src={node?.ToolAttachments[0].url} onColorChange={handleMixedColorChange} isPickerAvailable={true}></SaturationPicker>
                                </td>}
                            </tr>
                            <tr>
                                <td colSpan="2">
                                    <div class="output-node" style={{marginRight: 'auto', marginLeft: 'auto', maxWidth: '30em'}}>
                                        {node.ToolName ? (<span><strong></strong> {node.ToolName} </span>) : null}
                                        {node.InputChoiceFileName ? <span> -i<strong> {node.InputChoiceFileName}</strong></span> : null}
                                        {node.NodeDefaultFileName ? <span> -o<strong> {node.NodeDefaultFileName}</strong></span> : null}
                                    </div>
                                </td>
                            </tr>
                        </table>                                    
                    </td>
                </tr>
                {node.MOFLayerNumber === 1 && <tr>
                    <td class="flow-arrow" style={{textAlign: 'right'}}>↙</td>
                    <td class="flow-arrow" style={{textAlign: 'left'}}>↘</td>
                </tr>}
                {node.MOFLayerNumber === 3 && <tr>
                    <td colSpan="2" class="flow-arrow" style={{textAlign: 'center'}} onClick={pushExpectedColorForward}>⬇</td>
                </tr>}
                {/* <tr><td></td></tr> */}
                {/* Display children in separate cells if they exist */}
                {node.Children && node.Children.length > 0 && (
                    <tr>
                        {node.Children.map((childNode, index) => (                            
                            <React.Fragment>
                                {((childNode.MOFLayerNumber !== 1) || (index == selectedIndex)) ?
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
