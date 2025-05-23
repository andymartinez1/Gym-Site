import React from "react";
import "./home.css";

export default function Home() {
  return (
    <div className="home-container">
      <div className="home-header">
        <h1>Welcome to the Pig Iron Pit Gym</h1>
        <p>Your journey to a healthier life starts here!</p>
      </div>
      <div className="home-intro">
        <h2>Why Choose Us?</h2>
        <p>
          At PIP, we provide state-of-the-art equipment, experienced trainers,
          and a supportive community to help you achieve your fitness goals.
        </p>
      </div>
      <div className="home-features">
        <h2>Our Features</h2>
        <ul>
          <li>Modern Equipment</li>
          <li>Personal Training</li>
          <li>Group Classes</li>
          <li>Nutrition Guidance</li>
        </ul>
      </div>
      <div className="home-footer">
        <p>Join us today and take the first step towards a healthier you!</p>
        <button className="join-now-btn">Join Now</button>
      </div>
    </div>
  );
}
