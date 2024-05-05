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

      {!showSyntaxFree ? (<div>
          <img src="parchment.png"  className="EraIcon" style={{top: '-0.5em', left: '-1em', zIndex: 99999999999, fontSize: '1.6em' }} />    
          <div style={{position: 'absolute', left: '69em', width: '8em'}}>
            <a onClick={toggleShow}><img src="e-everything.png"  className="EraIcon" style={{width: '2em', height: '2em'}} /> Syntax Free</a>
          </div>
      </div>) : null}

      {showSyntaxFree ? (<div>
           <img src="e-everything.png" className="EraIcon" style={{zIndex: 99999999999, fontSize: '1.6em' }} />    
          <div style={{position: 'absolute', left: '67em', width: '10em'}}>
            <a onClick={toggleShow}><img src="parchment.png" className="EraIcon"   style={{width: '2em', height: '2em'}} /> <div>Syntax Locked</div></a>
          </div>
      </div>) : null}

      <h1>Technology Should Flow</h1>

      <table className="main-table">
        <tbody>
          <tr>
            {!showSyntaxFree ? (<td><div><ViewChoices mofData={mofData} choices={syntaxLockedChoices} isSyntaxFree={false}></ViewChoices> </div></td>) : null}
            {showSyntaxFree ? (<td><div><ViewChoices mofData={mofData} choices={syntaxFreeChoices} isSyntaxFree={true}></ViewChoices> </div></td>) : null}
          </tr>
        </tbody>
      </table>
    </div>
  );
};

export default TechShouldFlowPage;
