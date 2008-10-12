using System.Collections.Generic;
using Gbe.Script.Actions;
using Gbe.Script.Executor;
using Gbe.Script.Executor.Entities;

namespace Gbe.Script.Triggers
{
    public class AnimationEndTrigger : Trigger
    {
        private readonly string _animation;

        public AnimationEndTrigger(string animation, List<Action> actions)
            : base(actions)
        {
            _animation = animation;
        }

        public override void Register(GbsExecutor scriptExecutor, Entity entity)
        {
        }

        public override void Unregister(GbsExecutor executor, StateEntity entity)
        {
        }
    }
}