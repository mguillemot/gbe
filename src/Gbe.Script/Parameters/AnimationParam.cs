using Gbe.Engine.Executor;
using Gbe.Engine.Executor.Actions;

namespace Gbe.Script.Parameters
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

        public override ExecutorAction ToExecutorAction()
        {
            return new SetAnimationAction(_animation);
        }
    }
}