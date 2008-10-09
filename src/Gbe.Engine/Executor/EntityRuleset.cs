using System.Collections.Generic;

namespace Gbe.Engine.Executor
{
    public class EntityRuleset
    {
        private readonly List<ExecutorRule> _activeRules = new List<ExecutorRule>();

        public List<ExecutorRule> ActiveRules
        {
            get { return _activeRules; }
        }

        public bool Empty
        {
            get { return _activeRules.Count == 0; }
        }

        public void AddRule(ExecutorRule rule)
        {
            _activeRules.Add(rule);
        }

        public void RemoveRule(ExecutorRule rule)
        {
            _activeRules.Remove(rule);
        }
    }
}