import React, { useEffect } from 'react';
import { useState } from 'react';
import SaturationPicker from './SaturationPicker';
import { renderAttachments } from '../colorUtils';

const LockedOrFreeCellComponent = ({ transpilerNode, onUpdateClick, isSyntaxLocked = false }) => {

  const [inSync, setInSync] = useState(isSyntaxLocked ? (transpilerNode.LockedColor === transpilerNode.ExpectedColor) : (transpilerNode.SyntaxFreeColor === transpilerNode.ExpectedColor) );


  useEffect(() => {
    if (isSyntaxLocked) {
      setInSync(transpilerNode.LockedColor === transpilerNode.ExpectedColor);
    } else {
      setInSync(transpilerNode.SyntaxFreeColor === transpilerNode.ExpectedColor);
    }
  }, [transpilerNode.LockedColor, transpilerNode.SyntaxFreeColor, transpilerNode.ExpectedColor, isSyntaxLocked]);

  const handleUpdateClick = () => {
    if (onUpdateClick) {
      onUpdateClick(transpilerNode);
    }
  };

  return (
    <div className={'transpiler-node ' + (inSync ? 'in-sync' : 'out-of-sync')} style={{
    }}>
      {(isSyntaxLocked == 0 || transpilerNode.LockedColor ) ?  
      (
        <div style={{position: 'relative'}}>
    
          <div style={{ display: 'flex', justifyContent: 'space-between' }}>
            {isSyntaxLocked ? (
              <div>
                              {!inSync && (
                      <div class="stale" onClick={handleUpdateClick}>Stale Artifacts</div>
                  )}

              <div style={{width: '5em', float: 'right', backgroundColor: transpilerNode.LockedColor}}>
                FOO
              </div>
              </div>
            ) : (
              <div>
              <div style={{width: '5em', left: 'right', backgroundColor: transpilerNode.SyntaxFreeColor}}>
                FOO
              </div>

              <table>
                <tbody>
                {!inSync && (
                      <tr><td class="stale"  onClick={handleUpdateClick}>Stale Artifacts</td></tr>
                  )}
                  <tr>
                    <td>
                    {transpilerNode.FromEdgeFreeAttachments?.length ? renderAttachments(transpilerNode.FromEdgeFreeAttachments, transpilerNode.FromNodeName, transpilerNode.EdgeName, "FromEdgeFreeAttachments", 'right') : null}
                    </td>
                    <td>
                    {transpilerNode.FreeTranspilerAttachments?.length ? renderAttachments(transpilerNode.FreeTranspilerAttachments, transpilerNode.FromNodeName, transpilerNode.EdgeName, "FreeTranspilerAttachments", 'right') : null}
                    </td>
                    <td>
                    {transpilerNode.ToNodeAttachments?.length ? renderAttachments(transpilerNode.ToNodeAttachments, transpilerNode.FromNodeName, transpilerNode.EdgeName, "ToNodeAttachments", 'right') : null}

                    </td>
                  </tr>
            

                  <tr>
                  <td>
                  {transpilerNode.SyntaxFreeEdgeOutputFileName} ➡  
                    </td>
                    <td>
                    {transpilerNode.FreeTranspilerNodeName}                      
                    </td>
                    <td>
                    {transpilerNode.OutputFileName}                      
                    </td>

                  </tr>
                </tbody>
              </table>
              </div>

            )}
          </div>
        </div>
      ) : (
        <div>Missing</div>
      )}
    </div>
  );
};

export default LockedOrFreeCellComponent;