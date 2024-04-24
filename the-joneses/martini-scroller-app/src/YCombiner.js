import React, { useState, useEffect } from 'react';
import { mixColors, hslToHex, hexToHsl } from './colorUtils';
import SaturationPicker from './SaturationPicker';

const YCombiner = ({
    externalColor1,
    externalColor2,
    onMixedColorChange,
    hideRightColor = false,
    defaultLeftColor = '#ff0000',
    defaultRightColor = '#ffff00'
}) => {
    const [color1, setColor1] = useState(externalColor1 || defaultLeftColor);
    const [color2, setColor2] = useState(externalColor2 || defaultRightColor);

    const [hue1, setHue1] = useState(hexToHsl(color1).h);
    const [hue2, setHue2] = useState(hexToHsl(color2).h);

    useEffect(() => {
        if (externalColor1) {
            setColor1(externalColor1);
            setHue1(hexToHsl(externalColor1).h);
        }
        if (externalColor2 && !hideRightColor) {
            setColor2(externalColor2);
            setHue2(hexToHsl(externalColor2).h);
        }
    }, [externalColor1, externalColor2, hideRightColor]);

    // Determine mixed color based on whether the 2nd picker is hidden
    const mixedColor = hideRightColor ? color1 : mixColors(color1, color2);

    useEffect(() => {
        if (onMixedColorChange) onMixedColorChange(mixedColor);
    }, [mixedColor, onMixedColorChange]);

    return (
        <div style={{ display: 'flex', flexDirection: 'column', alignItems: 'center', padding: '1em'}}>
            <div>
                <table><tr>
                    <td>
                        {externalColor1 ? (
                            <div className="fixedColor" style={{ backgroundColor: color1 }} />
                        ) : (
                            <SaturationPicker hue={hue1} color={color1} onChange={setColor1} onHueChange={setHue1} />
                        )}
                    </td>
                    <td style={{ display: hideRightColor ? 'none' : 'block' }}>
                        {externalColor2 ? (
                            <div className="fixedColor" style={{ backgroundColor: color2 }} />
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
