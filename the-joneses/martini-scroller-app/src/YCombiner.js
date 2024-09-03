import React, { useState, useEffect } from "react";
import { mixColors, hslToHex, hexToHsl } from "./colorUtils";
import SaturationPicker from "./SaturationPicker";

const YCombiner = ({
  externalColor1,
  externalColor2,
  onMixedColorChange,
  hideRightColor = false,
  defaultLeftColor = "#ff0000",
  defaultRightColor = "#bfff00",
  leftColorLabel = "missing-left-color-label", // Default label is an empty string
  rightColorLabel = "missing-right-color-label",
  transpilerLabel = "this-to-that",
  outputColorLabel = "missing-output-color-label",
  arrowColor = "missing-arrow-color",
  showArrows = false,
  followAlong = false, // New property to control behavior
  topLeftPreset1,
  topLeftPreset2,
  topLeftPreset3,
  topRightPreset1,
  topRightPreset2,
  topRightPreset3,
  alignment = "flex-start",
  isSyntaxFree = false,
  showPictures = true,
}) => {
  const [color1, setColor1] = useState(
    externalColor1 || defaultLeftColor || "#ff0000"
  );
  const [color2, setColor2] = useState(
    externalColor2 || defaultRightColor || "#ff0000"
  );

  const [hue1, setHue1] = useState(hexToHsl(color1).h);
  const [hue2, setHue2] = useState(hexToHsl(color2).h);
  const [currentPreset, setCurrentPreset] = useState(
    topLeftPreset1 || topRightPreset1
  );

  const mixedColor = hideRightColor ? color1 : mixColors(color1, color2);

  const handlePresetChange = (preset) => {
    setCurrentPreset(preset);
  };

  useEffect(() => {
    if (onMixedColorChange) {
      const mixedColor = hideRightColor ? color1 : mixColors(color1, color2);
      onMixedColorChange(mixedColor);
    }

    if (followAlong) {
      if (externalColor1) {
        setColor1(externalColor1);
        setHue1(hexToHsl(externalColor1).h);
      }
      if (externalColor2 && !hideRightColor) {
        setColor2(externalColor2);
        setHue2(hexToHsl(externalColor2).h);
      }
    }
  }, [
    color1,
    color2,
    hideRightColor,
    onMixedColorChange,
    externalColor1,
    externalColor2,
    hideRightColor,
    followAlong,
  ]);

  return (
    <div
      style={{
        display: "flex",
        flexDirection: "column",
        alignItems: alignment,
        padding: "1em",
      }}
    >
      <div>
        <table
          style={{
            width: "25em",
            float: alignment == "flex-end" ? "right" : "none",
          }}
        >
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
                    hue={235}
                    color={color1}
                    onChange={setColor1}
                    onHueChange={setHue1}
                    preset={currentPreset}
                    onPresetChange={(preset) => handlePresetChange(preset)}
                    label={leftColorLabel}
                    preset1={topLeftPreset1}
                    preset2={topLeftPreset2}
                    preset3={topLeftPreset3}
                    isSyntaxFree={isSyntaxFree}
                    lockedImage={currentPreset.LockedImage}
                    freeImage={currentPreset.FreeImage}
                    showPictures={showPictures}
            />
                ) : (
                  <SaturationPicker
                    hue={hue1}
                    color={color1}
                    onChange={setColor1}
                    onHueChange={setHue1}
                    label={
                      isSyntaxFree
                        ? currentPreset.SyntaxFree
                        : currentPreset.Name
                    }
                    preset={currentPreset}
                    onPresetChange={(preset) => handlePresetChange(preset)}
                    preset1={topLeftPreset1}
                    preset2={topLeftPreset2}
                    preset3={topLeftPreset3}
                    isSyntaxFree={isSyntaxFree}
                    lockedImage={currentPreset.LockedImage}
                    freeImage={currentPreset.FreeImage}
                    showPictures={showPictures}
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
                    hue={235}
                    color={color2}
                    onChange={setColor2}
                    onHueChange={setHue2}
                    label={rightColorLabel}
                    preset={currentPreset}
                    onPresetChange={(preset) => setCurrentPreset(preset)}
                    preset1={topRightPreset1}
                    preset2={topRightPreset2}
                    preset3={topRightPreset3}
                    presetsOnRight={true}
                    isSyntaxFree={isSyntaxFree}
                    lockedImage={currentPreset.RightLockedImage}
                    freeImage={currentPreset.RightFreeImage}
                    showPictures={showPictures}
                />
                ) : (
                  <SaturationPicker
                    hue={hue2}
                    color={color2}
                    onChange={setColor2}
                    onHueChange={setHue2}
                    label={
                      isSyntaxFree
                        ? currentPreset.SyntaxFree
                        : currentPreset.Name
                    }
                    preset={currentPreset}
                    onPresetChange={(preset) => setCurrentPreset(preset)}
                    preset1={topRightPreset1}
                    preset2={topRightPreset2}
                    preset3={topRightPreset3}
                    presetsOnRight={true}
                    isSyntaxFree={isSyntaxFree}
                    lockedImage={currentPreset.RightLockedImage}
                    freeImage={currentPreset.RightFreeImage}
                    showPictures={showPictures}
                 />
                )}

                <div style={{ clear: "both" }}></div>
              </td>
            </tr>
            <tr>
              <td colSpan={2}>
                {hideRightColor ? null : (
                  <div>
                  <div className="transpilerLabel">
                    <span className="toolName">{transpilerLabel}</span>
                  </div>

                  </div>
                )}
              </td>
            </tr>

            {hideRightColor ? null : (
              <tr>
                <td colSpan={2} style={{ textAlign: "center", width: "22m" }}>
                  <div className="derivedLabel" style={{ width: "6em" }}>
                    <div className="arrow">↘&nbsp;&nbsp;&nbsp;↙</div>
                  </div>

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
                        ⬇
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
                        ⬇
                      </div>
                    ) : null}
                    <div className="pickerLabel">{currentPreset?.Output}</div>
                  </div>

                  <div style={{ clear: "both" }}></div>
                </td>
              </tr>
            )}
            {hideRightColor ? (
              <tr>
                <td colSpan={2}>
                  <div className="derivedLabel" style={{ width: "6em" }}>
                    <div className="arrow">⬇</div>
                  </div>

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
                        ⬇
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
                        ⬇
                      </div>
                    ) : null}
                    <div className="pickerLabel">{outputColorLabel}</div>
                  </div>
                </td>
              </tr>
            ) : null}
                        <tr>
              <td colSpan={2}>
                {hideRightColor ? (
                  <div>
                    <div className="transpilerLabel">
                      <span className="toolName">{transpilerLabel}</span>
                    </div>
                    <div className="derivedLabel" style={{ width: "6em" }}>
                      <div className="arrow">↙&nbsp;&nbsp;&nbsp;↘</div>
                    </div>
                  </div>
                ) : null}
              </td>
            </tr>

          </tbody>
        </table>
      </div>
    </div>
  );
};

export default YCombiner;
