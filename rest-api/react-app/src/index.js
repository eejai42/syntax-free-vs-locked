import React, { useEffect } from "react";
import { createRoot } from "react-dom/client";
import "./index.css";
import App from "./App";
import { Auth0Provider } from "@auth0/auth0-react";
import { BrowserRouter as Router } from "react-router-dom";
import { Capacitor } from "@capacitor/core";
import BaseService from "./effortlessapiservices/BaseService";

const domain = process.env.REACT_APP_AUTH0_DOMAIN;
const clientId = process.env.REACT_APP_AUTH0_CLIENT_ID;
const redirectUrl = Capacitor.isNativePlatform() ? 'ejsyntaxlockedvssyntaxfree://callback' : process.env.REACT_APP_AUTH0_REDIRECT_URL;
const baseService = new BaseService();

if (window.location.pathname === '/' || window.location.pathname === '/app') {
  window.location.pathname = '/app/';
}

async function exchangeCodeForToken(code, state) {
  const response = await baseService.apiCall("POST","pkce","exchange",null,{ Code: code, State: state });
  console.error('RESPONSE: ', response);
  if (response) {
    console.error('PKCE Exchange succeeeded', response);
    localStorage.setItem("access_token", response?.accessToken);
  } else {
    console.error('PKCE Exchange failed', response);
  }
};

const findTokenKey = () => {
  // Iterate over all keys in localStorage
  for (let i = 0; i < localStorage.length; i++) {
    const key = localStorage.key(i);
    console.error('FOUND KEY: ', key);
    // Check if the key matches the desired pattern
    if (key.includes('@@auth0spajs@@::') && key.includes('email')) {
      console.error('Found matching key: ', key);
      return key;
    }
  }
  console.error('No matching token key found');
  return null;
};

const onRedirectCallback = async (appState) => {
  const storedTokenKey = findTokenKey();
  const storedTokenFromStorage = localStorage.getItem(storedTokenKey);
  const storedTokenData = JSON.parse(storedTokenFromStorage);
  console.error('STORED WEBAPP TOKEN KEY: ', storedTokenKey, "Token Data: ", storedTokenData);

  if (!storedTokenData || !storedTokenData.body.access_token) {
    throw new Error("No valid access token found in webapp local storage");
  }

  const accessToken = storedTokenData.body.access_token;
  console.error('FOUND WEBAPP STORED AUTH0 TOKEN: ', storedTokenData, "\n\nAccess Token: ", accessToken);
  const response = await baseService.apiCall("POST","pkce","exchange",null,{ Auth0Token: accessToken });
  console.error('RESPONSE: ', response, JSON.stringify(window.location));
  if (!response?.accessToken) throw new Error("Invalid username/password");
  localStorage.setItem("access_token", response?.accessToken);
  window.location.href = window.location.origin;
};

const handleAuthCallback = async (url) => {
  console.error("Entering handleAuthCallback with URL: ", url);
  const urlObj = new URL(url);
  const code = `${urlObj.searchParams.get('code')}`;
  const state = `${urlObj.searchParams.get('state')}`;

  console.error("Extracted Parameters: ", code, state);

  try {
    if (!code || !state) {
        throw new Error("Required parameters 'code' or 'state' are missing from the URL.");
    }

    // Now exchange the code for tokens
    await exchangeCodeForToken(code, state);
    //window.location.href = window.location.origin;     
  } catch (error) {
      console.error('Error during token exchange or data handling:', error.message);
      throw error;
  }
}

const root = createRoot(document.getElementById("root"));

root.render(
  <Auth0Provider
    domain={domain}
    clientId={clientId}
    authorizationParams={{ redirect_uri: redirectUrl }}
    scope="openid profile email"
    useRefreshTokens={true}
    cacheLocation="localstorage"
    onRedirectCallback={onRedirectCallback}
    logLevel={7}
  >
    <Router basename="/app/">
      <App handleAuthCallback={handleAuthCallback} findTokenKey={findTokenKey} />
    </Router>
  </Auth0Provider>
);