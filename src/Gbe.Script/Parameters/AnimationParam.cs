using Gbe.Engine;

namespace Gbe.Script.Parameters
{
    public class AnimationParam : Param
    {
        private readonly string m_animation;

        public AnimationParam(string animationRepr)
        {
            m_animation = animationRepr.Substring(1, animationRepr.Length - 2);
        }

        public override void Execute(Gear gear)
        {
            gear.Animation = m_animation;
        }
    }
}