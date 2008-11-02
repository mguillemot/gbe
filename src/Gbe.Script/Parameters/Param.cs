using Gbe.Script.Formulas;

namespace Gbe.Script.Parameters
{
    public abstract class Param
    {
        public abstract void Execute(EvaluationContext context);

        public virtual Param Compile()
        {
            return this;
        }
    }
}