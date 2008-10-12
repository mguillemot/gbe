using System.Collections.Generic;
using Gbe.Script.Actions;
using Gbe.Script.Executor;
using Gbe.Script.Executor.Entities;

namespace Gbe.Script.Triggers
{
    public class PeriodicTrigger : Trigger
    {
        private readonly float m_period;

        public PeriodicTrigger(float period, List<Action> actions)
            : base(actions)
        {
            m_period = period;
        }

        public override void Register(GbsExecutor scriptExecutor, Entity entity)
        {
            scriptExecutor.RegisterTimeTrigger(scriptExecutor.Engine.Context.TotalElapsedSeconds, entity, Actions, m_period);
        }

        public override void Unregister(GbsExecutor scriptExecutor, StateEntity entity)
        {
            scriptExecutor.UnregisterTimeTrigger(entity, Actions, m_period);
        }
    }
}