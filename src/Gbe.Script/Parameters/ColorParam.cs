using Gbe.Engine;
using Gbe.Script.Formulas;

namespace Gbe.Script.Parameters
{
    public class ColorParam : Param
    {
        private readonly Color m_color;

        public ColorParam(string colorRepr)
        {
            m_color = Color.Parse(colorRepr);
        }

        public override void Execute(EvaluationContext context)
        {
            context.EvaluationEntity.Gear.Color = m_color;
        }
    }
}