using System;
using System.Collections.Generic;

namespace Gbe.Script.Formulas
{
    public class DifferenceFormula : Formula
    {
        private readonly Formula m_left;
        private readonly Formula m_right;

        public DifferenceFormula(Formula left, Formula right)
        {
            m_left = left;
            m_right = right;
        }

        public override float Evaluate(EvaluationContext context)
        {
            return m_left.Evaluate(context) - m_right.Evaluate(context);
        }

        public override List<Formula> Compile()
        {
            throw new ApplicationException("Simple differences are already compiled");
        }

    }
}
