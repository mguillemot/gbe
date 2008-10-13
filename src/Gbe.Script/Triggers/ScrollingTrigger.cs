using System.Collections.Generic;
using Gbe.Script.Actions;
using Gbe.Script.Executor;
using Gbe.Script.Executor.Entities;

namespace Gbe.Script.Triggers
{
    public class ScrollingTrigger : Trigger
    {
        private readonly float _scrolling;

        public ScrollingTrigger(float scrolling, List<Action> actions)
            : base(actions)
        {
            _scrolling = scrolling;
        }

        public override void Register(GbsExecutor scriptExecutor, Entity entity)
        {
        }

        public override void Unregister(GbsExecutor executor, Entity entity)
        {
        }
    }
}