namespace Gbe.Script.Formulas
{
    public class CurrentAngleFormula : Formula
    {
        public override float Evaluate(EvaluationContext context)
        {
            return context.EvaluationEntity.Gear.Direction;
        }
    }
}