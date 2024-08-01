import React, { useEffect, useState } from "react";
import UserService from "../effortlessapiservices/UserService";

const HomePage = () => {
  const [accessToken] = useState(localStorage.getItem('access_token'));
  const [artifacts, setArtifacts] = useState([]);

  useEffect(() => {
    if (accessToken) {
      UserService.GetTrialArtifactss()
        .then(response => {
          setArtifacts(response);
        })
        .catch(error => {
          console.error('Error fetching artifacts:', error);
        });
    }
  }, [accessToken]);

  return (
    <div>
      {!accessToken ? (
        <div>Login to continue</div>
      ) : (
        <div>
          <h2>Details</h2>
          <ul>
            {artifacts.map((artifact) => (
              <li key={artifact.TrialArtifactId}>{artifact.Name}</li>
            ))}
          </ul>
        </div>
      )}
    </div>
  );
};

export default HomePage;
