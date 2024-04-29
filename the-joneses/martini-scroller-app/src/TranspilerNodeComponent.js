import React from 'react';

const TranspilerNodeComponent = ({ transpilerItem, syntaxLocked, rowKey }) => {
  const baseImageUrl = "transpiler-images"; // Base URL for images, should be adjusted based on actual path

  // Helper to generate image paths
  const imagePath = (attachmentName, index) => `${baseImageUrl}/${transpilerItem.FromNodeName.replace(/\s+/g, '_')}/${transpilerItem.EdgeName.replace(/\s+/g, '_').replace('#', '%23')}_${attachmentName}_${index}.png`;

  return (
    <div className="transpiler-node" style={{
      backgroundColor: syntaxLocked ? transpilerItem.LockedColor : transpilerItem.SyntaxFreeColor,
      border: '3px solid #eeeeee',
      minHeight: '23rem',
      margin: '1rem',
      padding: '1rem'
    }}>
        
      <div style={{ display: 'flex', marginBottom: '1rem' }}>
        {transpilerItem.FromNodeAttachments.map((attachment, index) => (
          <img key={index} src={imagePath('FromNodeAttachments', index)} alt="From Node Attachment" style={{ width: '10rem', marginRight: '1rem' }} />
        ))}
      </div>
      <h4>{transpilerItem.TransformerNodeName}</h4>
      <div style={{ color: transpilerItem.ExpectedColor, fontWeight: 'bold' }}>
        {transpilerItem.EdgeName}
      </div>
      <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginTop: '1rem' }}>
        <div>
          {transpilerItem.TranspilerNodeAttachments.map((attachment, index) => (
            <img key={index} src={imagePath('TranspilerNodeAttachments', index)} alt="Transpiler Node Attachment" style={{ width: '5rem', marginRight: '0.5rem' }} />
          ))}
        </div>
        <div>
          <strong>Output: </strong>{transpilerItem.OutputFileName}
          <div><strong>Type: </strong>{transpilerItem.ToNodeType} {transpilerItem.ToNodeName}</div>
        </div>
      </div>
      <div style={{ marginTop: '1rem', textAlign: 'right' }}>
        <span style={{ backgroundColor: syntaxLocked ? '#edfded' : '#fde3e3', padding: '0.5rem' }}>
          {syntaxLocked ? 'In Sync' : 'Out of Sync'}
        </span>
      </div>
    </div>
  );
};

export default TranspilerNodeComponent;
