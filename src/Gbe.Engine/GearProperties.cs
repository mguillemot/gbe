using System;
using System.Collections.Generic;

namespace Gbe.Engine
{
    public class NoSuchPropertyException : ApplicationException
    {
        private readonly string m_propertyName;

        public NoSuchPropertyException(string propertyName)
            : base("No such property: " + propertyName)
        {
            m_propertyName = propertyName;
        }

        public string PropertyName
        {
            get { return m_propertyName; }
        }
    }

    public static class GearProperties
    {
        public const string ANIMATION = "animation";
        public const string ANIMATION_FRAME = "animationFrame";
        public const string COLOR = "color";
        public const string POSITION = "position";
        public const string SPEED = "speed";
        public const string DIRECTION = "direction";
        public const string TRAINEE = "trainee";

        public static String GetAnimation(Gear gear)
        {
            if (gear.HasProperty(ANIMATION))
            {
                return (string)gear[ANIMATION];
            }
            throw new NoSuchPropertyException(ANIMATION);
        }

        public static void SetAnimation(Gear gear, string animation)
        {
            gear[ANIMATION] = animation;
        }

        public static int GetAnimationFrame(Gear gear)
        {
            if (gear.HasProperty(ANIMATION_FRAME))
            {
                return (int)gear[ANIMATION_FRAME];
            }
            throw new NoSuchPropertyException(ANIMATION_FRAME);
        }

        public static void SetAnimationFrame(Gear gear, int animationFrame)
        {
            gear[ANIMATION_FRAME] = animationFrame;
        }

        public static Color GetColor(Gear gear)
        {
            if (gear.HasProperty(COLOR))
            {
                return (Color)gear[COLOR];
            }
            throw new NoSuchPropertyException(COLOR);
        }

        public static void SetColor(Gear gear, Color color)
        {
            gear[COLOR] = color;
        }

        public static Point2 GetPosition(Gear gear)
        {
            if (gear.HasProperty(POSITION))
            {
                return (Point2)gear[POSITION];
            }
            throw new NoSuchPropertyException(POSITION);
        }

        public static void SetPosition(Gear gear, Point2 position)
        {
            gear[POSITION] = position;
        }
        public static float GetSpeed(Gear gear)
        {
            if (gear.HasProperty(SPEED))
            {
                return (float)gear[SPEED];
            }
            throw new NoSuchPropertyException(SPEED);
        }

        public static void SetSpeed(Gear gear, float speed)
        {
            gear[SPEED] = speed;
        }

        public static List<Point2> GetTrainee(Gear gear)
        {
            if (gear.HasProperty(TRAINEE))
            {
                return (List<Point2>)gear[TRAINEE];
            }
            throw new NoSuchPropertyException(TRAINEE);
        }

        public static void SetTrainee(Gear gear, List<Point2> trainee)
        {
            gear[TRAINEE] = trainee;
        }

        public static float GetDirection(Gear gear)
        {
            if (gear.HasProperty(DIRECTION))
            {
                return (float)gear[DIRECTION];
            }
            throw new NoSuchPropertyException(DIRECTION);
        }

        public static void SetDirection(Gear gear, float direction)
        {
            gear[DIRECTION] = direction;
        }
    }
}