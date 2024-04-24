import React, { useState, useEffect } from "react";
import { mixColors, hslToHex, hexToHsl } from "./colorUtils";
import SaturationPicker from "./SaturationPicker";

const YCombiner = ({
  externalColor1,
  externalColor2,
  onMixedColorChange,
  hideRightColor = false,
  defaultLeftColor = "#ff0000",
  defaultRightColor = "#ffff00",
  leftColorLabel = "missing-left-color-label", // Default label is an empty string
  rightColorLabel = "missing-right-color-label",
  transpilerLabel = "this-to-that",
  outputColorLabel = "missing-output-color-label",
  arrowColor = "missing-arrow-color",
  showArrows = false,
}) => {
  const [color1, setColor1] = useState(
externalColor1 || defaultLeftColor || "#ff0000"
  );
  const [color2, setColor2] = useState(
    externalColor2 || defaultRightColor || "#ff0000"
  );

  const [hue1, setHue1] = useState(hexToHsl(color1).h);
  const [hue2, setHue2] = useState(hexToHsl(color2).h);

  const mixedColor = hideRightColor ? color1 : mixColors(color1, color2);

  useEffect(() => {
    if (onMixedColorChange) {
      const mixedColor = hideRightColor ? color1 : mixColors(color1, color2);
      onMixedColorChange(mixedColor);
    }

    if (externalColor1) {
          setColor1(externalColor1);
          setHue1(hexToHsl(externalColor1).h);
        }
        if (externalColor2 && !hideRightColor) {
          setColor2(externalColor2);
          setHue2(hexToHsl(externalColor2).h);
        }
  }, [color1, color2, hideRightColor, onMixedColorChange, externalColor1, externalColor2, hideRightColor]);

  const [showSecondPicker, setShowSecondPicker] = useState(true); // You can toggle this based on your conditions

  return (
    <div
      style={{
        display: "flex",
        flexDirection: "column",
        alignItems: "center",
        padding: "1em",
      }}
    >
      <div>
        <table style={{ width: "25em" }}>
          <tbody>
            <tr>
              <td
                valign="top"
                colSpan={hideRightColor ? 2 : 1}
                style={{
                  textAlign: "center",
                  paddingLeft: hideRightColor ? "28%" : "0",
                }}
              >
                {externalColor1 ? (
                  <SaturationPicker
                    hue={hue1}
                    color={color1}
                    onChange={setColor1}
                    onHueChange={setHue1}
                    label={leftColorLabel}
                  />
                ) : (
                  <SaturationPicker
                    hue={hue1}
                    color={color1}
                    onChange={setColor1}
                    onHueChange={setHue1}
                    label={leftColorLabel}
                  />
                )}
                <div style={{ clear: "both" }}></div>
              </td>
              <td
                style={{ display: hideRightColor ? "none" : "block" }}
                valign="top"
              >
                {externalColor2 ? (
                  <SaturationPicker
                    hue={hue2}
                    color={color2}
                    onChange={setColor2}
                    onHueChange={setHue2}
                    label={rightColorLabel}
                  />
                ) : (
                  <SaturationPicker
                    hue={hue2}
                    color={color2}
                    onChange={setColor2}
                    onHueChange={setHue2}
                    label={rightColorLabel}
                  />
                )}
                <div style={{ clear: "both" }}></div>
              </td>
            </tr>
            <tr>
              <td colSpan={2} style={{ textAlign: "center", width: '22m' }}>
      
              <div className="transpilerLabel" ><span className="toolName">{transpilerLabel}</span><div className="arrow">⤵</div></div>
                <div
                  className="outputSpout"
                  style={{ backgroundColor: mixedColor }}
                >
                  {showArrows ? (
                    <div
                      className="arrow"
                      style={{
                        float: "left",
                        color: arrowColor,
                        marginLeft: "-0.5em",
                      }}
                    >
                      ↙
                    </div>
                  ) : null}
                  {showArrows ? (
                    <div
                      className="arrow"
                      style={{
                        float: "right",
                        color: arrowColor,
                        marginLeft: "-1em",
                      }}
                    >
                      ↘
                    </div>
                  ) : null}
                  <div className="pickerLabel">{outputColorLabel}</div>
                </div>
                <div style={{ clear: "both" }}></div>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  );
};

export default YCombiner;
