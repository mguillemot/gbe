using Gbe.Engine;
using Gbe.Script.Formulas;

namespace Gbe.Script.Parameters
{
    public class FpsParam : Param
    {
        private readonly float m_fps;

        public FpsParam(float fps)
        {
            m_fps = fps;
        }

        public override void Execute(EvaluationContext context)
        {
            // TODO
        }

        public override Param Compile()
        {
            return this;
        }
    }
}