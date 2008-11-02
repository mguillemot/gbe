namespace Gbe.Script.Formulas
{
    public class ModuloFormula : Formula
    {
        private readonly Formula m_left;
        private readonly Formula m_right;

        public ModuloFormula(Formula left, Formula right)
        {
            m_left = left;
            m_right = right;
        }

        public override float Evaluate(EvaluationContext context)
        {
            return m_left.Evaluate(context)%m_right.Evaluate(context);
        }
    }
}