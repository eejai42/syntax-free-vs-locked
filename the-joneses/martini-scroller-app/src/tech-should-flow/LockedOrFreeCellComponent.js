import React, { useEffect } from 'react';
import { useState } from 'react';
import SaturationPicker from './SaturationPicker';
import { renderAttachments } from '../colorUtils';

const LockedOrFreeCellComponent = ({ transpilerNode, isSyntaxLocked = false }) => {

  const [color, setColor] = useState(isSyntaxLocked ? transpilerNode.LockedColor : transpilerNode.SyntaxFreeColor);
  const [inSync, setInSync] = useState(isSyntaxLocked ? (transpilerNode.LockedColor === transpilerNode.ExpectedColor) : (transpilerNode.SyntaxFreeColor === transpilerNode.ExpectedColor) );


  useEffect(() => {
    if (isSyntaxLocked) {
      setInSync(transpilerNode.LockedColor === transpilerNode.ExpectedColor);
    } else {
      setInSync(transpilerNode.SyntaxFreeColor === transpilerNode.ExpectedColor);
    }
  }, [transpilerNode.LockedColor, transpilerNode.SyntaxFreeColor, transpilerNode.ExpectedColor, isSyntaxLocked]);


  const handleSaturationChange = (newSaturation) => {
    setColor(newSaturation);
  }

  const handleTranspilerNodeChange = (newTranspilerNode) => {
  }

  return (
    <div className={'transpiler-node ' + (inSync ? 'in-sync' : 'out-of-sync')} style={{
    }}>
      {(isSyntaxLocked == 0 || transpilerNode.LockedColor ) ?  
      (
        <div style={{position: 'relative'}}>
          <div>
            <SaturationPicker  transpilerNode={transpilerNode} showPictures={true} color={color} onChange={handleSaturationChange} onTranspilerNodeChange={handleTranspilerNodeChange} />
          </div>
    
            {!inSync && (
                <div className="stale">Stale Artifacts</div>
            )}
          <div style={{ display: 'flex', justifyContent: 'space-between' }}>
            {isSyntaxLocked ? (
              <div style={{width: '25em', textAlign: 'right'}}>
              </div>
            ) : (
              <div style={{width: '25em', textAlign: 'right'}}>
                {transpilerNode.FromEdgeFreeAttachments?.length ? renderAttachments(transpilerNode.FromEdgeFreeAttachments, transpilerNode.FromNodeName, transpilerNode.EdgeName, "FromEdgeFreeAttachments", 'right') : null}
                {transpilerNode.FreeTranspilerAttachments?.length ? renderAttachments(transpilerNode.FreeTranspilerAttachments, transpilerNode.FromNodeName, transpilerNode.EdgeName, "FreeTranspilerAttachments", 'right') : null}
              </div>
            )}
          </div>
          <div style={{ textAlign: 'right'}}>
            <strong>{transpilerNode.OutputFileName}</strong>
          </div>
          <div style={{ textAlign: 'right' }}>
            <strong>{transpilerNode.ToNodeType}</strong> {transpilerNode.ToNodeName}
          </div>
        </div>
      ) : (
        <div>Missing</div>
      )}
    </div>
  );
};

export default LockedOrFreeCellComponent;