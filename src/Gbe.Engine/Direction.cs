namespace Gbe.Engine
{
    public struct Direction
    {
        private float _angle;

        public Direction(float angle)
        {
            _angle = angle.NormalizeAngle();
        }

        public float Angle
        {
            get { return _angle; }
            set { _angle = value.NormalizeAngle(); }
        }

        public static Direction Parse(string repr)
        {
            var result = new Direction();
            var split = repr.Split(new[] {'+', '-'});
            if (split.Length == 2)
            {
                float reference = 0f;
                switch (split[0])
                {
                    case "up":
                        reference = MathHelper.ANGLE_UP;
                        break;
                    case "right":
                        reference = MathHelper.ANGLE_RIGHT;
                        break;
                    case "down":
                        reference = MathHelper.ANGLE_DOWN;
                        break;
                    case "left":
                        reference = MathHelper.ANGLE_LEFT;
                        break;
                }
                float delta = float.Parse(split[1]);
                if (repr.Contains("-"))
                {
                    delta = -delta;
                }
                result.Angle = reference + delta;
            }
            return result;
        }
    }
}