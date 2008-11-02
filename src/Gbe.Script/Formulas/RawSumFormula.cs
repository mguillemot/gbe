using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Gbe.Script.Formulas
{
    public class RawSumFormula : Formula
    {
        private readonly Formula m_left;
        private readonly List<bool> m_signs;
        private readonly List<Formula> m_terms;

        public RawSumFormula(Formula left, List<bool> signs, List<Formula> terms)
        {
            Debug.Assert(left != null, "First term is null");
            Debug.Assert(signs != null, "Signs is null");
            Debug.Assert(terms != null, "Other terms is null");
            m_left = left;
            m_signs = signs;
            m_terms = terms;
        }

        public override float Evaluate(EvaluationContext context)
        {
            throw new ApplicationException("Raw sums should be compiled into multiple sums/differences");
        }

        public override Formula Compile()
        {
            if (m_terms.Count > 0)
            {
                Formula currentFormula = m_left;
                for (int i = 0; i < m_terms.Count; i++)
                {
                    var add = m_signs[i];
                    var compiledTerm = m_terms[i].Compile();
                    if (add)
                    {
                        currentFormula = new SumFormula(currentFormula, compiledTerm);
                    }
                    else
                    {
                        currentFormula = new DifferenceFormula(currentFormula, compiledTerm);
                    }
                }
                return currentFormula;
            }
            return m_left.Compile();
        }
    }
}