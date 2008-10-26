using System.Collections.Generic;

namespace Gbe.Script.Formulas
{
    public class MultiplyFormula : Formula
    {
        private readonly Formula m_left;
        private readonly Formula m_right;

        public MultiplyFormula(Formula left, Formula right)
        {
            m_left = left;
            m_right = right;
        }

        public override float Evaluate(EvaluationContext context)
        {
            return m_left.Evaluate(context)*m_right.Evaluate(context);
        }

        public override List<Formula> Compile()
        {
            var compiled = new List<Formula>();
            foreach (var compiledLeft in m_left.Compile())
            {
                foreach (var compiledRight in m_right.Compile())
                {
                    compiled.Add(new MultiplyFormula(compiledLeft, compiledRight));                    
                }
            }
            return compiled;
        }

    }
}
