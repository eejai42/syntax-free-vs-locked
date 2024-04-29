import React, { useEffect } from "react";
import { useLocation } from "react-router-dom";
import TranspilerNodeComponent from "./TranspilerNodeComponent";
import TranspilerRowHeaderComponent from "./TranspilerRowHeaderComponent";
import TechFlowingComponent from "./TechFlowingComponent";
import "./TechShouldFlow.css";

const TechShouldFlowPage = ({ demoFlow }) => {
  const dataFlow = demoFlow.DataFlow;

  useEffect(() => {
    console.error("Rendering TechShouldFlowPage", TechShouldFlowPage, dataFlow);
  });

  return (
    <div style={{fontSize: '0.8em', margin: '1em'}}>
      <h3>Tech should Follow Along</h3>
      <TechFlowingComponent demoFlow={dataFlow} showUsed={true} />
      <div style={{maxWidth: '85rem', marginLeft: '8rem'}}>
        <h3>Unused Technologies</h3>
        <div style={{backgroundColor: '#eeeeee', padding: '2em', fontSize: '0.8em', textDecoration: 'line-through'}}>
          <TechFlowingComponent demoFlow={dataFlow} showUsed={false} />
        </div>
      </div>
    </div>
  );
};

export default TechShouldFlowPage;
