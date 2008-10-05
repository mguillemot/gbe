using System.Text.RegularExpressions;

namespace Gbe.Engine
{
    public struct Rectangle
    {
        private static readonly Regex REPRESENATION_REGEX = new Regex(@"(.*):(.*)->(.*):(.*)");

        
        public Point2 BottomRightCorner;
        public Point2 TopLeftCorner;

        public Rectangle(Point2 topLeftCorner, Point2 bottomRightCorner)
        {
            TopLeftCorner = topLeftCorner;
            BottomRightCorner = bottomRightCorner;
        }

        public Rectangle(float x1, float y1, float x2, float y2)
        {
            TopLeftCorner = new Point2(x1, y1);
            BottomRightCorner = new Point2(x2, y2);
        }

        public static Rectangle Parse(string repr)
        {
            var result = new Rectangle();
            var match = REPRESENATION_REGEX.Match(repr);
            if (match.Success)
            {
                result.TopLeftCorner.X = float.Parse(match.Groups[1].Value);
                result.TopLeftCorner.Y = float.Parse(match.Groups[2].Value);
                result.BottomRightCorner.X = float.Parse(match.Groups[3].Value);
                result.BottomRightCorner.Y = float.Parse(match.Groups[4].Value);
            }
            return result;
        }

        public override string ToString()
        {
            return TopLeftCorner + "->" + BottomRightCorner;
        }
    }
}