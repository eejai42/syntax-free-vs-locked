import React, { useEffect } from "react";
import { useLocation } from "react-router-dom";
import { useState } from "react";
import { Link } from "react-router-dom";
import SyntaxVisualizationComponent from "./SyntaxVisualizationComponent";

const TranspilerComponent = ({ transpilerItem, syntaxLocked }) => {

  useEffect(() => {

});

  return (<div style={{minHeight: '20em'}}>
    {syntaxLocked && !transpilerItem.LockedColor ? (
        <div>MISSING</div>
    ) : (

        <div>
        <h2>{transpilerItem.Name}</h2>
        <p>{transpilerItem.LockedColor}</p>
        <div style={{ clear: "both" }}></div>
        </div>
    )}
    </div>
  );
};

export default TranspilerComponent;