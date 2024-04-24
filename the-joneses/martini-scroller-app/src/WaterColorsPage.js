import React from "react";
import { useLocation } from "react-router-dom";
import { Link } from "react-router-dom";
import SyntaxVisualizationComponent from "./SyntaxVisualizationComponent";

const WaterColorsPage = () => {

  const location = useLocation();

  // Determine the route based on the pathname
  const routeType = location.pathname.includes("/syntax-locked") ? "locked" : "free";

  return (
    <div>
      {routeType === "locked" ? (
        <div>
          <div style={{float: 'right'}}><a href="/#/syntax-free">Syntax Free</a></div>
        <h1>Syntax Locked</h1>
        <SyntaxVisualizationComponent key='1'
          topLeftColorLabel="Requirements"
          topTranspilerLabel="🧠 Project Manager / Stakeholder"
          outputLabelName="Natural Language"
          leftYTranspilerLabel="🧠 C++ Dev"
          rightYTranspilerLabel="🧠 Markdown Dev"
          leftYColorLabel="User Stories"
          leftYRightColorLabel="C++"
          rightYColorLabel="Dev Ops"
          rightYRightColorLabel="Markdown"
          rightYRightTranspilerLabel="rc r colo"
          />
        </div>
        ) : (
        <div>
          <div style={{float: 'right'}}><a href="/#/syntax-locked">Syntax Locked</a></div>
        <h1>Syntax Free</h1>
        <SyntaxVisualizationComponent  key='2'
          topLeftColorLabel="Requirements"
          topTranspilerLabel=">ssotme airtable-to-json"
          outputLabelName="Spreadsheet"
          leftYTranspilerLabel=">ssotme json-hbars-transform"
          rightYTranspilerLabel=">ssotme json-hbars-transform"
          leftYColorLabel="Devices.json"
          rightYColorLabel="Devices.json"
          leftYRightColorLabel="Arduino.hbars"
          rightYRightColorLabel="README.hbars"
          followAlong={true}
         />
        </div>
      )}
      
       
  

    </div>
  );
};

export default WaterColorsPage;
