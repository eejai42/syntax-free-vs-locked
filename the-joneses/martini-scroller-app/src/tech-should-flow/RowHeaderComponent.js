import React, { useState } from "react";
import SaturationPicker from "./SaturationPicker";
import { getContrastColor, renderAttachments } from "../colorUtils";

const RowHeaderComponent = ({
  transpilerNode,
  onTranspilerNodeChange,
  onUpdateClick,
}) => {
  const baseImageUrl = "transpiler-images"; // Base URL for images, should be adjusted based on actual path

  // Helper to generate image paths
  const imagePath = (attachmentName, index) =>
    `${baseImageUrl}/${transpilerNode.FromNodeName.replace(
      /\s+/g,
      "_"
    )}/${transpilerNode.EdgeName.replace(/\s+/g, "_").replace(
      "#",
      "%23"
    )}_${attachmentName}_${index}.png`;

  const handleColorCHange = (newColor) => {
    // Handle saturation change

    if (onTranspilerNodeChange) {
      onTranspilerNodeChange(transpilerNode, newColor);
    }
  };

  const handleUpdateClick = () => {
    if (onUpdateClick) {
      onUpdateClick(transpilerNode);
    }
  };

  return (
    <table
      style={{
        width: "40em",
        position: "relative",
        backgroundColor: transpilerNode.ExpectedColor,
        color: getContrastColor(transpilerNode.ExpectedColor),
      }}
    >
      <tbody>
        <tr>
          <td>
            {transpilerNode.FromNodeAttachments &&
              transpilerNode.FromNodeAttachments.map((attachment, index) => (
                <div key={index}>
                  <img
                    src={imagePath("FromNodeAttachments", index)}
                    alt="From Node Attachment Image"
                    className="from-node-attachment"
                  />
                </div>
              ))}
            <div
              style={{
                color: "white",
                fontWeight: "bold",
                textAlign: "center",
              }}
            >
              {transpilerNode.FromNodeName}{" "}
              {transpilerNode.IsUsed === 0 && " (unused)"} ➡
            </div>
          </td>
          <td colSpan="2" style={{ textAlign: "center", width: "40%" }}>
            {transpilerNode.TranspilerNodeAttachments &&
              renderAttachments(
                transpilerNode.TranspilerNodeAttachments,
                transpilerNode.FromNodeName,
                transpilerNode.EdgeName,
                "TranspilerNodeAttachments"
              )}
            <h4>{transpilerNode.TransformerNodeName}</h4>
          </td>
          <td>
            <div style={{ backgroundColor: transpilerNode.ToNodeMasterColor }}>
              {transpilerNode.ToNodePlatformAttachments.map(
                  (attachment, index) => (
                    <div key={index}>
                  {<SaturationPicker
                    color={transpilerNode.ExpectedColor}
                    isPickerAvailable={!transpilerNode.SyntaxFreeEdgeName}
                    onColorChange={handleColorCHange}
                    label={transpilerNode.EdgeName}
                    src={imagePath("ToNodePlatformAttachments", index)}
                    />}
                    </div>
                  )
                )}
            </div>
          </td>
        </tr>
        <tr>
          <td
            colSpan="3"
            onClick={handleUpdateClick}
            style={{ cursor: "pointer", textAlign: "center" }}
          >
            {" "}
            ⬅ Update Now ➡
          </td>
        </tr>
        <tr>
          <td></td>
          <td colSpan="1"></td>
          <td></td>
          <td>
            <div
              style={{
                color: "white",
                fontWeight: "bold",
                textAlign: "center",
              }}
            >
              {transpilerNode.EdgeName}
            </div>
          </td>
        </tr>
        {!transpilerNode.SyntaxFreeEdgeName && (
          <tr>
            <td colSpan="3"></td>
          </tr>
        )}
        ;
      </tbody>
    </table>
  );
};

export default RowHeaderComponent;
