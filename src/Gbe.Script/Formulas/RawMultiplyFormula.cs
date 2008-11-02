using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Gbe.Script.Formulas
{
    public class RawMultiplyFormula : Formula
    {
        private readonly List<Formula> m_factors;
        private readonly Formula m_left;
        private readonly List<bool> m_mul;

        public RawMultiplyFormula(Formula left, List<bool> mul, List<Formula> factors)
        {
            Debug.Assert(left != null, "RawMultiplyFormula: left is null");
            Debug.Assert(mul != null, "RawMultiplyFormula: mul is null");
            Debug.Assert(factors != null, "RawMultiplyFormula: factors is null");
            m_left = left;
            m_mul = mul;
            m_factors = factors;
        }

        public override float Evaluate(EvaluationContext context)
        {
            throw new ApplicationException(
                "Raw multiplications should be compiled into multiple multiplications/divisions");
        }

        public override Formula Compile()
        {
            if (m_factors.Count > 0)
            {
                Formula currentFormula = m_left;
                for (int i = 0; i < m_factors.Count; i++)
                {
                    var mul = m_mul[i];
                    var compiledFactor = m_factors[i].Compile();
                    if (mul)
                    {
                        currentFormula = new MultiplyFormula(currentFormula, compiledFactor);
                    }
                    else
                    {
                        currentFormula = new DivideFormula(currentFormula, compiledFactor);
                    }
                }
                return currentFormula;
            }
            return m_left.Compile();
        }
    }
}