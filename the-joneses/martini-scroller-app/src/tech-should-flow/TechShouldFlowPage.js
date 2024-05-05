import React, { useState, useEffect } from "react";
import "./TechShouldFlow.css";
import ViewChoices from "./ViewChoices";

const TechShouldFlowPage = ({ mofData, syntaxLockedChoices, syntaxFreeChoices }) => {

  const [showSyntaxFree, setShowSyntaxFree] = useState(false);
  const toggleShow = () => {
    setShowSyntaxFree(!showSyntaxFree);
  };
  return (
    <div>
      <h1>Technology Should Flow</h1>

      <div>
          <img src="parchment.png"  className="EraIcon" style={{top: '-0.5em', left: '-1em', zIndex: 99999999999, fontSize: '1.6em' }} />    
          <div style={{position: 'absolute', left: '69em', width: '8em'}}>
            <a onClick={toggleShow}><img src="e-everything.png"  className="EraIcon" style={{width: '2em', height: '2em'}} /> Syntax Free</a>
          </div>
      </div>

      <table className="main-table">
        <tbody>
          <tr>
            {!showSyntaxFree ? (<td><div><ViewChoices mofData={mofData} choices={syntaxLockedChoices} isSyntaxLocked={false}></ViewChoices> </div></td>) : null}
            {showSyntaxFree ? (<td><div><ViewChoices mofData={mofData} choices={syntaxFreeChoices} isSyntaxLocked={true}></ViewChoices> </div></td>) : null}
          </tr>
        </tbody>
      </table>
    </div>
  );
};

export default TechShouldFlowPage;
