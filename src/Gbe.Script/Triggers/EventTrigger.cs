using System.Collections.Generic;
using Gbe.Script.Actions;
using Gbe.Script.Executor;
using Gbe.Script.Executor.Entities;

namespace Gbe.Script.Triggers
{
    public class EventTrigger : Trigger
    {
        private readonly string m_eventName;

        public EventTrigger(string eventName, List<Action> actions) : base(actions)
        {
            m_eventName = eventName;
        }

        public override void Register(GbsExecutor scriptExecutor, Entity entity)
        {
            scriptExecutor.RegisterEventTrigger(entity, Actions, m_eventName);
        }

        public override void Unregister(GbsExecutor scriptExecutor, Entity entity)
        {
            scriptExecutor.UnregisterEventTrigger(entity, Actions, m_eventName);
        }
    }
}