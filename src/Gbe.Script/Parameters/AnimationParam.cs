using Gbe.Engine;
using Gbe.Script.Formulas;

namespace Gbe.Script.Parameters
{
    public class AnimationParam : Param
    {
        private readonly string m_animation;

        public AnimationParam(string animationRepr)
        {
            m_animation = animationRepr.Substring(1, animationRepr.Length - 2);
        }

        public override void Execute(EvaluationContext context)
        {
            context.EvaluationEntity.Gear.Animation = m_animation;
        }

        public override Param Compile()
        {
            return this;
        }
    }
}