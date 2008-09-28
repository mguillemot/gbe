using System.Collections.Generic;
using Gbe.Engine.Executor.Actions;

namespace Gbe.Engine.Executor.Rules
{
    public class PeriodicRule : ExecutorRule
    {
        private readonly ExecutorRule _subRule;
        private readonly float _timeInterval;
        private readonly int _totalNumberOfActivations;
        private float _lastActivation;
        private int _remainingNumberOfActivations;

        public PeriodicRule(ExecutorRule subRule, float timeInterval, int numberOfActivations)
        {
            _subRule = subRule;
            _timeInterval = timeInterval;
            _totalNumberOfActivations = numberOfActivations;
            _remainingNumberOfActivations = _totalNumberOfActivations;
        }

        public PeriodicRule(ExecutorRule subRule, float timeInterval)
        {
            _subRule = subRule;
            _timeInterval = timeInterval;
            _totalNumberOfActivations = int.MaxValue;
            _remainingNumberOfActivations = _totalNumberOfActivations;
        }

        public ExecutorRule SubRule
        {
            get { return _subRule; }
        }

        public float TimeInterval
        {
            get { return _timeInterval; }
        }

        public int TotalNumberOfActivations
        {
            get { return _totalNumberOfActivations; }
        }

        public float LastActivation
        {
            get { return _lastActivation; }
        }

        public int RemainingNumberOfActivations
        {
            get { return _remainingNumberOfActivations; }
        }

        public override int ComputeActions(Entity entity, GameContext context, List<ExecutorAction> actions)
        {
            if (context.TotalElapsedSeconds >= _lastActivation + _timeInterval)
            {
                int added = _subRule.ComputeActions(entity, context, actions);
                _lastActivation = context.TotalElapsedSeconds;
                _remainingNumberOfActivations--;
                if (_remainingNumberOfActivations == 0)
                {
                    actions.Add(new RemoveRuleAction(_subRule));
                    added++;
                }
                return added;
            }
            return 0;
        }
    }
}