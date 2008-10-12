using System.Collections.Generic;

namespace Gbe.Engine.Executor
{
    public class Executor
    {
        private readonly Dictionary<int, Ruleset> _rules = new Dictionary<int, Ruleset>();
        private int _rulesCount;

        public int RulesCount
        {
            get { return _rulesCount; }
        }

        public List<ExecutorAction> ComputeActions(Gear gear, GbeContext context)
        {
            Ruleset ruleSet;
            if (_rules.TryGetValue(gear.Id, out ruleSet))
            {
                var actions = new List<ExecutorAction>();
                foreach (var rule in ruleSet.ActiveRules)
                {
                    rule.ComputeActions(gear, context, actions);
                }
                return actions;
            }
            return null;
        }

        public void AddRule(int entityId, ExecutorRule rule)
        {
            Ruleset ruleSet;
            if (!_rules.TryGetValue(entityId, out ruleSet))
            {
                ruleSet = new Ruleset();
                _rules.Add(entityId, ruleSet);
            }
            ruleSet.AddRule(rule);
            _rulesCount++;
        }

        public void RemoveRule(int entityId, ExecutorRule rule)
        {
            Ruleset ruleSet;
            if (_rules.TryGetValue(entityId, out ruleSet))
            {
                ruleSet.RemoveRule(rule);
                if (ruleSet.Empty)
                {
                    _rules.Remove(entityId);
                }
                _rulesCount--;
            }
        }

        public void RemoveAllRulesFor(int entityId)
        {
            Ruleset ruleSet;
            if (_rules.TryGetValue(entityId, out ruleSet))
            {
                _rulesCount -= ruleSet.ActiveRules.Count;
                _rules.Remove(entityId);
            }
        }

        public void RemoveAllRules()
        {
            _rules.Clear();
            _rulesCount = 0;
        }
    }
}