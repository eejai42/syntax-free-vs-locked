export const mixColors = (colorA, colorB) => {
  const hslA = hexToHsl(colorA);
  const hslB = hexToHsl(colorB);
  let correct = 0;
  let error = 0;
  let mixedHslg = hexToHsl('#800080');

  // Blending logic
  let mixedHsl, hVal;
  if (hslA.h > hslB.h) {
    error = 360 - hslA.h + hslB.h;
    hVal = error > 180 ? (hslA.h + hslB.h) / 2 : (hslA.h + hslB.h + 360) / 2;
  } else {
    error = 360 - hslB.h + hslA.h;
    hVal = error > 180 ? (hslB.h + hslA.h) / 2 : (hslB.h + hslA.h + 360) / 2;
  }
  hVal %= 360;
  correct = Math.abs(hslA.h - hslB.h);
  mixedHsl = {
    h: hVal,
    s: (hslA.s + hslB.s) / 2,
    l: (hslA.l + hslB.l) / 2,
  };

  let hex = hslToHex(mixedHsl.h, mixedHsl.s, mixedHsl.l);
  mixedHslg = hexToHsl(hex);
  return hex;
};

// Additional utility functions (colorUtils.js)
export const hslToHex = (h, s, l) => {
  l /= 100;
  const a = (s * Math.min(l, 1 - l)) / 100;
  const f = (n) => {
    const k = (n + h / 30) % 12;
    const color = l - a * Math.max(Math.min(k - 3, 9 - k, 1), -1);
    return Math.round(255 * color)
      .toString(16)
      .padStart(2, "0");
  };
  return `#${f(0)}${f(8)}${f(4)}`;
};

export const hexToHsl = (hex) => {
    hex = hex || '#800080'; // Default to 'purple
  let r = parseInt(hex.slice(1, 3), 16) / 255;
  let g = parseInt(hex.slice(3, 5), 16) / 255;
  let b = parseInt(hex.slice(5, 7), 16) / 255;

  const max = Math.max(r, g, b);
  const min = Math.min(r, g, b);
  let h,
    s,
    l = (max + min) / 2;

  if (max === min) {
    h = s = 0; // achromatic
  } else {
    const d = max - min;
    s = l > 0.5 ? d / (2 - max - min) : d / (max + min);
    switch (max) {
      case r:
        h = (g - b) / d + (g < b ? 6 : 0);
        break;
      case g:
        h = (b - r) / d + 2;
        break;
      case b:
        h = (r - g) / d + 4;
        break;
    }
    h /= 6;
  }

  return { h: h * 360, s: s * 100, l: l * 100 };
};
