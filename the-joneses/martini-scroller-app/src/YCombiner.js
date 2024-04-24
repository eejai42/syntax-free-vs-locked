import React, { useState, useEffect } from 'react';
import { mixColors, hslToHex, hexToHsl } from './colorUtils';
import SaturationPicker from './SaturationPicker';

const YCombiner = ({
    externalColor1,
    externalColor2,
    onMixedColorChange,
    hideRightColor = false,
    defaultLeftColor = '#ff0000',
    defaultRightColor = '#ffff00',
    leftColorLabel = '',  // Default label is an empty string
    rightColorLabel = '',
    transpilerLabel = 'this-to-that',
    outputColorLabel = ''
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

    const mixedColor = hideRightColor ? color1 : mixColors(color1, color2);

    useEffect(() => {
        if (onMixedColorChange) onMixedColorChange(mixedColor);
    }, [mixedColor, onMixedColorChange]);

    const [showSecondPicker, setShowSecondPicker] = useState(true); // You can toggle this based on your conditions

    
    return (
        <div style={{ display: 'flex', flexDirection: 'column', alignItems: 'center', padding: '1em'}}>
            <div>
                <table style={{width: '25em'}}>
                    <tr>
                        <td valign='top' colspan={hideRightColor ? 2 : 1} style={{textAlign: 'center'}}>
                            {externalColor1 ? (
                                <SaturationPicker hue={hue1} color={color1} onChange={setColor1} onHueChange={setHue1} label={leftColorLabel} />
                            ) : (
                                <SaturationPicker hue={hue1} color={color1} onChange={setColor1} onHueChange={setHue1} label={leftColorLabel} />
                            )}
                            <div style={{clear: 'both'}}></div>
                        </td>
                        <td style={{ display: hideRightColor ? 'none' : 'block' }} valign='top'>
                            {externalColor2 ? (
                                <SaturationPicker hue={hue2} color={color2} onChange={setColor2} onHueChange={setHue2} label={rightColorLabel} />
                            ) : (
                                <SaturationPicker hue={hue2} color={color2} onChange={setColor2} onHueChange={setHue2} label={rightColorLabel} />
                            )}
                            <div style={{clear: 'both'}}></div>
                        </td>
                    </tr>
                    <tr><td colSpan={2} style={{ textAlign: 'center' }}>
                        <div class="transpilerLabel" >&gt;ssotme <span class="toolName">{transpilerLabel}</span><div style={{color: 'blue', fontSize: '2em', marginTop: '0.5em'}}>⤵</div></div>
                        
                        <div class="outputSpout" style={{ backgroundColor: mixedColor }}>
                            <div class="pickerLabel" >{outputColorLabel}</div>
                        </div>
                            <div style={{clear: 'both'}}></div>
                    </td></tr>
                </table>
            </div>
        </div>
    );    
};

export default YCombiner;
