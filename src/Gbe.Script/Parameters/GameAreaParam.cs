using Gbe.Engine;
using Gbe.Script.Formulas;

namespace Gbe.Script.Parameters
{
    public class GameAreaParam : Param
    {
        private readonly Rectangle m_area;

        public GameAreaParam(string areaRepr)
        {
            m_area = Rectangle.Parse(areaRepr);
        }

        public override void Execute(EvaluationContext context)
        {
            // TODO
        }
    }
}