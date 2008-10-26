using System.Collections.Generic;

namespace Gbe.Script.Formulas
{
    public abstract class Formula
    {
        public abstract float Evaluate(EvaluationContext context);

        public abstract List<Formula> Compile();
    }
}
