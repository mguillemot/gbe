using System.Collections.Generic;
using Gbe.Engine.Executor.Actions;

namespace Gbe.Engine.Executor.Rules
{
    public class ExecuteOnceRule : ExecutorRule
    {
        private readonly ExecutorRule _rule;

        public ExecuteOnceRule(ExecutorRule rule)
        {
            _rule = rule;
        }

        public override int ComputeActions(Gear gear, GbeContext context, List<ExecutorAction> actions)
        {
            int added = _rule.ComputeActions(gear, context, actions);
            actions.Add(new RemoveRuleAction(this));
            return added + 1;
        }
    }
}