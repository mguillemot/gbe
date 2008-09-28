using System.Collections.Generic;

namespace Gbe.Engine.Executor
{
    public class EntityRuleset
    {
        private readonly List<ExecutorRule> _activeRules = new List<ExecutorRule>();
        private readonly Dictionary<int, List<ExecutorRule>> _expirations = new Dictionary<int, List<ExecutorRule>>();

        public List<ExecutorRule> ActiveRules
        {
            get { return _activeRules; }
        }

        public bool Empty
        {
            get { return _activeRules.Count == 0; }
        }

        public void AddPermanentRule(ExecutorRule rule)
        {
            _activeRules.Add(rule);
        }

        public void RemovePermanentRule(ExecutorRule rule)
        {
            _activeRules.Remove(rule);
        }

        public void AddTemporaryRule(ExecutorRule rule, int expirationFrame)
        {
            _activeRules.Add(rule);
            List<ExecutorRule> list;
            if (!_expirations.TryGetValue(expirationFrame, out list))
            {
                list = new List<ExecutorRule>(1);
                _expirations.Add(expirationFrame, list);
            }
            list.Add(rule);
        }

        public int CheckExpiration(int currentFrame)
        {
            List<ExecutorRule> list;
            if (_expirations.TryGetValue(currentFrame, out list))
            {
                int nRules = list.Count;
                foreach (ExecutorRule rule in list)
                {
                    _activeRules.Remove(rule);
                }
                _expirations.Remove(currentFrame);
                return nRules;
            }
            return 0;
        }
    }
}