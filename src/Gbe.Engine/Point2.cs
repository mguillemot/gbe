using System;

namespace Gbe.Engine
{
    public struct Point2
    {
        public float X;
        public float Y;

        public Point2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public int RoundX
        {
            get { return (int) Math.Round(X); }
        }

        public int RoundY
        {
            get { return (int) Math.Round(Y); }
        }

        public static float Distance(Point2 a, Point2 b)
        {
            var dx = b.X - a.X;
            var dy = b.Y - a.Y;
            return (float) Math.Sqrt(dx*dx + dy*dy);
        }

        public override string ToString()
        {
            return X + ":" + Y;
        }

        public static Point2 Parse(string repr)
        {
            var split = repr.Split(new char[] {':'});
            var result = new Point2();
            if (split.Length == 2)
            {
                result.X = float.Parse(split[0]);
                result.Y = float.Parse(split[1]);
            }
            return result;
        }
    }
}