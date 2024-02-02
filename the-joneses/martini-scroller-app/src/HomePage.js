import React from "react";
import { Link } from "react-router-dom";

const HomePage = () => {
  return (
    <div>
      <iframe
        width="1120"
        height="630"
        src="https://www.youtube.com/embed/jmDTNE4brLI?autoplay=1"
        title="YouTube video player"
        frameBorder="0"
        allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
        allowFullScreen
      ></iframe>
      <br />
      <Link to="/demo">
        <button>Try Demo</button>
      </Link>
    </div>
  );
};

export default HomePage;
