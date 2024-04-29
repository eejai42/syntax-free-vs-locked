import React from 'react';

const TranspilerRowHeaderComponent = ({ transpilerItem }) => {
  const baseImageUrl = "transpiler-images"; // Base URL for images, should be adjusted based on actual path

  // Helper to generate image paths
  const imagePath = (attachmentName, index) => `${baseImageUrl}/${transpilerItem.FromNodeName.replace(/\s+/g, '_')}/${transpilerItem.EdgeName.replace(/\s+/g, '_').replace('#', '%23')}_${attachmentName}_${index}.png`;

  return (
    <div className="transpiler-node" style={{
      backgroundColor: transpilerItem.ExpectedColor,
      border: '3px solid #eeeeee',
      minHeight: '23rem',
      width: '12em',
      padding: '1rem'
    }}>
      {transpilerItem.FromNodeAttachments && transpilerItem.FromNodeAttachments.map((attachment, index) => (
        <img
          key={index}
          src={imagePath('FromNodeAttachments', index)}
          alt="From Node Attachment Image"
          className="from-node-attachment"
          style={{ width: '100%', marginBottom: '0.5rem' }}
        />
      ))}
      <div style={{ color: 'white', fontWeight: 'bold', textAlign: 'center' }}>
        {transpilerItem.FromNodeName} {transpilerItem.IsUsed === 0 && ' (unused)'} ➡
      </div>
      {transpilerItem.ToNodePlatformAttachments && transpilerItem.ToNodePlatformAttachments.map((attachment, index) => (
        <img
          key={index}
          src={imagePath('ToNodePlatformAttachments', index)}
          alt="To Node Platform Attachment Image"
          className="platform-image"
          style={{ width: '50%', margin: '0.5rem' }}
        />
      ))}
      <div style={{ color: 'white', fontWeight: 'bold', textAlign: 'center' }}>
        {transpilerItem.EdgeName}
      </div>
    </div>
  );
};

export default TranspilerRowHeaderComponent;
