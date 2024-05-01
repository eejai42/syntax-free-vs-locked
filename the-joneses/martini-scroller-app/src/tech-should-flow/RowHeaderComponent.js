import React, { useState } from 'react';
import SaturationPicker from './SaturationPicker';
import { getContrastColor, renderAttachments } from '../colorUtils';

const RowHeaderComponent = ({ transpilerNode, onColorChange }) => {
  const baseImageUrl = "transpiler-images"; // Base URL for images, should be adjusted based on actual path

  const [color, setColor] = useState(transpilerNode.ExpectedColor);

  // Helper to generate image paths
  const imagePath = (attachmentName, index) => `${baseImageUrl}/${transpilerNode.FromNodeName.replace(/\s+/g, '_')}/${transpilerNode.EdgeName.replace(/\s+/g, '_').replace('#', '%23')}_${attachmentName}_${index}.png`;

  const handleColorCHange = (newColor) => {
    // Handle saturation change
    if (newColor === color) return;
    
    setColor(newColor);
    if (onColorChange) {
      onColorChange(transpilerNode, newColor);
    }
  }

  return (
    <table style={{
      width: '40em',
      position: 'relative',
      backgroundColor: color,
      color: getContrastColor(color),

    }}><tbody>
    
        <tr>
        <td colSpan="2" style={{textAlign: 'center'}}>
        {transpilerNode.TranspilerNodeAttachments && renderAttachments(transpilerNode.TranspilerNodeAttachments, transpilerNode.FromNodeName, transpilerNode.EdgeName, "TranspilerNodeAttachments")}
            <h4>{transpilerNode.TransformerNodeName}</h4>
        </td>
        <td>
        {transpilerNode.FromNodeAttachments && transpilerNode.FromNodeAttachments.map((attachment, index) => (
          <img
            key={index}
            src={imagePath('FromNodeAttachments', index)}
            alt="From Node Attachment Image"
            className="from-node-attachment"
          />
        ))}
        <div style={{ color: 'white', fontWeight: 'bold', textAlign: 'center' }}>
          {transpilerNode.FromNodeName} {transpilerNode.IsUsed === 0 && ' (unused)'} ➡
        </div>

        </td>
        <td>
        <div style={{backgroundColor: transpilerNode.ToNodeMasterColor}}>
          {transpilerNode.ToNodePlatformAttachments && transpilerNode.ToNodePlatformAttachments.map((attachment, index) => (
            <img
              key={index}
              src={imagePath('ToNodePlatformAttachments', index)}
              alt="To Node Platform Attachment Image"
              className="platform-image"
            />
          ))}
        </div>

        </td>
        </tr>
      <tr>
      <td>


</td>
        <td colSpan="1">
</td>
<td></td>
<td>
              
      <div style={{ color: 'white', fontWeight: 'bold', textAlign: 'center' }}>
            {transpilerNode.EdgeName}
          </div>

        </td></tr>
        <tr><td colSpan="3">
        <div>
            <SaturationPicker  transpilerNode={transpilerNode} showPictures={true} color={color} onChange={handleColorCHange}  />
          </div>

          </td></tr>
        </tbody>
    </table>

  );
};

export default RowHeaderComponent;
