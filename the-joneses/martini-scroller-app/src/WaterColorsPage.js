import React, { useState } from "react";
import YCombiner from "./YCombiner";

const WaterColorsPage = () => {
  const [outputColor, setOutputColor] = useState("#ff00ff"); // Initial color set to a placeholder

  const handleColorChange = (color) => {
    setOutputColor(color);
  };

  return (
    <table>
      <tr>
        <td colSpan={2} style={{ textAlign: "center" }}>
          {/* Replace SaturationPicker with YCombiner */}
          <YCombiner
            hideRightColor={true} // Hide the right picker
            onMixedColorChange={handleColorChange}
            defaultLeftColor="#0000ff"
            defaultRightColor="#4000ff"
          />
        </td>
      </tr>
      <tr>
        <td>
          {/* Pass the output color from the top YCombiner to this YCombiner */}
          <YCombiner
            externalColor2={outputColor}
            onMixedColorChange={() => {}}
            defaultLeftColor="#FF0000"
            defaultRightColor="#0000ff"
          />
        </td>
        <td>
          {/* Another YCombiner using the output color */}
          <YCombiner
            externalColor1={outputColor}
            onMixedColorChange={() => {}}
            defaultLeftColor="#0000ff"
            defaultRightColor="#bfff00"
          />
        </td>
      </tr>
    </table>
  );
};

export default WaterColorsPage;
