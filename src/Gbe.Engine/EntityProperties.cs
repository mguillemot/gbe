using System;
using System.Collections.Generic;

namespace Gbe.Engine
{
    public static class EntityProperties
    {
        public const string PROP_ANIMATION = "animation";
        public const string PROP_ANIMATION_FRAME = "animationFrame";
        public const string PROP_POSITION = "position";
        public const string PROP_SPEED = "speed";
        public const string PROP_TRAINEE = "trainee";

        public static readonly Type TYPE_ANIMATION = typeof (string);
        public static readonly Type TYPE_ANIMATION_FRAME = typeof (int);
        public static readonly Type TYPE_POSITION = typeof (Point2);
        public static readonly Type TYPE_SPEED = typeof (float);
        public static readonly Type TYPE_TRAINEE = typeof (List<Point2>);
    }
}