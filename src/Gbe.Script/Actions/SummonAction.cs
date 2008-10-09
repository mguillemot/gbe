using System.Collections.Generic;
using Gbe.Engine.Executor;
using Gbe.Engine.Executor.Actions;

namespace Gbe.Script.Actions
{
    public class SummonAction : Action
    {
        private readonly string _enemyClass;
        private readonly string _enemyName;
        private readonly List<Action> _summonActions;

        public SummonAction(string target, string enemyClass, string enemyName, List<Action> summonActions)
            : base(target)
        {
            _enemyClass = enemyClass;
            _enemyName = enemyName;
            _summonActions = summonActions;
        }

        public override ExecutorAction ToExecutorAction(CompiledGbs context)
        {
            var enemyInstance = context.GenerateInstance(_enemyClass, _enemyName);
            var actions = new List<ExecutorAction>(1 + (_summonActions != null ? _summonActions.Count : 0));
            actions.Add(new AddEntityAction(enemyInstance.EngineId));
            if (_summonActions != null)
            {
                foreach (var enemyInitAction in _summonActions)
                {
                    var executorAction = enemyInitAction.ToExecutorAction(context);
                    if (executorAction != null)
                    {
                        actions.Add(executorAction);
                    }
                }
            }
            return new CompositeAction(actions);
        }
    }
}