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
                _rulesCount -= ruleSet.CheckExpiration(context.CurrentFrame);
                var actions = new List<ExecutorAction>();
                foreach (ExecutorRule rule in ruleSet.ActiveRules)
                {
                    rule.ComputeActions(entity, context, actions);
                }
                return actions;
            }
            return null;
        }

        public void AddPermanentRule(Entity entity, ExecutorRule rule)
        {
            EntityRuleset ruleSet;
            if (!_rules.TryGetValue(entity.Id, out ruleSet))
            {
                ruleSet = new EntityRuleset();
                _rules.Add(entity.Id, ruleSet);
            }
            ruleSet.AddPermanentRule(rule);
            _rulesCount++;
        }

        public void RemovePermanentRule(Entity entity, ExecutorRule rule)
        {
            EntityRuleset ruleSet;
            if (_rules.TryGetValue(entity.Id, out ruleSet))
            {
                ruleSet.RemovePermanentRule(rule);
                if (ruleSet.Empty)
                {
                    _rules.Remove(entity.Id);
                }
                _rulesCount--;
            }
        }

        public void AddTemporaryRule(Entity entity, ExecutorRule rule, int expirationFrame)
        {
            EntityRuleset ruleSet;
            if (!_rules.TryGetValue(entity.Id, out ruleSet))
            {
                ruleSet = new EntityRuleset();
                _rules.Add(entity.Id, ruleSet);
            }
            ruleSet.AddTemporaryRule(rule, expirationFrame);
            _rulesCount++;
        }

        public void RemoveAllRulesFor(Entity entity)
        {
            EntityRuleset ruleSet;
            if (_rules.TryGetValue(entity.Id, out ruleSet))
            {
                _rulesCount -= ruleSet.ActiveRules.Count;
                _rules.Remove(entity.Id);
            }
        }

        public void RemoveAllRules()
        {
            _rules.Clear();
            _rulesCount = 0;
        }
    }
}