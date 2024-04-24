import React, { useState } from 'react';

const NodeComponent = ({ color, onChange }) => (
  <div style={{ margin: 10, display: 'flex', flexDirection: 'column', alignItems: 'center' }}>
    <input type="color" value={color} onChange={onChange} style={{ width: 50, height: 50, border: 'none' }} />
    <div style={{ width: 50, height: 50, backgroundColor: color, borderRadius: '50%' }} />
  </div>
);

const EdgeComponent = ({ color }) => (
  <div style={{ width: 2, height: 50, backgroundColor: color, margin: '0 auto' }} />
);

const YShapeComponent = ({ inputColor1, inputColor2, outputColor, onColorChange1, onColorChange2 }) => (
  <div style={{ display: 'flex', flexDirection: 'column', alignItems: 'center' }}>
    <div style={{ display: 'flex', justifyContent: 'space-between', width: 120 }}>
      <NodeComponent color={inputColor1} onChange={onColorChange1} />
      <NodeComponent color={inputColor2} onChange={onColorChange2} />
    </div>
    <EdgeComponent color={outputColor} />
    <NodeComponent color={outputColor} />
  </div>
);

const YShapeHolder = () => {
  const [inputColor1, setInputColor1] = useState('#ff0000'); // default red
  const [inputColor2, setInputColor2] = useState('#0000ff'); // default blue
  const [outputColor, setOutputColor] = useState('#800080'); // default mix result purple

  // From WaterColorsPage - ensure these are defined correctly
  const hexToRgb = hex => {
    const r = parseInt(hex.substring(1, 3), 16);
    const g = parseInt(hex.substring(3, 5), 16);
    const b = parseInt(hex.substring(5, 7), 16);
    return [r, g, b];
  };

  const rgbToHex = (r, g, b) => {
    const toHex = c => {
      const hex = c.toString(16);
      return hex.length === 1 ? '0' + hex : hex;
    };
    return '#' + toHex(r) + toHex(g) + toHex(b);
  };

  // Include other required functions (isPrimaryYellow, isPrimaryRed, isPrimaryBlue, determineColors, etc.)

  const mixColors = (hex1, hex2) => {
    const rgb1 = hexToRgb(hex1);
    const rgb2 = hexToRgb(hex2);
    const pairing = determineColors(rgb1, rgb2);

    switch (pairing) {
      case 'red_blue':
        return determineShadeOfPurple(rgb1, rgb2);
      case 'red_yellow':
        return determineShadeOfOrange(rgb1, rgb2);
      case 'yellow_blue':
        return determineShadeOfGreen(rgb1, rgb2);
      default:
        return rgbToHex((rgb1[0] + rgb2[0]) / 2, (rgb1[1] + rgb2[1]) / 2, (rgb1[2] + rgb2[2]) / 2); // Default average mix
    }
  };

  const handleColorChange1 = (e) => {
    setInputColor1(e.target.value);
    setOutputColor(mixColors(e.target.value, inputColor2));
  };

  const handleColorChange2 = (e) => {
    setInputColor2(e.target.value);
    setOutputColor(mixColors(inputColor1, e.target.value));
  };

  return (
    <div>
      <YShapeComponent
        inputColor1={inputColor1}
        inputColor2={inputColor2}
        outputColor={outputColor}
        onColorChange1={handleColorChange1}
        onColorChange2={handleColorChange2}
      />
    </div>
  );
};

export default YShapeHolder;
