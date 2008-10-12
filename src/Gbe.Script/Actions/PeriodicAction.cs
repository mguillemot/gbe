using System.Collections.Generic;
using Gbe.Script.Executor;
using Gbe.Script.Executor.Entities;

namespace Gbe.Script.Actions
{
    public class PeriodicAction : Action
    {
        private readonly List<Action> m_actions;
        private readonly float m_period;

        public PeriodicAction(string target, List<Action> actions, float period) 
            : base(target)
        {
            m_actions = actions;
            m_period = period;
        }

        public override void Execute(GbsExecutor scriptExecutor, Entity entity)
        {
            scriptExecutor.RegisterTimeTrigger(scriptExecutor.Engine.Context.TotalElapsedSeconds, entity, m_actions, m_period);
        }
    }
}