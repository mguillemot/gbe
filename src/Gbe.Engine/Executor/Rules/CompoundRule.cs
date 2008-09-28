using System.Collections.Generic;

namespace Gbe.Engine.Executor.Rules
{
    public class CompoundRule : ExecutorRule
    {
        private readonly List<ExecutorRule> _rules;

        public CompoundRule(IEnumerable<ExecutorRule> rules)
        {
            _rules = new List<ExecutorRule>(rules);
        }

        public override int ComputeActions(Entity entity, GameContext context, List<ExecutorAction> actions)
        {
            var added = 0;
            foreach (var rule in _rules)
            {
                added += rule.ComputeActions(entity, context, actions);
            }
            return added;
        }
    }
}
