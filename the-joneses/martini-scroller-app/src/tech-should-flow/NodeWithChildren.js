import React, { useEffect, useState } from "react";
import SaturationPicker from "./SaturationPicker";
import { getContrastColor, mixColors } from "../colorUtils";

const NodeWithChildren = ({ node, selectedIndex }) => {
  const [nodeDesiredColor, setNodeDesiredColor] = useState(
    node.MOFLayerNumber != 13 ? node.NodeDesiredColor || "#000000" : "#FFFFFF"
  );
  const [mixedColor, setMixedColor] = useState(node.MixedColor || "#000000");
  const [parentColor, setParentColor] = useState(node.ParentNodeDesiredColor || "#000000");
  const [desiredColor, setDesiredColor] = useState(node.DesiredColor || "#000000");

  useEffect(() => {
    setNodeDesiredColor(node.NodeDesiredColor || "#000000");
  }, [node.NodeDesiredColor]);

  const handleNodeDesiredColorChange = (color) => {
    setNodeDesiredColor(color);
    if (node.MOFLayerNumber === 0) {
        setMixedColor(mixColors(color, desiredColor));
    } else {
        setMixedColor(color);    
    }
  };

  const handleDesiredColorChange = (color) => { 
    setDesiredColor(color);
    if (node.MOFLayerNumber === 0) {
        setMixedColor(mixColors(color, nodeDesiredColor));
    } else {
        setMixedColor(color);    
    }
};

  const pushExpectedColorForward = () => {
    console.error(
      "Pushing expected color forward",
      nodeDesiredColor,
      mixedColor,
      node,
      node.Children[selectedIndex]
    );
    node.Children[selectedIndex].MixedColor = nodeDesiredColor; // This directly mutates the node, consider updating state in a more React-friendly way
  };

  return (
    <table className="node-table">
      <tbody>
        {/* Display the current node's main details */}
        <tr>
          <td
            colSpan={(node.Children ? node.Children.length * 2 : 1) + 1}
            style={{ border: "none" }}
          >
            <table class="node-header">
              <tr>

                {/* Inner (left orient) RIGHT side of screen */}
                
                {node.MOFLayerNumber <= 0 && node.OutputIsDocs && (
                  <td style={{ width: "20em", position: "relative"}}>
                    <div style={{ backgroundColor: desiredColor, color: getContrastColor(desiredColor), borderRadius: '2em', margin: '0.5em', marginTop: '0em' }}>
                    {node.ToolTransformerFileName || node.ToolName || node.NodeDefaultFileName}
                    <SaturationPicker
                      color={desiredColor}
                      src={node?.ToolAttachments[0].url}
                      onColorChange={handleDesiredColorChange}
                      isPickerAvailable={true}
                      style={{ height: "" }}
                    ></SaturationPicker>
                    </div>
                  </td>
                )}
                <td>
                  <div
                    style={{
                      position: "relative",
                      height: node.MOFLayerNumber === 1 ? "14em" : "14em",
                      border:
                        node.MOFLayerNumber < 2 ? "solid black 1px" : "none",
                      backgroundColor: nodeDesiredColor,
                      color: getContrastColor(nodeDesiredColor),
                      maxWidth: "35em",
                      marginLeft: "auto",
                      marginRight: "auto",
                    }}
                  >
                    {/* LEFT  Node - CODE*/}
                    {(node.MOFLayerNumber === 0) && !node.OutputIsDocs && (
                        <div
                          style={{
                            width: "20em",
                            position: "absolute",
                            top: "1em",
                            left: "2.5em",
                          }}
                        >
                          <SaturationPicker
                            color={nodeDesiredColor}
                            src={node?.NodeAttachments[0].url}
                            onColorChange={handleNodeDesiredColorChange}
                            label={
                              node.MOFLayerNumber != 1
                                ? "change"
                                : node.ParentChoiceName
                            }
                            isPickerAvailable={node.MOFLayerNumber != 3}
                            style={{ height: "" }}
                          ></SaturationPicker>
                        </div>
                      )}

                    <h3>
                      {node.FQNChoiceName} 
                    </h3>
                    {/* MIDDLE - Center Aligned Picker*/}

                    {(node.MOFLayerNumber >= 1) && (
                      <div
                        style={{
                          width: "55%",
                          marginLeft: "auto",
                          marginRight: "auto",
                          height: "15rem",
                        }}
                      >
                        <SaturationPicker
                          color={nodeDesiredColor}
                          src={node?.NodeAttachments[0].url}
                          onColorChange={handleNodeDesiredColorChange}
                          label={
                            node.MOFLayerNumber != 1
                              ? "change"
                              : node.ParentChoiceName
                          }
                          isPickerAvailable={
                            true ||
                            (!node.IsSyntaxFree && node.MOFLayerNumber != 3) ||
                            (node.IsSyntaxFree && node.MOFLayerNumber != 1)
                          }
                          style={{ height: "" }}
                        ></SaturationPicker>
                        <div></div>
                      </div>
                    )}                    

                    {/* RIGHT  Node*/}
                    {(node.MOFLayerNumber === 0) && node.OutputIsDocs && (
                        <div
                          style={{
                            width: "20em",
                            position: "absolute",
                            top: "1em",
                            right: "2.5em",
                          }}
                        >
                          <SaturationPicker
                            color={nodeDesiredColor}
                            src={node?.NodeAttachments[0].url}
                            onColorChange={handleNodeDesiredColorChange}
                            label={
                              node.MOFLayerNumber != 1
                                ? "change"
                                : node.FQNChoiceName
                            }
                            isPickerAvailable={node.MOFLayerNumber != 3}
                            style={{ height: "" }}
                          ></SaturationPicker>{" "}
                        </div>
                      )}
                  </div>
                </td>
                
                {/* inner RIGHT oriented, LEFT side of screen*/}
                
                {node.MOFLayerNumber <= 0 && !node.OutputIsDocs && (
                  <td style={{ width: "20em", position: "relative"}}>
                    <div style={{ backgroundColor: desiredColor, borderRadius: '2em', margin: '0.5em', marginTop: '0em' }}>

                        <SaturationPicker
                        label={node.InputChoiceFileName}
                        color={desiredColor}
                        src={node?.ToolAttachments[0].url}
                        onColorChange={handleDesiredColorChange}
                        isPickerAvailable={true}
                        ></SaturationPicker>                
                    </div>
                  </td>
                )}
              </tr>
              <tr>
                <td colSpan="2">
                  <div
                    class="output-node"
                    style={{
                      marginRight: "auto",
                      marginLeft: "auto",
                      maxWidth: "30em",
                      backgroundColor: mixedColor,
                      color: getContrastColor(mixedColor),
                    }}
                  >
                    {node.InputChoiceFileName ? (
                      <span>
                        {" "}
                        with <strong> {node.InputChoiceFileName}</strong>
                      </span>
                    ) : null}
                    {node.ToolName ? (
                      <span>
                        <strong></strong> {node.ToolName}{" "}
                      </span>
                    ) : null}
                    {node.NodeDefaultFileName ? (
                      <span>
                        {" "}
                        creates <strong> {node.NodeDefaultFileName}</strong>
                      </span>
                    ) : null}
                  </div>
                </td>
              </tr>
            </table>
          </td>
        </tr>
        {node.MOFLayerNumber === 1 && (
          <tr>
            <td
              class="flow-arrow"
              style={{
                textAlign: "right",
                color: node.IsSyntaxFree ? "green" : "orange",
              }}
            >
              ↙
            </td>
            <td
              class="flow-arrow"
              style={{
                textAlign: "left",
                color: node.IsSyntaxFree ? "green" : "orange",
              }}
            >
              ↘
            </td>
          </tr>
        )}
        {node.MOFLayerNumber === 3 && (
          <tr>
            <td
              colSpan="6"
              class="flow-arrow"
              style={{
                textAlign: "center",
                color: node.IsSyntaxFree ? "green" : "orange",
              }}
              onClick={pushExpectedColorForward}
            >
              ⬇
            </td>
          </tr>
        )}
        {/* <tr><td></td></tr> */}
        {/* Display children in separate cells if they exist */}
        {node.Children && node.Children.length > 0 && (
          <tr>
            {node.Children.map((childNode, index) => (
              <React.Fragment>
                {childNode.MOFLayerNumber !== 1 || index == selectedIndex ? (
                  <td
                    key={childNode.NodeName}
                    style={{
                      width: childNode.MOFLayerNumber == 0 ? "50%" : "100%",
                    }}
                  >
                    <table style={{ width: "100%" }}>
                      <tr>
                        <td>
                          <NodeWithChildren node={childNode} />
                        </td>
                      </tr>
                    </table>
                  </td>
                ) : (
                  <td key={childNode.NodeName} style={{ border: "none" }}></td>
                )}
              </React.Fragment>
            ))}
          </tr>
        )}
      </tbody>
    </table>
  );
};

export default NodeWithChildren;
