using Gbe.Engine;
using Gbe.Script.Formulas;

namespace Gbe.Script.Parameters
{
    public class SpeedParam : Param
    {
        private readonly float m_speed;

        public SpeedParam(float speed)
        {
            m_speed = speed;
        }

        public override void Execute(EvaluationContext context)
        {
            context.EvaluationEntity.Gear.Speed = m_speed;
        }
    }
}