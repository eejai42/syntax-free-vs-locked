import React, { useState } from "react";
import YCombiner from "./YCombiner";

const SyntaxVisualizationComponent = ({topLeftColorLabel="svc-missing-top-left-color-label", 
                                      topTranspilerLabel="svc-missing-top-transpiler-label", 
                                      outputLabelName="svc-output-label-name",
                                      leftYTranspilerLabel="svc-missing-lefty-transpiler-label",
                                      leftYColorLabel="svc-missing-lefty-color-label",
                                      leftYRightColorLabel="svc-missing-lefty-right-color-label",
                                      rightYTranspilerLabel="svc-missing-righty-transpiler-label",
                                      rightYRightColorLabel="svc-missing-righty-right-color-label",
                                      rightYColorLabel="svc-missing-righty-color-label",
                                      arrowColor = '#FFFFFF',
                                      showArrows = true,
                                      followAlong = false
                                    }) => {
  const [outputColor, setOutputColor] = useState("#ff00ff"); // Initial color set to a placeholder
  const presets = [{
    "Type": "Input",
    "Name" : "Requirements v1",
    "SyntaxLocked": "Natural Language",
    "SyntaxFree": "Airtable"
  },{
    "Type": "Input",
    "Name" : "Requirements v2",
    "SyntaxLocked": "Natural Language",
    "SyntaxFree": "Airtable"
  },{
    "Type": "Input",
    "Name" : "Grg Dr Opener",
    "SyntaxLocked": "Natural Language",
    "SyntaxFree": "Airtable",
    "Ouptut": "Devices.json",
  },{
    "Type": "Left",
    "Name": "Python",
    "SyntaxLocked": "Common.py",
    "SyntaxFree": "Python.hbars",
    "Ouptut": "Common..py",
  },{
    "Type": "Left",
    "Name": "C++",
    "SyntaxLocked":  "Common.h/cpp",
    "SyntaxFree": "Arduino.hbars",
    "Ouptut": "Common.h/cpp",
  },{
    "Type": "Left",
    "Name": "C#",
    "SyntaxLocked":  "Common.cs",
    "SyntaxFree": "DotNet.hbars",
    "Ouptut": "Common.cs",
  },{
    "Type": "Right",
    "Name": "HTML",
    "SyntaxLocked":  "README.html",
    "SyntaxFree":  "README.hbars",
    "Ouptut": "README.md",
  },{
    "Type": "Right",
    "Name": "Markdown",
    "SyntaxLocked":  "README.md",
    "SyntaxFree":  "README.hbars",
    "Ouptut": "README.md",
  },{
    "Type": "Right",
    "Name": "WIKI docs",
    "SyntaxLocked":  "README.wiki",
    "SyntaxFree":  "README.hbars",
    "Ouptut": "README.md",
  }
]

  const handleColorChange = (color) => {
    if (color === outputColor) return; // Prevent infinite loop
    setOutputColor(color);
  };

  return (
    <table className="yCombinerCanvas">
      <tbody>
      <tr>
        <td colSpan={2} style={{ textAlign: "center" }}>
          {/* Replace SaturationPicker with YCombiner */}
          <YCombiner key="inputCombiner"
            leftColorLabel={topLeftColorLabel}
            rightColorLabel="this should be getting ignored"
            hideRightColor={true} // Hide the right picker
            onMixedColorChange={handleColorChange}
            defaultLeftColor="#0042FF"
            defaultRightColor="#0042FF"
            outputColorLabel={outputLabelName}
            transpilerLabel={topTranspilerLabel}
            arrowColor={arrowColor}
            showArrows={showArrows}
            topLeftPreset1={presets[0]}
            topLeftPreset2={presets[1]}
            topLeftPreset3={presets[2]}
            alignment="center"
          />
        </td>
      </tr>
      <tr>
        <td >
          {/* Pass the output color from the top YCombiner to this YCombiner */}
          <YCombiner key="bottomLeft"   style={{backgroundColor: 'red', paddingLeft: '5em'}}
            externalColor2={outputColor}
            onMixedColorChange={() => {}}
            // link the leftColor , as a string, to the defaultLeftColor prop
            defaultRightColor="#ff0000"
            leftColorLabel={leftYColorLabel}
            rightColorLabel={leftYRightColorLabel}
            transpilerLabel={leftYTranspilerLabel}
            outputColorLabel="Common.h/cpp"
            followAlong={followAlong}
            topLeftPreset1={presets[3]}
            topLeftPreset2={presets[4]}
            topLeftPreset3={presets[5]}
            alignment="flex-end"
          />
        </td>
        <td>
          {/* Another YCombiner using the output color */}
          <YCombiner key="bottomRight"
            externalColor1={outputColor}
            onMixedColorChange={() => {}}
            defaultRightColor="#Efff00"
            leftColorLabel={rightYColorLabel}
            rightColorLabel={rightYRightColorLabel}
            transpilerLabel={rightYTranspilerLabel}
            outputColorLabel="README.md"
            followAlong={followAlong}
            topRightPreset1={presets[6]}
            topRightPreset2={presets[7]}
            topRightPreset3={presets[8]}
          />
        </td>
      </tr>
      </tbody>
    </table>
  );
};

export default SyntaxVisualizationComponent;
