using System.Collections.Generic;
using Gbe.Script.Actions;
using Gbe.Script.Executor;
using Gbe.Script.Executor.Entities;

namespace Gbe.Script.Triggers
{
    public class TimeTrigger : Trigger
    {
        private readonly float m_time;

        public TimeTrigger(float time, List<Action> actions)
            : base(actions)
        {
            m_time = time;
        }

        public override void Register(GbsExecutor scriptExecutor, Entity entity)
        {
            scriptExecutor.RegisterTimeTrigger(scriptExecutor.Engine.Context.TotalElapsedSeconds + m_time, entity, Actions, -1);
        }

        public override void Unregister(GbsExecutor executor, Entity entity)
        {
        }
    }
}