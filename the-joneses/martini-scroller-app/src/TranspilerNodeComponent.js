import React from 'react';

const TranspilerNodeComponent = ({ transpilerItem, isSyntaxLocked = false }) => {
  const baseImageUrl = "transpiler-images"; // Base URL for images, adjust based on actual path

  const renderAttachments = (attachments, nodeName, edgeName, attachmentType) => {
    return (attachments?.length) ? (attachments.map((attachment, index) => (
      <div><img key={index}
          src={`${baseImageUrl}/${nodeName.replace(/ /g, '_')}/${edgeName.replace(/ /g, '_').replace(/#/g, '%23')}_${attachmentType}_${index}.png`}
          alt={`${attachmentType} Image`}
          style={{ margin: '0.5rem', width: '6rem' }}
        />
      </div>
    ))) : null;
  };

  return (
    <div className="transpiler-node" style={{
      border: '3px solid #eeeeee',
      minHeight: '23rem',
      margin: '1rem',
      padding: '1rem'
    }}>
      {(isSyntaxLocked == 0 || transpilerItem.LockedColor ) ?  (
<div>
      <div className="match-status" style={{
        backgroundColor: transpilerItem.SyntaxFreeColor,
        textAlign: 'center'
      }}>
        {transpilerItem.SyntaxFreeColor}
        {!transpilerItem.SyntaxFreeColor === transpilerItem.ExpectedColor && <div>Stale Artifacts</div>}
      </div>
      <div style={{ display: 'flex', justifyContent: 'space-between' }}>
        <div>
          {transpilerItem.TranspilerNodeAttachments && renderAttachments(transpilerItem.TranspilerNodeAttachments, transpilerItem.FromNodeName, transpilerItem.EdgeName, "TranspilerNodeAttachments")}
          <h4>{transpilerItem.TransformerNodeName}</h4>
        </div>
        <div>
          {transpilerItem.FromEdgeFreeAttachments && renderAttachments(transpilerItem.FromEdgeFreeAttachments, transpilerItem.FromNodeName, transpilerItem.EdgeName, "FromEdgeFreeAttachments")}
          {transpilerItem.FreeTranspilerAttachments && renderAttachments(transpilerItem.FreeTranspilerAttachments, transpilerItem.FromNodeName, transpilerItem.EdgeName, "FreeTranspilerAttachments")}
          {transpilerItem.ToNodeAttachments && renderAttachments(transpilerItem.ToNodeAttachments, transpilerItem.FromNodeName, transpilerItem.EdgeName, "ToNodeAttachments")}
        </div>
      </div>
      <div>
        <strong>{transpilerItem.OutputFileName}</strong>
      </div>
      <div style={{ textAlign: 'right' }}>
        <strong>{transpilerItem.ToNodeType}</strong> {transpilerItem.ToNodeName}
      </div>
    </div>) : (
        <div>Missing</div>
      )};
    </div>
  );
};

export default TranspilerNodeComponent;