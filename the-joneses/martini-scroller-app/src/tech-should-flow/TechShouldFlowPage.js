import React, { useEffect } from "react";
import LockedAndFreeSyntaxComparisonTable from "./LockedAndFreeSyntaxComparisonTable";
import "./TechShouldFlow.css";

const TechShouldFlowPage = ({ transpilerNodes }) => {

  useEffect(() => {
  });

  return (
    <div style={{fontSize: '0.8em', margin: '1em'}}>
      <div style={{maxWidth: '100rem'}}>
        <h1>Tech should Follow Along</h1>
        <LockedAndFreeSyntaxComparisonTable transpilerNodes={transpilerNodes} showUsed={true} />
      </div>
      <div style={{maxWidth: '95rem', marginTop: '35em'}}>
        <h1>Unused Technologies</h1>
        <div style={{backgroundColor: '#dddddd', fontSize: '1em'}}>
          <LockedAndFreeSyntaxComparisonTable transpilerNodes={transpilerNodes} showUsed={false} />
        </div>
      </div>
    </div>
  );
};

export default TechShouldFlowPage;
