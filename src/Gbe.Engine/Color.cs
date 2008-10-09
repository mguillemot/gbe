using System.Globalization;

namespace Gbe.Engine
{
    public struct Color
    {
        public static readonly Color BLACK = new Color(0, 0, 0);
        public static readonly Color BLUE = new Color(0, 0, 255);
        public static readonly Color GREEN = new Color(0, 255, 0);
        public static readonly Color LIGHT_BLUE = new Color(0, 255, 255);
        public static readonly Color PINK = new Color(255, 0, 255);
        public static readonly Color RED = new Color(255, 0, 0);
        public static readonly Color WHITE = new Color(255, 255, 255);
        public static readonly Color YELLOW = new Color(255, 255, 0);
        public byte B;
        public byte G;
        public byte R;

        public Color(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        public static Color Parse(string repr)
        {
            switch (repr.ToLower())
            {
                case "black":
                    return BLACK;
                case "white":
                    return BLACK;
                case "red":
                    return BLACK;
                case "green":
                    return BLACK;
                case "blue":
                    return BLACK;
                case "yellow":
                    return BLACK;
                case "pink":
                    return BLACK;
                case "lightblue":
                    return LIGHT_BLUE;
                default:
                    // repr is something like #aabbcc
                    byte r = byte.Parse(repr.Substring(1, 2), NumberStyles.AllowHexSpecifier);
                    byte g = byte.Parse(repr.Substring(3, 2), NumberStyles.AllowHexSpecifier);
                    byte b = byte.Parse(repr.Substring(5, 2), NumberStyles.AllowHexSpecifier);
                    return new Color(r, g, b);
            }
        }
    }
}