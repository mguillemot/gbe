using Gbe.Engine;
using Gbe.Script.Formulas;

namespace Gbe.Script.Parameters
{
    public class PositionParam : Param
    {
        private readonly Point2 m_position;

        public PositionParam(string positionRepr)
        {
            m_position = Point2.Parse(positionRepr);
        }

        public override void Execute(EvaluationContext context)
        {
            context.EvaluationEntity.Gear.Position = m_position;
        }

        public override Param Compile()
        {
            return this;
        }
    }
}