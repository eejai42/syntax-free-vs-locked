import React from "react";
import { useLocation } from "react-router-dom";
import { Link } from "react-router-dom";
import SyntaxVisualizationComponent from "./SyntaxVisualizationComponent";

const WaterColorsPage = () => {

  const location = useLocation();

  // Determine the route based on the pathname
  const routeType = location.pathname.includes("/syntax-locked") ? "locked" : "free";

  return (
    <div style={{fontSize: '1.2em', minWidth: '75em', maxWidth: '75em', margin: '1em'}}>
      {routeType === "locked" ? (
        <div>
          <div style={{position: 'absolute', right: '1em'}}><a href="/#/syntax-free">Syntax Free</a></div>
        <h1>Syntax Locked</h1>
        <SyntaxVisualizationComponent key='1'
          topLeftColorLabel="Requirements"
          topTranspilerLabel="🧠 Project Manager"
          outputLabelName="Natural Language"
          leftYTranspilerLabel="🧠 Developer"
          rightYTranspilerLabel="🧠 Editor"
          leftYColorLabel="C++"
          leftYRightColorLabel="User Stories"
          rightYColorLabel="Dev Ops"
          rightYRightColorLabel="Markdown"
          isSyntaxFree={false}
        />
        </div>
        ) : (
        <div>
          <div style={{position: 'absolute', right: '1em'}}><a href="/#/syntax-locked">Syntax Locked</a></div>
        <h1>Syntax Free</h1>
        <SyntaxVisualizationComponent  key='2'
          topLeftColorLabel="Requirements"
          topTranspilerLabel="> ssotme airtable-to-json"
          outputLabelName="Airtable"
          leftYTranspilerLabel="> ssotme json-hbars-transform"
          rightYTranspilerLabel="> ssotme json-hbars-transform"
          leftYColorLabel="Arduino.hbars"
          leftYRightColorLabel="Devices.json"
          rightYColorLabel="Devices.json"
          rightYRightColorLabel="README.hbars"
          followAlong={true}
          isSyntaxFree={true}
         />
        </div>
      )}
      
       
  

    </div>
  );
};

export default WaterColorsPage;
