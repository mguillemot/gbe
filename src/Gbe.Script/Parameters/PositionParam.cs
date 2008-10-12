using Gbe.Engine;

namespace Gbe.Script.Parameters
{
    public class PositionParam : Param
    {
        private readonly Point2 m_position;

        public PositionParam(string positionRepr)
        {
            m_position = Point2.Parse(positionRepr);
        }

        public override void Execute(Gear gear)
        {
            gear.Position = m_position;
        }
    }
}