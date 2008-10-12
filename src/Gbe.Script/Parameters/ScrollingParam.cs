using Gbe.Engine;

namespace Gbe.Script.Parameters
{
    public class ScrollingParam : Param
    {
        private readonly Direction m_direction;
        private readonly float m_speed;

        public ScrollingParam(string directionRepr, float speed)
        {
            m_direction = Direction.Parse(directionRepr);
            m_speed = speed;
        }

        public override void Execute(Gear gear)
        {
            // TODO
        }
    }
}