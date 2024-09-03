import React, { useEffect, useState } from "react";
import SaturationPicker from "./SaturationPicker";
import { getContrastColor, mixColors } from "../colorUtils";

const NodeWithChildren = ({ node, selectedIndex }) => {
  const [nodeDesiredColor, setNodeDesiredColor] = useState(
    node.MOFLayerNumber != 13 ? node.NodeDesiredColor || "#000000" : "#FFFFFF"
  );
  const [mixedColor, setMixedColor] = useState(node.MixedColor || "#000000");
  const [desiredColor, setDesiredColor] = useState(
    node.DesiredColor || "#000000"
  );
  const [isPicking, setIsPicking] = useState(false);

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
  const handleIsPickingChange = (isPicking) => {
    setIsPicking(isPicking);
  };

  const pushExpectedColorForward = (left = true) => {
    console.error(
      "Pushing expected color forward",
      nodeDesiredColor,
      mixedColor,
      node,
      selectedIndex ? node?.Children[selectedIndex] : node?.Children[left ? 0 : 1]
    );
  };

  return (
    <table className="node-table">
      {node.MOFLayerNumber != 3 && (
      <tbody>
        {/* Display the current node's main details */}
        <tr>
          <td
            colSpan={(node.Children ? node.Children.length * 2 : 1) + 1}
            style={{ border: "none" }}
          >
            <table className="node-header">
      <tbody>

              <tr>
                {/* Inner (left orient) RIGHT side of screen */}

                {node.MOFLayerNumber <= 0 && node.OutputIsDocs && (
                 <td style={{ width: "20em", position: "relative" }}>
                 <div
                   style={{
                     backgroundColor: desiredColor,
                     color: getContrastColor(desiredColor),
                     borderRadius: "2em",
                     margin: "0.5em",
                     marginTop: "0em",
                   }}
                 >
                   <SaturationPicker
                     color={desiredColor}
                     src={node?.ToolAttachments[0].url}
                     onColorChange={handleDesiredColorChange}
                     node={node}
                     isPickerAvailable={true}
                     onIsPickingChange={handleIsPickingChange}
                     style={{ height: "" }}
                   ></SaturationPicker>
                 </div>
               </td>
                )}
                <td>
                  <div
                    style={{
                      position: "relative",
                      height: node.MOFLayerNumber >= 1 ? "12em" : "15em",
                      border:
                        node.MOFLayerNumber < 2 ? "solid black 1px" : "none",
                      backgroundColor: nodeDesiredColor,
                      color: getContrastColor(nodeDesiredColor),
                      maxWidth: "35em",
                      marginLeft: "auto",
                      marginRight: "auto",
                    }}
                  >
                    {/* LEFT  Node - Source Code */}

                    {node.MOFLayerNumber === 0 && !node.OutputIsDocs && (
                      <div
                        style={{
                          width: "20em",
                          position: "absolute",
                          top: "0em",
                          left: "2.5em",
                        }}
                      >
                        <SaturationPicker
                          color={nodeDesiredColor}
                          label={node.NodeDefaultFileName}
                          src={node?.NodeAttachments[0].url}
                          onColorChange={handleNodeDesiredColorChange}
                          onIsPickingChange={handleIsPickingChange}
                          node={node}
                          isPickerAvailable={node.MOFLayerNumber != 3}
                          style={{ height: "" }}
                        ></SaturationPicker>
                      </div>
                    )}

                    {/* <h3>{node.FQNChoiceName}</h3> /*}
                    {/* MIDDLE - Center Aligned Picker*/}

                    {node.MOFLayerNumber >= 1 && (
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
                          onIsPickingChange={handleIsPickingChange}
                          node={node}
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

                    {/* RIGHT  Node - Documentation*/}
                    {node.MOFLayerNumber === 0 && node.OutputIsDocs && (
                      <div
                        style={{
                          width: "20em",
                          position: "absolute",
                          top: "0em",
                          right: "2.5em",
                        }}
                      >
                        <SaturationPicker
                          color={nodeDesiredColor}
                          src={node?.NodeAttachments[0].url}
                          onColorChange={handleNodeDesiredColorChange}
                          onIsPickingChange={handleIsPickingChange}
                          node={node}
                          label={node.NodeDefaultFileName}
                          isPickerAvailable={node.MOFLayerNumber != 3}
                          style={{ height: "" }}
                        ></SaturationPicker>{" "}
                      </div>
                    )}
                  </div>
                </td>

                {/* inner RIGHT oriented, LEFT side of screen*/}
                {node.MOFLayerNumber === 0 && !node.OutputIsDocs && (
                  <td style={{ width: "20em", position: "relative" }}>
                    <div
                      style={{
                        backgroundColor: desiredColor,
                        borderRadius: "2em",
                        margin: "0.5em",
                        marginTop: "0em",
                      }}
                    >

                      <SaturationPicker
                          node={node}
                        color={desiredColor}
                        src={node?.ToolAttachments[0].url}
                        onColorChange={handleDesiredColorChange}
                        onIsPickingChange={handleIsPickingChange}
                        isPickerAvailable={true}
                      ></SaturationPicker>
                    </div>
                  </td>
                )}
              </tr>
                <tr>
                  <td colSpan="2">
                    <div
                      className="output-node"
                      style={{
                        marginRight: "auto",
                        marginLeft: "auto",
                        maxWidth: "40em",
                        minHeight: "3em",
                        backgroundColor: mixedColor,
                        color: getContrastColor(mixedColor),
                      }}
                    >
{node.IsSyntaxFree && node.ToolPlatformAttachments && node.ToolPlatformAttachments.length > 0 && (<div>
    <img src={node.ToolPlatformAttachments[0].url} style={{width: '2em', height: '2em', float: 'left', marginRight: '0.5em'}} />
                        </div>)}

                    {!isPicking && (<div>

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
                          creates the{" "}
                          <strong> {node.NodeName}</strong>
                        </span>
                      ) : null}
                    </div>)}

                    </div>
                  </td>
                </tr>

                </tbody>
            </table>
          </td>
        </tr>
        
        {node.MOFLayerNumber === 1 && (
          <tr>
            <td
              className="flow-arrow"
              style={{
                textAlign: "right",
                color: node.IsSyntaxFree ? "green" : "orange",
              }}
              onClick={pushExpectedColorForward}
            >
              ↙
            </td>
            <td
              className="flow-arrow"
              style={{
                textAlign: "left",
                color: node.IsSyntaxFree ? "green" : "orange",
              }}
              onClick={pushExpectedColorForward}
            >
              ↘
            </td>
          </tr>
        )}
        {node.MOFLayerNumber === 33 && (
          <tr>
            <td
              colSpan="6"
              className="flow-arrow"
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
        </tbody>)}
        <tbody>
        {/* <tr><td></td></tr> */}
        {/* Display children in separate cells if they exist */}
        {node.Children && node.Children.length > 0 && (
          <tr>
            {node.Children.map((childNode, index) => (
              <React.Fragment key={childNode.NodeName}>
                {childNode.MOFLayerNumber !== 1 || index == selectedIndex ? (
                  <td
                    style={{
                      width: childNode.MOFLayerNumber == 0 ? "50%" : "100%",
                    }}
                  >
                    <table style={{ width: "100%" }}>
      <tbody>

                      <tr>
                        <td>
                          <NodeWithChildren node={childNode} />
                        </td>
                      </tr>
      </tbody>

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
