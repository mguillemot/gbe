using Gbe.Engine.Executor;

namespace Gbe.Script.Actions
{
    public class PlayAnimationAction : Action
    {
        private readonly string _animation;

        public PlayAnimationAction(string target, string animation) : base(target)
        {
            _animation = animation;
        }

        public string Animation
        {
            get { return _animation; }
        }

        public override ExecutorAction ToExecutorAction(CompiledGbs context)
        {
            // TODO
            return null;
        }
    }
}