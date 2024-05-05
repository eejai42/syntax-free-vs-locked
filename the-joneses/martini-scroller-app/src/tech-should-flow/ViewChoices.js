import React, { useState, useEffect } from "react";
import "./TechShouldFlow.css";

const ViewChoices = ({ choices, isSyntaxFree }) => {
  return (
    <div>
      <h2>{isSyntaxFree ? 'Syntax Free' : 'Syntax Locked'}</h2>
      <table className="choices-table">
        <tbody>
        <tr>
            <td colSpan="2"><div>top</div></td>
        </tr>
        <tr><td><div>code</div></td>
            <td><div>documentation</div></td>
        </tr>
        </tbody>
      </table>
    </div>
  );
};

export default ViewChoices;
