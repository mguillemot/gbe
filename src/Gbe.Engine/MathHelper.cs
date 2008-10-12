using System;

namespace Gbe.Engine
{
    public static class MathHelper
    {
        public const float ANGLE_DOWN = (float) (Math.PI/2);
        public const float ANGLE_LEFT = (float) Math.PI;
        public const float ANGLE_RIGHT = 0;
        public const float ANGLE_UP = (float) (3*Math.PI/2);

        public const float PI = (float) Math.PI;
        public const float TWO_PI = (float) Math.PI*2;

        private static readonly Random _random = new Random();

        public static float GetAngleBetween(Point2 from, Point2 to)
        {
            return (float) (Math.PI/2 - Math.Atan2(to.X - from.X, to.Y - from.Y));
        }

        public static int Random(int max)
        {
            return _random.Next(max);
        }

        public static float RandomFloat()
        {
            return (float)_random.NextDouble();
        }

        public static float Cos(float angle)
        {
            return (float) Math.Cos(angle);
        }

        public static float Sin(float angle)
        {
            return (float) Math.Sin(angle);
        }

        public static float NormalizeAngle(this float angle)
        {
            var res = angle%TWO_PI;
            if (res > PI)
            {
                res -= TWO_PI;
            }
            else if (res < -PI)
            {
                res += TWO_PI;
            }
            return res;
        }
    }
}