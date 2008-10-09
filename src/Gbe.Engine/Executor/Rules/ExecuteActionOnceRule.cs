using System.Collections.Generic;
using Gbe.Engine.Executor.Actions;

namespace Gbe.Engine.Executor.Rules
{
    public class ExecuteActionOnceRule : ExecutorRule
    {
        private readonly ExecutorAction _action;

        public ExecuteActionOnceRule(ExecutorAction action)
        {
            _action = action;
        }

        public override int ComputeActions(Entity entity, GameContext context, List<ExecutorAction> actions)
        {
            actions.Add(_action);
            actions.Add(new RemoveRuleAction(this));
            return 2;
        }
    }
}