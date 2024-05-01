import React from 'react';
import SaturationPicker from './SaturationPicker';
import { renderAttachments } from '../colorUtils';

const RowHeaderComponent = ({ transpilerNode, color = transpilerNode.ExpectedColor }) => {
  const baseImageUrl = "transpiler-images"; // Base URL for images, should be adjusted based on actual path

  // Helper to generate image paths
  const imagePath = (attachmentName, index) => `${baseImageUrl}/${transpilerNode.FromNodeName.replace(/\s+/g, '_')}/${transpilerNode.EdgeName.replace(/\s+/g, '_').replace('#', '%23')}_${attachmentName}_${index}.png`;

  const handleSaturationChange = (newSaturation) => {
    // Handle saturation change
    console.error("new Saturation: ", newSaturation);
  }

  const handleTranspilerNodeChange = (newTranspilerNode) => { 
    // Handle transpiler item change
    console.error("new Transpiler Item: ", newTranspilerNode);
  }

  return (
    <table style={{
      width: '40em',
      position: 'relative',

    }}><tbody>
    
        <tr>
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
          <td colSpan="2" style={{textAlign: 'center'}}>
        {transpilerNode.TranspilerNodeAttachments && renderAttachments(transpilerNode.TranspilerNodeAttachments, transpilerNode.FromNodeName, transpilerNode.EdgeName, "TranspilerNodeAttachments")}
            <h4>{transpilerNode.TransformerNodeName}</h4>
</td></tr>
      <tr>
      <td>

{transpilerNode.ToNodeAttachments?.length ? renderAttachments(transpilerNode.ToNodeAttachments, transpilerNode.FromNodeName, transpilerNode.EdgeName, "ToNodeAttachments", 'right') : null}

</td>
        <td colSpan="1">
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
<td></td>
<td>
              
      <div style={{ color: 'white', fontWeight: 'bold', textAlign: 'center' }}>
            {transpilerNode.EdgeName}
          </div>

        </td></tr></tbody>
    </table>

  );
};

export default RowHeaderComponent;
