using Gbe.Engine;

namespace Gbe.Script.Parameters
{
    public class SpeedParam : Param
    {
        private readonly float m_speed;

        public SpeedParam(float speed)
        {
            m_speed = speed;
        }

        public override void Execute(Gear gear)
        {
            gear.Speed = m_speed;
        }
    }
}