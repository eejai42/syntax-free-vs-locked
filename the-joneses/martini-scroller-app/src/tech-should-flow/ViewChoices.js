import React, { useState, useEffect } from "react";
import "./TechShouldFlow.css";

const ViewChoices = ({ choices, isSyntaxFree }) => {
  return (
    <div>
      <h1>{isSyntaxFree ? 'Free' : 'Locked'}</h1>
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
