import React, { useState, useEffect } from 'react';
import { HexColorPicker } from 'react-colorful';
import { mixColors, hslToHex, hexToHsl } from './colorUtils';
import SaturationPicker from './SaturationPicker';


const YCombiner = ({ externalColor1, externalColor2, onMixedColorChange }) => {
    const [color1, setColor1] = useState(externalColor1 || '#ff0000'); // Default or external red
    const [color2, setColor2] = useState(externalColor2 || '#0000ff'); // Default or external blue

    
    const [hue1, setHue1] = useState(0); // Initial hue for color1
    const [hue2, setHue2] = useState(235); // Initial hue for color2


    // Update local state when external colors change
    useEffect(() => {
        if (externalColor1) setColor1(externalColor1);
        if (externalColor2) setColor2(externalColor2);
    }, [externalColor1, externalColor2]);


    
    const mixedColor = mixColors(color1, color2);
    
    // Propagate mixed color changes up
    useEffect(() => {
        if (onMixedColorChange) onMixedColorChange(mixedColor);
    }, [mixedColor, onMixedColorChange]);


    let bla1 = hexToHsl(color1);
    let bla2 = hexToHsl(color2);
    return (
        <div style={{ display: 'flex', flexDirection: 'column', alignItems: 'center', }}>
            <div>
              <table><tr><td>
                <SaturationPicker hue={hue1} color={color1} onChange={setColor1} onHueChange={setHue1} />
                </td><td>
                <SaturationPicker hue={hue2} color={color2} onChange={setColor2} onHueChange={setHue2} />
                </td></tr>
                <tr><td colSpan={2}>
                  <div style={{
                    backgroundColor: mixedColor, 
                    height: '5em',
                  }}>
                    Result:
                  </div>
                  </td></tr>
                </table>
            </div>
            <div style={{display: 'none'}}>
                <h1 style={{ color: hslToHex(bla1) }}>Color 1: {bla1.h} {bla1.s} {bla1.l}</h1>
                <h1 style={{ color: hslToHex(bla2) }}>Color 2: {bla2.h} {bla2.s} {bla1.l}</h1>
                {/* <h1 style={{ color: hslToHex(mixedHslg) }}>Mixed Color HSL: {mixedHslg.h} {mixedHslg.s} {mixedHslg.l}</h1>
                <h1 style={{ color: '#000' }}>Correct?: {correct}</h1>
                <h1 style={{ color: '#000' }}>Error?: {error}</h1>
                <h1 style={{ color: '#000' }}>Mixed Color: {mixedColor}</h1> */}
            </div>
        </div>
    );    
};

export default YCombiner;
