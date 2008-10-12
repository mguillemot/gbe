using System.Collections.Generic;
using Gbe.Script.Executor;

namespace Gbe.Script.Actions
{
    public class PeriodicAction : Action
    {
        private readonly List<Action> m_actions;

        public PeriodicAction(string target, List<Action> actions) 
            : base(target)
        {
            m_actions = actions;
        }

        public override void Execute(GbsExecutor scriptExecutor, Entity entity)
        {
        }
    }
}