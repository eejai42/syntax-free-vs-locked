import React, { useState, useEffect } from "react";
import { HexColorPicker } from "react-colorful";
import { hslToHex, hexToHsl } from "../colorUtils";

const SaturationPicker = ({ color, onColorChange, src, label = "", isPickerAvailable=false}) => {

    let transpilerNode = null;
    const [showPicker, setShowPicker] = useState(false);
    const [currentColor, setCurrentColor] = useState(color);


    const handleColorChange = (newColor) => { 
        setCurrentColor(newColor);
        onColorChange(newColor);  // Ensure external changes are also pushed up
    };

    return (
        <div style={{ width: "100%", height: "15em", margin: "0.5em", marginRight: '1em;', border: (isPickerAvailable ? 'solid 3px black' : ''), 
                       borderRadius: '0.45em', cursor: (isPickerAvailable ? 'pointer' : '') }} 
        className="outerHoverDiv"
        onClick={() => isPickerAvailable ? setShowPicker(true) : null}  // Set to true on click
        onMouseLeave={() => setShowPicker(false)}  
        >
            <div style={{ width: "10em", height: "10em", backgroundColor: {color} }}>
                <div className="pickerLabel" style={{backgroundColor: currentColor}}>{label || currentColor}</div>
                <div style={{ position: "absolute", width: "10em", height: "10em", top: '2em', margin: "0.8em", overflow: "hidden" }}>
                    <div className="presetBtnContainer" style={{ position: "relative", top: '0px', left: '-7em', width: "14.5em", height: "19em", overflow: "hidden", display: 'block', zIndex: 9999999}}>
                        <div style={{display: showPicker ? 'block' : 'none', position: 'relative' }}>
                        <HexColorPicker style={{border: '', height: ''}} color={currentColor} onChange={handleColorChange}  />
                        </div>
                        <div style={{display: !showPicker && src ? 'block' : 'none' }}>
                            <img src={src} style={{width: '8.5em', paddingLeft: '0.5em', marginLeft: '0.5em'}}/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
};

export default SaturationPicker;
