using Gbe.Engine.Executor;
using Gbe.Script.Executor;

namespace Gbe.Script.Actions
{
    public class PlayAnimationAction : Action
    {
        private readonly string m_animation;

        public PlayAnimationAction(string target, string animation) 
            : base(target)
        {
            m_animation = animation;
        }

        public override void Execute(GbsExecutor scriptExecutor, Entity entity)
        {
        }
    }
}