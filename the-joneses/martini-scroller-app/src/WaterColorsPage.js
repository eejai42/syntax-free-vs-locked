import React from "react";
import { useLocation } from "react-router-dom";
import { useState } from "react";
import { Link } from "react-router-dom";
import SyntaxVisualizationComponent from "./SyntaxVisualizationComponent";

const WaterColorsPage = () => {

  const location = useLocation();
  const [showPictures, setShowPictures] = useState(true);

  // Determine the route based on the pathname
  const routeType = location.pathname.includes("syntax-locked") ? "locked" : "free";

  const toggleShowPictures = () => {
    setShowPictures(prev => !prev);
  };

  return ( 
    <div style={{position: 'relative', fontSize: '1.2em', minWidth: '70em', maxWidth: '77em', margin: '1em', marginLeft: 'auto', marginRight: 'auto'}}>
      <div style={{position: 'absolute', left: '59em', width: '10em', marginTop: '-0.2em'}}>
      <div style={{ marginRight: '5px', float: 'left', paddingTop: '0.25em' }}>Pictures</div>
      <label className="switch">        
          <input type="checkbox" checked={showPictures} onChange={toggleShowPictures}  style={{marginTop: '-2em'}}/>
          <span className="slider round"></span>
        </label>
      </div>
      {routeType === "locked" ? (
        <div>
          <img src="parchment.png"  className="EraIcon" style={{top: '-0.5em', left: '-1em', zIndex: 99999999999, fontSize: '1.6em' }} />    
          <div style={{position: 'absolute', left: '69em', width: '8em'}}>
            <a href="#/syntax-free"><img src="e-everything.png"  className="EraIcon" style={{width: '2em', height: '2em'}} /> Syntax Free</a>
          </div>
        <h1>Syntax Locked</h1>
        <SyntaxVisualizationComponent key='1'
          topLeftColorLabel="Requirements"
          topTranspilerLabel="🧠 Project Manager"
          outputLabelName="Natural Language"
          leftYTranspilerLabel="🧠 Developer"
          rightYTranspilerLabel="🧠 Editor"
          leftYImage="developer.webp"
          rightYImage="editor.webp"
          leftYColorLabel="C++"
          leftYRightColorLabel="User Stories"
          rightYColorLabel="Dev Ops"
          rightYRightColorLabel="Markdown"
          isSyntaxFree={false}
          showPictures={showPictures}
        />
        </div>
        ) : (
        <div>
           <img src="e-everything.png" className="EraIcon" style={{top: '-0.5em', left: '-1em', zIndex: 99999999999, fontSize: '1.6em' }} />    
          <div style={{position: 'absolute', left: '67em', width: '10em'}}>
          <a href="#/syntax-locked">
            <img src="parchment.png" 
                className="EraIcon"   
                style={{width: '2em', height: '2em'}} /> 
                <div>Syntax Locked</div></a></div>
        <h1>Syntax Free</h1>
        <SyntaxVisualizationComponent  key='2'
          topLeftColorLabel="Requirements"
          topTranspilerLabel="> ssotme airtable-to-json"
          outputLabelName="Airtable"
          leftYTranspilerLabel="> ssotme json-hbars-transform"
          rightYTranspilerLabel="> ssotme json-hbars-transform"
          leftYColorLabel="Arduino.hbars"
          leftYImage="arduino-hbars.webp"
          rightYImage="readme-hbars.webp"
          leftYRightColorLabel="User Stories + Devices.json"
          rightYColorLabel="Dev Ops + Devices.json"
          rightYRightColorLabel="README.hbars"
          followAlong={true}
          isSyntaxFree={true}
          showPictures={showPictures}
          />
        </div>
      )}
      
       
  

    </div>
  );
};

export default WaterColorsPage;
