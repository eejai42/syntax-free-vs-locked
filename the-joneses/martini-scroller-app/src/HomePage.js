import React from "react";
import { Link } from "react-router-dom";

const HomePage = () => {
    console.error('Rending Home Page', HomePage);
  return (
    <div>
      <iframe
        width="560"
        height="315"
        src="https://www.youtube.com/embed/[YourVideoID]"
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
