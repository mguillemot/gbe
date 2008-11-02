using Gbe.Script.Formulas;

namespace Gbe.Script.Parameters
{
    public class CustomParam : Param
    {
        private readonly string m_name;
        private readonly Formula m_formula;

        public static CustomParam Create(string paramNameWithTrail, Formula formula)
        {
            return new CustomParam(paramNameWithTrail.Substring(1), formula);
        }

        private CustomParam(string name, Formula formula)
        {
            m_name = name;
            m_formula = formula;
        }

        public override Param Compile()
        {
            return new CustomParam(m_name, m_formula.Compile());
        }

        public override void Execute(EvaluationContext context)
        {
            var value = m_formula.Evaluate(context);
            context.EvaluationEntity.SetVariable(m_name, value);
        }
    }
}