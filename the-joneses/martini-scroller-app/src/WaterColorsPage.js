import React, { useState } from 'react';
import { HexColorPicker } from 'react-colorful';
import { hslToHex, hexToHsl } from './colorUtils'; // Ensure utilities are imported only once

const WaterColorsPage = () => {
  const [color1, setColor1] = useState('#ff0000'); // Default red
  const [color2, setColor2] = useState('#0000ff'); // Default blue
  let bla1 = hexToHsl(color1);
  let bla2 = hexToHsl(color2);
  let mixedHslg = hexToHsl('#800080')
  let correct = 0;
  let error = 0;


  const mixColors = (colorA, colorB) => {
    const hslA = hexToHsl(colorA);
    const hslB = hexToHsl(colorB);
    bla1 = hslA;
    bla2 = hslB;


    // Average the hue, saturation, and lightness
    error = (hslA.h > hslB.h) ? hslA - hslB.h : hslB.h - hslA.h;
    correct = (hslA.h > hslB.h) ? ((350 - hslA.h) + hslB.h) : ((350 - hslB.h) + hslA.h);
    let mixedHsl;
    if (correct > error) {
     mixedHsl = {
      h: (hslA.h + hslB.h) / 2,
      s: (hslA.s + hslB.s) / 2,
      l: (hslA.l + hslB.l) / 2,
    };
  } else {
     mixedHsl = {
      h: (correct) / 2,
      s: (hslA.s + hslB.s) / 2,
      l: (hslA.l + hslB.l) / 2,
    };
  }

    let hex = hslToHex(mixedHsl.h, mixedHsl.s, mixedHsl.l);
    mixedHslg = hexToHsl(hex);
    return hex;
  };

  const mixedColor = mixColors(color1, color2);

  return (
    <div style={{ display: 'flex', flexDirection: 'column', alignItems: 'center', backgroundColor: mixedColor, height: '100vh' }}>
      <div>
        <HexColorPicker color={color1} onChange={setColor1} />
        <HexColorPicker color={color2} onChange={setColor2} />
      </div>
      <div>
        <h1 style={{ color: hslToHex(bla1) }}>Color 1: {bla1.h} {bla1.s} {bla1.l}</h1>
        <h1 style={{ color: hslToHex(bla2) }}>Color 2: {bla2.h} {bla2.s} {bla1.l}</h1>
        <h1 style={{ color: hslToHex(mixedHslg) }}>Mixed Color HSL: {mixedHslg.h} {mixedHslg.s} {mixedHslg.l}</h1>
        <h1 style={{ color: '#fff' }}>Correct?: {correct}</h1>
        <h1 style={{ color: '#fff' }}>Error?: {error}</h1>
        <h1 style={{ color: '#fff' }}>Mixed Color: {mixedColor}</h1>
      </div>
    </div>
  );
};

export default WaterColorsPage;