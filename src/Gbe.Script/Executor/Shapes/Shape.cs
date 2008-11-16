using Gbe.Engine;

namespace Gbe.Script.Shapes
{
    public abstract class Shape
    {
        public abstract Point2 CurrentPosition
        {
            get;
        }

        public abstract bool Ended
        {
            get;
        }

        public abstract void Advance(float distance);
    }
}
