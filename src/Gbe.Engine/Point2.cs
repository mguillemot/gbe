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
    }
}