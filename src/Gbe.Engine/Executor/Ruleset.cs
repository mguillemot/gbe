using System.Collections.Generic;

namespace Gbe.Engine.Executor
{
    public class Ruleset
    {
        private readonly List<ExecutorRule> m_activeRules = new List<ExecutorRule>();

        public List<ExecutorRule> ActiveRules
        {
            get { return m_activeRules; }
        }

        public bool Empty
        {
            get { return m_activeRules.Count == 0; }
        }

        public void AddRule(ExecutorRule rule)
        {
            m_activeRules.Add(rule);
        }

        public void RemoveRule(ExecutorRule rule)
        {
            m_activeRules.Remove(rule);
        }
    }
}