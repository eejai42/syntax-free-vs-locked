import React, { useState, useEffect } from 'react';
import { mixColors, hslToHex, hexToHsl } from './colorUtils';  // Ensure hslToHex and hexToHsl are imported if needed
import SaturationPicker from './SaturationPicker';

const YCombiner = ({ externalColor1, externalColor2, onMixedColorChange }) => {
    const [color1, setColor1] = useState(externalColor1 || '#ff0000');
    const [color2, setColor2] = useState(externalColor2 || '#ffff00');

    const [hue1, setHue1] = useState(hexToHsl(color1).h);  // Initialize hue state from color1
    const [hue2, setHue2] = useState(hexToHsl(color2).h);  // Initialize hue state from color2

    useEffect(() => {
        if (externalColor1) {
            setColor1(externalColor1);
            setHue1(hexToHsl(externalColor1).h);  // Update hue when external color changes
        }
        if (externalColor2) {
            setColor2(externalColor2);
            setHue2(hexToHsl(externalColor2).h);  // Update hue when external color changes
        }
    }, [externalColor1, externalColor2]);

    const mixedColor = mixColors(color1, color2);

    useEffect(() => {
        if (onMixedColorChange) onMixedColorChange(mixedColor);
    }, [mixedColor, onMixedColorChange]);

    return (
        <div style={{ display: 'flex', flexDirection: 'column', alignItems: 'center', padding: '1em'}}>
            <div>
                <table><tr>
                    <td>
                        {externalColor1 ? (
                            <div class="fixedColor" style={{ backgroundColor: color1 }} />
                        ) : (
                            <SaturationPicker hue={hue1} color={color1} onChange={setColor1} onHueChange={setHue1} />
                        )}
                    </td>
                    <td>
                        {externalColor2 ? (
                            <div class="fixedColor" style={{ backgroundColor: color2 }} />
                        ) : (
                            <SaturationPicker hue={hue2} color={color2} onChange={setColor2} onHueChange={setHue2} />
                        )}
                    </td>
                </tr>
                <tr><td colSpan={2}>
                    <div style={{ backgroundColor: mixedColor, height: '5em' }}>Result:</div>
                </td></tr>
                </table>
            </div>
        </div>
    );    
};

export default YCombiner;
