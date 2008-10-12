using System.Collections.Generic;
using Gbe.Script.Actions;
using Gbe.Script.Executor;

namespace Gbe.Script.Triggers
{
    public class EventTrigger : Trigger
    {
        private readonly string _eventName;

        public EventTrigger(string eventName, List<Action> actions) : base(actions)
        {
            _eventName = eventName;
        }

        public override void Register(GbsExecutor scriptExecutor, Entity entity)
        {
        }
    }
}