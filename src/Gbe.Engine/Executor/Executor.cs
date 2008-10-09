using System.Collections.Generic;

namespace Gbe.Engine.Executor
{
    public class Executor
    {
        private readonly Dictionary<int, EntityRuleset> _rules = new Dictionary<int, EntityRuleset>();
        private int _rulesCount;

        public int RulesCount
        {
            get { return _rulesCount; }
        }

        public List<ExecutorAction> ComputeActions(Entity entity, GameContext context)
        {
            EntityRuleset ruleSet;
            if (_rules.TryGetValue(entity.Id, out ruleSet))
            {
                var actions = new List<ExecutorAction>();
                foreach (var rule in ruleSet.ActiveRules)
                {
                    rule.ComputeActions(entity, context, actions);
                }
                return actions;
            }
            return null;
        }

        public void AddRule(int entityId, ExecutorRule rule)
        {
            EntityRuleset ruleSet;
            if (!_rules.TryGetValue(entityId, out ruleSet))
            {
                ruleSet = new EntityRuleset();
                _rules.Add(entityId, ruleSet);
            }
            ruleSet.AddRule(rule);
            _rulesCount++;
        }

        public void RemoveRule(int entityId, ExecutorRule rule)
        {
            EntityRuleset ruleSet;
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
            EntityRuleset ruleSet;
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