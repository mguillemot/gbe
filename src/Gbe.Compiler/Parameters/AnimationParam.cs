using Gbe.Engine;

namespace Gbe.Compiler.Parameters
{
    public class AnimationParam : Param
    {
        private readonly string _animation;

        public AnimationParam(string animationRepr)
        {
            _animation = animationRepr.Substring(1, animationRepr.Length - 2);
        }

        public string Animation
        {
            get { return _animation; }
        }

        public override void Set(Entity engineEntity)
        {
            engineEntity.Animation = _animation;
        }
    }
}
