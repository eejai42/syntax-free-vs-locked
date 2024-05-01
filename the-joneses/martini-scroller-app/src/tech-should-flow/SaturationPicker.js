import React, { useState, useEffect } from "react";
import { HexColorPicker } from "react-colorful";
import { hslToHex, hexToHsl } from "../colorUtils";

const SaturationPicker = ({ transpilerNode, color, onChange, showPictures}) => {

    const [showPicker, setShowPicker] = useState(false);
    const [currentColor, setCurrentColor] = useState(color);

    useEffect(() => {
        onChange(currentColor);  // Ensure external changes are also pushed up
    }, [color, currentColor, onChange]);

    return (
        <div style={{ width: "10em", height: "11em", margin: "0.5em", border: 'solid 3px black', 
                      backgroundColor: currentColor, borderRadius: '0.45em', cursor: 'pointer' }} 
        className="outerHoverDiv"
        onClick={() => setShowPicker(true)}  // Set to true on click
        onMouseLeave={() => setShowPicker(false)}  
        >
            <div style={{ width: "10em", height: "10em" }}>
                <div className="pickerLabel">{currentColor}</div>
                <div style={{ position: "relative", width: "10em", height: "10em", margin: "0.8em", overflow: "hidden" }}>
                    <div className="presetBtnContainer" style={{ position: "absolute", top: 0, left: '-4em', width: "14.5em", height: "6em", overflow: "hidden", display: 'block'}}>
                        <div style={{display: showPicker ? 'block' : 'none' }}>
                        <HexColorPicker color={color} onChange={setCurrentColor}  />
                        </div>
                        <div style={{display: !showPicker && showPictures ? 'block' : 'none' }}>
                            <img src={transpilerNode?.LockedImage?.length ? transpilerNode.LockedImage : transpilerNode?.SyntaxFreeImage} style={{width: '8.5em', paddingLeft: '0.5em', marginLeft: '0.5em'}}/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
};

export default SaturationPicker;
