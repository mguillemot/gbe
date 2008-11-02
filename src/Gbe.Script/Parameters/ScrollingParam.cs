using Gbe.Engine;
using Gbe.Script.Formulas;

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

        public override void Execute(EvaluationContext context)
        {
            // TODO
        }
    }
}