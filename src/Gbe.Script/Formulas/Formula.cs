﻿namespace Gbe.Script.Formulas
{
    public abstract class Formula
    {
        public abstract float Evaluate(EvaluationContext context);

        public virtual Formula Compile()
        {
            return this;
        }
    }
}
