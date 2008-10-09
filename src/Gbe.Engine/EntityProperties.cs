using System;
using System.Collections.Generic;

namespace Gbe.Engine
{
    public static class EntityProperties
    {
        public const string ANIMATION = "animation";
        public const string ANIMATION_FRAME = "animationFrame";
        public const string COLOR = "color";
        public const string POSITION = "position";
        public const string SPEED = "speed";
        public const string TRAINEE = "trainee";

        public static String GetAnimation(Entity entity)
        {
            if (entity.HasProperty(ANIMATION))
            {
                return (string)entity[ANIMATION];
            }
            throw new NoSuchPropertyException(ANIMATION);
        }

        public static void SetAnimation(Entity entity, string animation)
        {
            entity[ANIMATION] = animation;
        }

        public static int GetAnimationFrame(Entity entity)
        {
            if (entity.HasProperty(ANIMATION_FRAME))
            {
                return (int)entity[ANIMATION_FRAME];
            }
            throw new NoSuchPropertyException(ANIMATION_FRAME);
        }

        public static void SetAnimationFrame(Entity entity, int animationFrame)
        {
            entity[ANIMATION_FRAME] = animationFrame;
        }

        public static Color GetColor(Entity entity)
        {
            if (entity.HasProperty(COLOR))
            {
                return (Color)entity[COLOR];
            }
            throw new NoSuchPropertyException(COLOR);
        }

        public static void SetColor(Entity entity, Color color)
        {
            entity[COLOR] = color;
        }

        public static Point2 GetPosition(Entity entity)
        {
            if (entity.HasProperty(POSITION))
            {
                return (Point2)entity[POSITION];
            }
            throw new NoSuchPropertyException(POSITION);
        }

        public static void SetPosition(Entity entity, Point2 position)
        {
            entity[POSITION] = position;
        }
        public static float GetSpeed(Entity entity)
        {
            if (entity.HasProperty(SPEED))
            {
                return (float)entity[SPEED];
            }
            throw new NoSuchPropertyException(SPEED);
        }

        public static void SetSpeed(Entity entity, float speed)
        {
            entity[SPEED] = speed;
        }
        public static List<Point2> GetTrainee(Entity entity)
        {
            if (entity.HasProperty(TRAINEE))
            {
                return (List<Point2>)entity[TRAINEE];
            }
            throw new NoSuchPropertyException(TRAINEE);
        }

        public static void SetTrainee(Entity entity, List<Point2> trainee)
        {
            entity[TRAINEE] = trainee;
        }

    }
}