import React, { useState, useEffect } from "react";
import "./TechShouldFlow.css";
import ViewChoices from "./ViewChoices";
import { HexColorPicker } from "react-colorful";

const TechShouldFlowPage = ({ mofData, syntaxLockedChoices, syntaxFreeChoices }) => {

  const [showSyntaxFree, setShowSyntaxFree] = useState(false);
  const [selectedIndex, setSelectedIndex] = useState(0);
  const toggleShow = () => {
    setShowSyntaxFree(!showSyntaxFree);
  };
  return (
    <div>
      <div style={{position: 'absolute', left: '1em', width: '15em'}}>
        <select value={selectedIndex} onChange={(e) => setSelectedIndex(e.target.value)}>
          <option value={0}>v1</option>
          <option value={1}>v2</option>
          <option value={2}>GarageDoor</option>
        </select>
      </div>

      {!showSyntaxFree ? (<div>
          <img src="parchment.png"  className="EraIcon" style={{left: '1em', zIndex: 99999999999, fontSize: '1.6em' }} />    
          <div style={{position: 'absolute', right: '0em', width: '15em'}}>

          <img src="e-everything.png"  className="switch-icon" /> 
            <label className="switch" style={{float: 'left'}}>
              <input type="checkbox" checked={showSyntaxFree} onChange={toggleShow}  style={{marginTop: '-2em'}}/>
              <span className="slider round"></span>
            </label>
            <div style={{marginTop: '0.5rem', marginLeft: '7.5em'}}>
              Syntax Free
            </div>
          </div>
      </div>) : null}

      {showSyntaxFree ? (<div>
        <img src="e-everything.png" className="EraIcon" style={{zIndex: 99999999999, fontSize: '1.6em' }} />
        {/* <img src="e-everything.png" className="EraIcon" style={{top: '-0.5em', left: '-1em', zIndex: 99999999999, fontSize: '1.6em' }} />     */}
          <div style={{position: 'absolute', right: '0em', width: '15em'}}>
            <img src="parchment.png"  className="switch-icon" /> 

            <label className="switch" style={{float: 'left'}}>
              <input type="checkbox" checked={showSyntaxFree} onChange={toggleShow}  style={{marginTop: '-2em'}}/>
              <span className="slider round"></span>
            </label>
            <div style={{marginTop: '0.5rem', marginLeft: '7.5em'}}>Syntax Free</div>
          </div>
           {/*     

          <div style={{position: 'absolute', left: '67em', width: '15em', verticalAlign: 'top'}}>
            <label className="switch">        
                <input type="checkbox" checked={showSyntaxFree} onChange={toggleShow}  style={{marginTop: '-2em'}}/>
                <span className="slider round"></span>
              </label>
              <div style={{marginTop: '0.5rem', marginLeft: '5em'}}>
              Syntax Free
            </div>
          </div> */}
      </div>) : null}

      <h1>Technology Should Flow</h1>

      <table className="main-table">
        <tbody>
          <tr>
            {!showSyntaxFree ? (<td><div><ViewChoices mofData={mofData} choices={syntaxLockedChoices} selectedIndex={selectedIndex} isSyntaxFree={false}></ViewChoices> </div></td>) : null}
            {showSyntaxFree ? (<td><div><ViewChoices mofData={mofData} choices={syntaxFreeChoices} selectedIndex={selectedIndex} isSyntaxFree={true}></ViewChoices> </div></td>) : null}
          </tr>
        </tbody>
      </table>
    </div>
  );
};

export default TechShouldFlowPage;
