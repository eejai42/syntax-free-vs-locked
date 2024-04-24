import React, { useState, useEffect } from "react";
import { HexColorPicker } from "react-colorful";
import { hslToHex, hexToHsl } from "./colorUtils";

const SaturationPicker = ({ hue, color, onChange, onHueChange, showPrimaryColors = false, label = 'Pick Color' }) => {
    // set base color picker style with width: '2em', height: '2em'
   const [hsl, setHsl] = useState(() => {
        const initialHsl = hexToHsl(color);
        return { ...initialHsl, h: hue };
    });

    useEffect(() => {
        const newHsl = hexToHsl(color);
        setHsl({ h: hue, s: newHsl.s, l: newHsl.l });
    }, [color, hue]);

    useEffect(() => {
        setHsl(prevHsl => ({ ...prevHsl, h: hue }));
        onChange(hslToHex(hue, hsl.s, hsl.l));  // Ensure external changes are also pushed up
    }, [hue, onChange, hsl.s, hsl.l]);

    const handleColorChange = (newColor) => {
        const newHsl = hexToHsl(newColor);
        setHsl({ ...newHsl, h: hue });  // Maintain the new hue locally
        onChange(hslToHex(hue, newHsl.s, newHsl.l));
    };

    const setHue = (newHue) => {
        setHsl(prevHsl => ({ ...prevHsl, h: newHue }));
        onChange(hslToHex(newHue, hsl.s, hsl.l));
        onHueChange(newHue);  // Notify the parent component of the hue change
    };

    return (
        <div style={{ position: "relative", width: "10em", height: "10em", margin: "0.5em", border: 'solid 3px black', backgroundColor: color }}>
            <div style={{ position: "absolute", top: 0, left: 2, width: "10em", height: "10em" }}>
                <div style={{ position: "relative", width: "10em", height: "10em", margin: "0em", overflow: "hidden" }}>
                    <div style={{ position: "absolute", top: 0, left: '-5em', width: "14.5em", height: "8em", overflow: "hidden" }}>
                        <div class="pickerLabel">{label}</div>
                        <HexColorPicker color={hslToHex(hsl.h, hsl.s, hsl.l)} onChange={handleColorChange} />
                    </div>
                </div>
            </div>
            {showPrimaryColors ? (
                <div style={{position: 'absolute', top: '6em', marginLeft: '0em', marginRight: 'auto', backgroundColor: color, padding: '0.5em', display: 'flex', justifyContent: 'space-around'}}>
                <div class="baseColorPicker" style={{ backgroundColor: 'red' }} onClick={() => setHue(0)}>Red</div>
                <div class="baseColorPicker" style={{ backgroundColor: 'blue' }} onClick={() => setHue(230)}>Blue</div>
                <div class="baseColorPicker" style={{ backgroundColor: 'yellow', color: 'black' }} onClick={() => setHue(60)}>Yellow</div>
            </div>) : null}
        </div>
    );
};

export default SaturationPicker;
