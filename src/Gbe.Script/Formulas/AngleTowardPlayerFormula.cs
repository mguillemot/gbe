﻿using System.Collections.Generic;
using Gbe.Engine;

namespace Gbe.Script.Formulas
{
    public class AngleTowardPlayerFormula : Formula
    {
        public override float Evaluate(EvaluationContext context)
        {
            return MathHelper.GetAngleBetween(context.EvaluationEntity.Gear.Position, context.PlayerPosition);
        }

        public override List<Formula> Compile()
        {
            return new List<Formula>(1){this};
        }
    }
}
