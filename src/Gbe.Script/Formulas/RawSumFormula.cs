using System;
using System.Collections.Generic;

namespace Gbe.Script.Formulas
{
    public class RawSumFormula : Formula
    {
        private readonly Formula m_left;
        private readonly List<bool> m_add;
        private readonly List<Formula> m_terms;

        public RawSumFormula(Formula left, List<bool> add, List<Formula> terms)
        {
            m_left = left;
            m_add = add;
            m_terms = terms;
        }

        public override float Evaluate(EvaluationContext context)
        {
            throw new ApplicationException("Raw sums should be compiled into multiple sums");
        }

        public override List<Formula> Compile()
        {
            var compiled = new List<Formula>();
            Formula currentFormula = m_left;
            for (int i = 0; i < m_terms.Count; i++)
            {
                var add = m_add[i];
                var term = m_terms[i];
                foreach (var compiledTerm in term.Compile())
                {
                    if (add)
                    {
                        currentFormula = new SumFormula(currentFormula, compiledTerm);
                    }
                    else
                    {
                        currentFormula = new DifferenceFormula(currentFormula, compiledTerm);
                    }
                    compiled.Add(currentFormula);
                }
            }
            foreach (var compiledLeft in m_terms.Compile())
            {
                foreach (var compiledRight in m_right.Compile())
                {
                    compiled.Add(new SumFormula(compiledLeft, compiledRight));
                }
            }
            return compiled;
        }
    }
}
