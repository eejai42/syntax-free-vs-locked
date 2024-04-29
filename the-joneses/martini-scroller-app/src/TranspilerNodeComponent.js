import React from 'react';

const TranspilerNodeComponent = ({ transpilerItem, isSyntaxLocked = false }) => {
  const baseImageUrl = "transpiler-images"; // Base URL for images, adjust based on actual path

  const renderAttachments = (attachments, nodeName, edgeName, attachmentType, float = 'left') => {
    if (!(attachments?.length)) return null;
    return (attachments?.length) ? (attachments.map((attachment, index) => (
      <img key={index}
          src={`${baseImageUrl}/${nodeName.replace(/ /g, '_')}/${edgeName.replace(/ /g, '_').replace(/#/g, '%23')}_${attachmentType}_${index}.png`}
          alt={`${attachmentType} Image`}
          style={{ margin: '0.5rem', width: '6rem', float: {float} }}
        />      
    ))) : null;
  };

  // This function chooses between locked and free attachments based on isSyntaxLocked
  const getAttachments = (locked, free) => {
    return isSyntaxLocked ? locked : free;
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

        {isSyntaxLocked ? (
          <div style={{width: '25em', textAlign: 'right'}}>
            {transpilerItem.LockedAttachments?.length ? renderAttachments(transpilerItem.LockedAttachments, transpilerItem.FromNodeName, transpilerItem.EdgeName, "LockedAttachments", 'right') : null}
          </div>
        ) : (
          <div style={{width: '25em', textAlign: 'right'}}>
            {transpilerItem.FromEdgeFreeAttachments?.length ? renderAttachments(transpilerItem.FromEdgeFreeAttachments, transpilerItem.FromNodeName, transpilerItem.EdgeName, "FromEdgeFreeAttachments", 'right') : null}
            {transpilerItem.FreeTranspilerAttachments?.length ? renderAttachments(transpilerItem.FreeTranspilerAttachments, transpilerItem.FromNodeName, transpilerItem.EdgeName, "FreeTranspilerAttachments", 'right') : null}
            {transpilerItem.ToNodeAttachments?.length ? renderAttachments(transpilerItem.ToNodeAttachments, transpilerItem.FromNodeName, transpilerItem.EdgeName, "ToNodeAttachments", 'right') : null}
          </div>
        )}
      </div>
      <div style={{ textAlign: 'right'}}>
        <strong>{transpilerItem.OutputFileName}</strong>
      </div>
      <div style={{ textAlign: 'right' }}>
        <strong>{transpilerItem.ToNodeType}</strong> {transpilerItem.ToNodeName}
      </div>
    </div>) : (
        <div>Missing</div>
      )}
    </div>
  );
};

export default TranspilerNodeComponent;