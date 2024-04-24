import React, { useState } from 'react';
import { HexColorPicker } from 'react-colorful';
import { hslToHex, hexToHsl } from './colorUtils';
import SaturationPicker from './SaturationPicker';

const YCombiner = () => {
    const [color1, setColor1] = useState('#ff0000'); // Default red
    const [color2, setColor2] = useState('#0000ff'); // Default blue

    const [hue1, setHue1] = useState(0); // Initial hue for color1
    const [hue2, setHue2] = useState(235); // Initial hue for color2

    let bla1 = hexToHsl(color1);
    let bla2 = hexToHsl(color2);
    let mixedHslg = hexToHsl('#800080');
    let correct = 0;
    let error = 0;

    const mixColors = (colorA, colorB) => {
        const hslA = hexToHsl(colorA);
        const hslB = hexToHsl(colorB);

        // Blending logic
        let mixedHsl, hVal;
        if (hslA.h > hslB.h) {
            error = (360 - hslA.h) + hslB.h;
            hVal = error > 180 ? (hslA.h + hslB.h) / 2 : (hslA.h + hslB.h + 360) / 2;
        } else {
            error = (360 - hslB.h) + hslA.h;
            hVal = error > 180 ? (hslB.h + hslA.h) / 2 : (hslB.h + hslA.h + 360) / 2;
        }
        hVal %= 360;
        correct = Math.abs(hslA.h - hslB.h);
        mixedHsl = {
            h: hVal,
            s: (hslA.s + hslB.s) / 2,
            l: (hslA.l + hslB.l) / 2,
        };

        let hex = hslToHex(mixedHsl.h, mixedHsl.s, mixedHsl.l);
        mixedHslg = hexToHsl(hex);
        return hex;
    };
    const mixedColor = mixColors(color1, color2);


    return (
        <div style={{ display: 'flex', flexDirection: 'column', alignItems: 'center', height: '100vh' }}>
            <div>
              <table><tr><td>
                <SaturationPicker hue={hue1} color={color1} onChange={setColor1} onHueChange={setHue1} />
                </td><td>
                <SaturationPicker hue={hue2} color={color2} onChange={setColor2} onHueChange={setHue2} />
                </td></tr>
                <tr><td colSpan={2}>
                  <div style={{
                    backgroundColor: mixedColor, 
                  }}>
                    Result:
                  </div>
                  </td></tr>
                </table>
            </div>
            <div style={{display: 'none'}}>
                <h1 style={{ color: hslToHex(bla1) }}>Color 1: {bla1.h} {bla1.s} {bla1.l}</h1>
                <h1 style={{ color: hslToHex(bla2) }}>Color 2: {bla2.h} {bla2.s} {bla1.l}</h1>
                <h1 style={{ color: hslToHex(mixedHslg) }}>Mixed Color HSL: {mixedHslg.h} {mixedHslg.s} {mixedHslg.l}</h1>
                <h1 style={{ color: '#000' }}>Correct?: {correct}</h1>
                <h1 style={{ color: '#000' }}>Error?: {error}</h1>
                <h1 style={{ color: '#000' }}>Mixed Color: {mixedColor}</h1>
            </div>
        </div>
    );    
};

export default YCombiner;
