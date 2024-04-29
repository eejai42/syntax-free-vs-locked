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
      <div style={{maxWidth: '85rem'}}>
        <h3>Tech should Follow Along</h3>
        <TechFlowingComponent demoFlow={dataFlow} showUsed={true} />
      </div>
      <div style={{maxWidth: '95rem', marginTop: '35em'}}>
        <h3>Unused Technologies</h3>
        <div style={{backgroundColor: '#eeeeee', fontSize: '1`em'}}>
          <TechFlowingComponent demoFlow={dataFlow} showUsed={false} />
        </div>
      </div>
    </div>
  );
};

export default TechShouldFlowPage;
