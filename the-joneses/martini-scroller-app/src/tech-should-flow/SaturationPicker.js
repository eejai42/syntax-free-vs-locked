import React, { useState, useEffect } from "react";
import { HexColorPicker } from "react-colorful";
import { hslToHex, hexToHsl } from "../colorUtils";
import { getContrastColor } from "../colorUtils";

const SaturationPicker = ({ color, onColorChange, src, label = "", isPickerAvailable=false, left='0em', onIsPickingChange}) => {

    let transpilerNode = null;
    const [showPicker, setShowPicker] = useState(false);
    const [currentColor, setCurrentColor] = useState(color);


    const handleColorChange = (newColor) => { 
        setCurrentColor(newColor);
        onColorChange(newColor);  // Ensure external changes are also pushed up
    };

    const handleSetShowPicker = (show) => { 
        setShowPicker(show);
        onIsPickingChange(show);
    };

    return (
        <div style={{ width: "90%", height: "14em", marginRight: '1em;', border: (false && isPickerAvailable? 'solid 1px #efefef' : ''), // commenging out temporarily
                       borderRadius: '0.45em', cursor: (isPickerAvailable ? 'pointer' : '') }} 
        className="outerHoverDiv"
        onClick={() => isPickerAvailable ? handleSetShowPicker(true) : null}  // Set to true on click
        onMouseLeave={() => handleSetShowPicker(false)}  
        >
            <div style={{ width: "18em", height: "15em", backgroundColor: {color} }}>
                {false && isPickerAvailable && <div className="pickerLabel" style={{backgroundColor: currentColor, color: getContrastColor(currentColor)}}>{label || currentColor}</div>}
                <div style={{ position: "absolute", width: "18em", paddingLeft: '1em', height: "10em", top: '1em' }}>
                    <div className="presetBtnContainer" style={{ position: "relative", top: '-1x', left: left, width: "14.5em", height: "12em", overflow: "hidden", display: 'block', zIndex: 9999999}}>
                        <div style={{display: showPicker ? 'block' : 'none', position: 'relative' }}>
                        <HexColorPicker style={{border: '', height: ''}} color={currentColor} onChange={handleColorChange}  />
                        </div>
                        <div style={{display: !showPicker && src ? 'block' : 'none' }}>
                            <img src={src} style={{width: '7.5em', paddingLeft: '0em', marginLeft: '0em'}}/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
};

export default SaturationPicker;
