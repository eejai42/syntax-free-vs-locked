import React, { useState, useEffect } from "react";
import { HexColorPicker } from "react-colorful";
import { hslToHex, hexToHsl } from "./colorUtils"; // Assuming these utilities are correctly implemented

const SaturationPicker = ({ hue, color, onChange }) => {
  // Convert initial color to HSL, then override the hue
  const [hsl, setHsl] = useState(() => {
    const initialHsl = hexToHsl(color);
    return { ...initialHsl, h: hue };
  });

  // When the component receives a new color prop, update the HSL state but force the hue
  useEffect(() => {
    const newHsl = hexToHsl(color);
    setHsl({ h: hue, s: newHsl.s, l: newHsl.l });
  }, [color, hue]);

  // Handle changes from the HexColorPicker
  const handleColorChange = (newColor) => {
    const newHsl = hexToHsl(newColor);
    const updatedHsl = { h: hue, s: newHsl.s, l: newHsl.l };
    setHsl(updatedHsl); // Update local HSL state
    onChange(hslToHex(hue, updatedHsl.s, updatedHsl.l)); // Convert back to hex and call parent onChange
  };

  return (
    <div
      style={{
        position: "relative",
        width: "7em",
        height: "10em",
        margin: "1em",
        overflow: "hidden",
      }}
    >
      <div
        style={{
          position: "absolute",
          top: 0,
          left: 0,
          backgroundColor: "black",
          width: "100%",
          height: "6em",
          opacity: 1 - hsl.l / 100,
        }}
      >
        <div
          style={{
            position: "relative",
            width: "200px",
            height: "6em",
            margin: "0em",
            overflow: "hidden",
          }}
        >
          {/* <div style={{position: 'absolute', top: 0, left: 0, backgroundColor: 'black', width: '100%', height: '100%', opacity: 1 - hsl.l / 100}}>
            this is a test
        </div> */}
          <div
            style={{
              position: "absolute",
              top: 0,
              left: -100,
              backgroundColor: "purple",
              width: "100%", // Full width of parent
              height: "100%", // Limit height to top 25%
              overflow: "hidden",
            }}
          >
            <HexColorPicker
              color={hslToHex(hue, hsl.s, hsl.l)}
              onChange={handleColorChange}
            />
          </div>
        </div>
      </div>
    </div>
  );
};

export default SaturationPicker;
