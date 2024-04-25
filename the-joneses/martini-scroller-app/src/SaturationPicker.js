import React, { useState, useEffect } from "react";
import { HexColorPicker } from "react-colorful";
import { hslToHex, hexToHsl } from "./colorUtils";

const SaturationPicker = ({ hue, color, preset, onPresetChange, onChange, onHueChange, showPrimaryColors = false, label = 'Pick Color', preset1, preset2, preset3, presetsOnRight, isSyntaxFree}) => {
    const [hsl, setHsl] = useState(() => {
        const initialHsl = hexToHsl(color);
        return { ...initialHsl, h: hue };
    });

    const [currentLabel, setCurrentLabel] = useState(label);
    const [showPicker, setShowPicker] = useState(false);
    useEffect(() => {
        const newHsl = hexToHsl(color);
        setHsl({ h: hue, s: newHsl.s, l: newHsl.l });
        onChange(hslToHex(hue, hsl.s, hsl.l));  // Ensure external changes are also pushed up
        onPresetChange(preset || preset1);  // Notify the parent component of the preset change
        console.error('PRESET: ', preset, preset1, preset2, preset3)
        if (preset === null) {
            // set preset to preset1
        }
    }, [color, hue, hsl.s, hsl.l, onChange, onPresetChange, preset]);

    const handleColorChange = (newColor) => {
        const newHsl = hexToHsl(newColor);
        setHsl({ ...newHsl, h: hue });
        onChange(hslToHex(hue, newHsl.s, newHsl.l));
    };

    const moveToPosition = (saturation, lightness, preset, event) => {
        event.stopPropagation();  // Stop the click event from bubbling up to parent elements
        setCurrentLabel(isSyntaxFree ? preset.SyntaxFree : preset.Name);
        onPresetChange(preset);
        setHsl({ h: hue, s: saturation, l: lightness });
        onChange(hslToHex(hue, saturation, lightness));
    };
    
    const setHue = (newHue) => {
        setHsl(prevHsl => ({ ...prevHsl, h: newHue }));
        onChange(hslToHex(newHue, hsl.s, hsl.l));
        onHueChange(newHue);  // Notify the parent component of the hue change
    };

    const getContrastColor = (bgColor) => {
        const color = (bgColor.charAt(0) === '#') ? bgColor.substring(1, 7) : bgColor;
        const r = parseInt(color.substring(0, 2), 16); // hex to decimal
        const g = parseInt(color.substring(2, 4), 16); // hex to decimal
        const b = parseInt(color.substring(4, 6), 16); // hex to decimal
        const uicolors = [r / 255, g / 255, b / 255];
        const c = uicolors.map((col) => {
            if (col <= 0.03928) {
                return col / 12.92;
            }
            return Math.pow((col + 0.055) / 1.055, 2.4);
        });
        const L = 0.2126 * c[0] + 0.7152 * c[1] + 0.0722 * c[2];
        return (L > 0.179) ? 'black' : 'white';
    }
    


    return (
        <div style={{ position: "relative", width: "10em", height: "11em", margin: "0.5em", border: 'solid 3px black', backgroundColor: color, borderRadius: '0.45em', cursor: 'pointer' }} 
        className="outerHoverDiv"
        onClick={() => setShowPicker(true)}  // Set to true on click
        onMouseLeave={() => setShowPicker(false)}  
        >
            <div style={{ position: "absolute", top: 0, left: 2, width: "10em", height: "10em" }}>
                <div className="pickerLabel">{currentLabel}</div>
                <div style={{ position: "relative", width: "10em", height: "10em", margin: "0.8em", overflow: "hidden" }}>
                    <div className="presetBtnContainer" style={{ position: "absolute", top: 0, left: '-4em', width: "14.5em", height: "6em", overflow: "hidden",display: showPicker ? 'block' : 'none' }}>
                        <HexColorPicker color={hslToHex(hsl.h, hsl.s, hsl.l)} onChange={handleColorChange} />
                    </div>
                </div>
            </div>
            {preset1 != null ? 
            <div className="presetBtnContainer" style={{left: presetsOnRight ? '10em' : '-11em'}}>
                <button className="presetBtn" style={{backgroundColor: color, color: getContrastColor(color)}} 
                        onClick={(e) => moveToPosition(100, 50, preset1, e)}>{preset1.Name}</button>
                <button className="presetBtn" style={{backgroundColor: color, color: getContrastColor(color)}} 
                        onClick={(e) => moveToPosition(35, 80, preset2, e)}>{preset2.Name}</button>
                <button className="presetBtn" style={{backgroundColor: color, color: getContrastColor(color)}} 
                        onClick={(e) => moveToPosition(100, 20, preset3, e)}>{preset3.Name}</button>
            </div> : null}
            {showPrimaryColors && (
                <div style={{position: 'absolute', top: '6em', marginLeft: '0em', marginRight: 'auto', backgroundColor: color, padding: '0.5em', display: 'flex', justifyContent: 'space-around'}}>
                    <div className="baseColorPicker" style={{ backgroundColor: 'red' }} onClick={() => setHue(0)}>Red</div>
                    <div className="baseColorPicker" style={{ backgroundColor: 'blue' }} onClick={() => setHue(230)}>Blue</div>
                    <div className="baseColorPicker" style={{ backgroundColor: 'yellow', color: 'black' }} onClick={() => setHue(60)}>Yellow</div>
                </div>
            )}
        </div>
    );
};

export default SaturationPicker;
