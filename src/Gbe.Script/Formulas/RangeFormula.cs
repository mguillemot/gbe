using System;
using System.Collections.Generic;

namespace Gbe.Script.Formulas
{
    public class RangeFormula : Formula
    {
        private readonly float m_start;
        private readonly float m_end;

        public RangeFormula(float start, float end)
        {
            m_start = start;
            m_end = end;
        }

        public override float Evaluate(EvaluationContext context)
        {
            throw new ApplicationException("Range should be compiled into multiple formulas");
        }

        public override List<Formula> Compile()
        {
            var compiled = new List<Formula>();
            float cursor = m_start;
            while (cursor <= m_end)
            {
                compiled.Add(new ConstValueFormula(cursor));
                cursor += 1;
            }
            return compiled;
        }
    }
}
