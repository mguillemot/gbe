using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Gbe.Script.Formulas
{
    public class RawMultiplyFormula : Formula
    {
        private readonly List<Formula> m_factors;
        private readonly Formula m_left;
        private readonly List<byte> m_operation;

        public RawMultiplyFormula(Formula left, List<byte> operation, List<Formula> factors)
        {
            Debug.Assert(left != null, "RawMultiplyFormula: left is null");
            Debug.Assert(operation != null, "RawMultiplyFormula: mul is null");
            Debug.Assert(factors != null, "RawMultiplyFormula: factors is null");
            m_left = left;
            m_operation = operation;
            m_factors = factors;
        }

        public override float Evaluate(EvaluationContext context)
        {
            throw new ApplicationException(
                "Raw multiplications should be compiled into multiple multiplications/divisions");
        }

        public override Formula Compile()
        {
            Formula currentFormula = m_left.Compile();
            if (m_factors.Count > 0)
            {
                for (int i = 0; i < m_factors.Count; i++)
                {
                    var operation = m_operation[i];
                    var compiledFactor = m_factors[i].Compile();
                    switch (operation)
                    {
                        case 0:
                            currentFormula = new MultiplyFormula(currentFormula, compiledFactor);
                            break;
                        case 1:
                            currentFormula = new DivideFormula(currentFormula, compiledFactor);
                            break;
                        case 2:
                            currentFormula = new ModuloFormula(currentFormula, compiledFactor);
                            break;
                        default:
                            throw new SyntaxException("RawMultiplyFormula", "invalid operation " + operation);
                    }
                }
            }
            return currentFormula;
        }
    }
}