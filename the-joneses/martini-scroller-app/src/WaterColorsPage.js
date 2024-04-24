import React from "react";
import { Link } from "react-router-dom";
import SyntaxVisualizationComponent from "./SyntaxVisualizationComponent";

const WaterColorsPage = () => {
  return (
    <div>
      <h1>Syntax Locked</h1>
      <SyntaxVisualizationComponent key='1'
        topLeftColorLabel="Word or GDoc"
        topTranspilerLabel="🧠 Human or AI Agent"
        outputLabelName="Requirements.pdf"
        leftYTranspilerLabel="🧠 Developer"
        rightYTranspilerLabel="🧠 Markdown"
        leftYColorLabel="User Stories"
        leftYRightColorLabel="C++ Skills"
        rightYColorLabel="User Stories"
        rightYRightColorLabel="Markdown Skills"
        rightYRightTranspilerLabel="rc r colo"
        />
{/*        
      <h1>Syntax Free</h1>
      <SyntaxVisualizationComponent  key='2'
        topLeftColorLabel="Airtable"
        topTranspilerLabel=">ssotme airtable-to-json"
        outputLabelName="Devices.json"
        leftYTranspilerLabel=">ssotme json-hbars-transform"
        rightYTranspilerLabel=">ssotme json-hbars-transform"
        leftYColorLabel="Devices.json"
        rightYColorLabel="Devices.json"
        leftYRightColorLabel="Arduino.hbars"
        rightYRightColorLabel="README.hbars"
        rightYRightTranspilerLabel="rc r colo"
       /> */}

    </div>
  );
};

export default WaterColorsPage;
