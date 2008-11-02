using System.Collections.Generic;

namespace Gbe.Script.Formulas
{
    public class ConstValueFormula : Formula
    {
        private readonly float m_constValue;

        public ConstValueFormula(float constValue)
        {
            m_constValue = constValue;
        }

        public override float Evaluate(EvaluationContext context)
        {
            return m_constValue;
        }
    }
}
