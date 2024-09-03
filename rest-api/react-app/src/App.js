import React, { useEffect, useState } from "react";
import { Route, Routes, Link, useNavigate, useLocation, Router } from "react-router-dom";
import { useAuth0 } from "@auth0/auth0-react";
import HomePage from "./pages/HomePage";
import AboutPage from "./pages/AboutPage";
import "./App.css";
import { Capacitor } from "@capacitor/core";
import { Browser } from "@capacitor/browser";

const App = ({ handleAuthCallback, findTokenKey }) => {
  const { loginWithRedirect, logout, isAuthenticated } = useAuth0();
  const navigate = useNavigate();
  const location = useLocation(); // This hook gives you access to the location object
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  useEffect(() => {
    // Check if the URL has `code` and `state` parameters, typical in OAuth callbacks
    const searchParams = new URLSearchParams(location.search);
    const code = searchParams.get('code');
    const state = searchParams.get('state');

    if (code && state) {
      console.error('Handling OAuth callback...', code, state);
      handleAuthCallback(window.location.href).then(() => {
        // Clear the code and state from the URL
        navigate('/', {replace: true}); // Redirect to '/app' or another appropriate route
      });
    }

    var accessToken = localStorage.getItem('access_token');
    setIsLoggedIn(accessToken !== null);

    // Other existing code...
  }, [location, navigate]); // Include `navigate` in the dependency array


  useEffect(() => {
    var accessToken = localStorage.getItem('access_token');
    setIsLoggedIn(accessToken !== null);

    // Setup deep link handling only if on a native platform
    if (Capacitor.isNativePlatform()) {
      const handleDeepLink = (event) => {
        console.log("Opened via URL:", event.url);
        if (event.url.includes("ejsyntaxlockedvssyntaxfree://callback")) {
          // Extract the data needed or handle auth logic here
          console.log("Handling authentication callback...");
          handleAuthCallback(event.url);
          // Your auth handling logic here, possibly calling onRedirectCallback or similar
        }
      };

      // Register the listener for the 'appUrlOpen' event
      Capacitor.Plugins.App.addListener("appUrlOpen", handleDeepLink);

      // Cleanup the event listener
      return () => {
        Capacitor.Plugins.App.removeAllListeners();
      };
    }
  }, []);

  const initiateMobileLogin = async() => {
    try {
      const response = await fetch(`https://localhost:42016/pkce/MobileLoginUrl?returnUrl=http://localhost:3000/app/index.html`, { method: "GET" });
      if (!response.ok) {
        throw new Error(`HTTP error! status: ${response.status}`);
      }
      const data = await response.json(); // Parse JSON data from response
      console.error("Login URL:", JSON.stringify(data));
  
      // Open the URL in the system browser
      await Browser.open({ url: data.startUrl });
      console.error('done with browser.', localStorage.getItem('access_token'));
    } catch (error) {
      console.error("Error fetching login URL:", error);
    }
  }

  const initiateWebLogin = async() => {
    try {
      initiateMobileLogin();
      if(Capacitor.isNativePlatform()) {
      } else {
//        loginWithRedirect({returnTo: `https://${window.location.host}/`});
      }
    } catch (error) {
      console.error("Error fetching login URL:", error);
    }
  }


  const initiateLogin = async () => {
    console.error("Requesting Login URL");
    if (Capacitor.isNativePlatform()) await initiateMobileLogin();
    else await initiateWebLogin();
  };

  return (
    <div className="container">
      <nav className="navbar">
        <ul className="nav-list">
          <li className="nav-item" style={{ margin: "0" }}>
          <Link to="/" className="nav-link" style={{padding: 'none', borderRadius: 0}}>
            <img
              src="logo192.png"
              style={{ marginTop: "-0.0em", marginRight: "1em", width: "3em" }}
              alt="logo"
              className="logo"
            />
          </Link>
          </li>
          <li className="nav-item" style={{ marginTop: "1em" }}>
            <Link to="/about" className="nav-link">
              Profile
            </Link>
          </li>
          <li
            className="nav-item"
            style={{ color: "white", marginTop: "1em", fontWeight: "bold" }}>ejsyntaxlockedvssyntaxfree</li>
        </ul>
        {isLoggedIn ? (
          <div style={{ borderRadius: "5px" }}>
            <button
              className="nav-button"
              onClick={async () => {
                localStorage.removeItem("access_token");
                logout({ returnTo: window.location.origin });
              }}>
              Log Out
            </button>
          </div>
        ) : (
          <button className="nav-button" onClick={initiateLogin}>Log In</button>
        )}
      </nav>
      <main className="main-content">
        <Routes>
          <Route
            path="/"
            element={<HomePage />}
          />
          <Route path="/about" element={<AboutPage />} />
        </Routes>
      </main>
    </div>
  );
};

export default App;


