using System.Collections.Generic;
using Gbe.Engine.Executor.Actions;

namespace Gbe.Engine.Executor.Rules
{
    public class ExecuteAtTimeRule : ExecutorRule
    {
        private readonly float _executionTime;
        private readonly ExecutorRule _rule;

        public ExecuteAtTimeRule(float executionTime, ExecutorRule rule)
        {
            _executionTime = executionTime;
            _rule = rule;
        }

        public override int ComputeActions(Gear gear, GbeContext context, List<ExecutorAction> actions)
        {
            if (context.TotalElapsedSeconds > _executionTime)
            {
                int added = _rule.ComputeActions(gear, context, actions);
                actions.Add(new RemoveRuleAction(this));
                return added + 1;
            }
            return 0;
        }
    }
}