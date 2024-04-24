import React, { useState } from "react";
import YCombiner from "./YCombiner";
import SaturationPicker from "./SaturationPicker";
import { hslToHex, hexToHsl } from "./colorUtils"; // Import if not already

const WaterColorsPage = () => {
  const [outputColor, setOutputColor] = useState("#ff00ff"); // Initial color set to a placeholder

  const handleColorChange = (color) => {
    setOutputColor(color);
  };

  return (
    <table>
      <tr>
        <td colSpan={2} style={{ textAlign: "center", paddingLeft: '18em' }}>
         
          <SaturationPicker style={{ width: "10em", height: "10em", marginLeft: "5em" }}
            hue={235}
            color={outputColor}
            onChange={handleColorChange}
          />
        </td>
      </tr>
      <tr>
        <td>
          {/* Pass the output color from the SaturationPicker to the YCombiners */}
          <YCombiner
            externalColor2={outputColor}
            onMixedColorChange={() => {}}
          />
        </td>
        <td>
          <YCombiner
            externalColor1={outputColor}
            onMixedColorChange={() => {}}
          />
        </td>
      </tr>
    </table>
  );
};

export default WaterColorsPage;
