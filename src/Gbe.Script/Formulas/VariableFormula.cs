namespace Gbe.Script.Formulas
{
    public class VariableFormula : Formula
    {
        private readonly string m_name;

        public VariableFormula(string prefixedName)
        {
            m_name = prefixedName.Substring(1);
        }

        public override float Evaluate(EvaluationContext context)
        {
            return context.EvaluationEntity.GetVariable(m_name);
        }
    }
}