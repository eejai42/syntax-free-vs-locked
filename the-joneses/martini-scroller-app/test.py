def rgb_to_ryb(r, g, b):
    # White
    w = min(r, g, b)
    r, g, b = r - w, g - w, b - w

    # Yellow
    my = min(r, g)
    r, g = r - my, g - my

    # Blue and Red
    by = min(b, g)
    b -= by
    ry = min(r, b)
    r, b = r - ry, b - ry

    # Combine to form RYB
    return (r + ry, my + by + ry, b + by)

def ryb_to_rgb(r, y, b):
    # White
    w = min(r, y, b)
    r, y, b = r - w, y - w, b - w

    # Green
    mg = min(y, b)
    y, b = y - mg, b - mg

    # Red and Blue
    my = min(r, y)
    r, y = r - my, y - my
    by = min(b, r)
    b, r = b - by, r - by

    # Combine to form RGB
    return (r + my + by, y + mg + by, b + by)

def mix_ryb(c1, c2):
    return tuple((a + b) // 2 for a, b in zip(c1, c2))

def rgb_hex(rgb):
    return "#{:02X}{:02X}{:02X}".format(*rgb)

# Example usage
colors = {
    "red": (255, 0, 0),
    "blue": (0, 0, 255),
    "yellow": (255, 255, 0)
}

mixed_pairs = [
    ("red", "blue"),
    ("red", "yellow"),
    ("blue", "yellow")
]

for c1_name, c2_name in mixed_pairs:
    c1_rgb = colors[c1_name]
    c2_rgb = colors[c2_name]
    c1_ryb = rgb_to_ryb(*c1_rgb)
    c2_ryb = rgb_to_ryb(*c2_rgb)
    mixed_ryb = mix_ryb(c1_ryb, c2_ryb)
    mixed_rgb = ryb_to_rgb(*mixed_ryb)
    print(f"Mixed {c1_name} and {c2_name} -> {rgb_hex(mixed_rgb)} (RYB method)")
