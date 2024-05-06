import React, { useState, useEffect } from "react";
import { HexColorPicker } from "react-colorful";
import { hslToHex, hexToHsl } from "../colorUtils";
import { getContrastColor } from "../colorUtils";

const SaturationPicker = ({ color, onColorChange, src, label = "", isPickerAvailable=false}) => {

    let transpilerNode = null;
    const [showPicker, setShowPicker] = useState(false);
    const [currentColor, setCurrentColor] = useState(color);


    const handleColorChange = (newColor) => { 
        setCurrentColor(newColor);
        onColorChange(newColor);  // Ensure external changes are also pushed up
    };

    return (
        <div style={{ width: "90%", height: "18em", margin: "0.5em", marginRight: '1em;', border: (isPickerAvailable ? 'solid 1px lightgray' : ''), 
                       borderRadius: '0.45em', cursor: (isPickerAvailable ? 'pointer' : '') }} 
        className="outerHoverDiv"
        onClick={() => isPickerAvailable ? setShowPicker(true) : null}  // Set to true on click
        onMouseLeave={() => setShowPicker(false)}  
        >
            <div style={{ width: "18em", height: "15em", backgroundColor: {color} }}>
                <div className="pickerLabel" style={{backgroundColor: currentColor, color: getContrastColor(currentColor)}}>{label || currentColor}</div>
                <div style={{ position: "absolute", width: "18em", paddingLeft: '1em', height: "10em", top: '2em', margin: "0.8em" }}>
                    <div className="presetBtnContainer" style={{ position: "relative", top: '0px', left: '-1em', width: "14.5em", height: "19em", overflow: "hidden", display: 'block', zIndex: 9999999}}>
                        <div style={{display: showPicker ? 'block' : 'none', position: 'relative' }}>
                        <HexColorPicker style={{border: '', height: ''}} color={currentColor} onChange={handleColorChange}  />
                        </div>
                        <div style={{display: !showPicker && src ? 'block' : 'none' }}>
                            <img src={src} style={{width: '9.5em', paddingLeft: '0em', marginLeft: '0em'}}/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
};

export default SaturationPicker;
