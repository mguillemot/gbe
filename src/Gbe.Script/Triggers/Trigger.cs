using System.Collections.Generic;
using Gbe.Script.Actions;
using Gbe.Script.Executor;
using Gbe.Script.Executor.Entities;

namespace Gbe.Script.Triggers
{
    public abstract class Trigger
    {
        private readonly List<Action> _actions;

        protected Trigger(List<Action> actions)
        {
            _actions = actions;
        }

        public List<Action> Actions
        {
            get { return _actions; }
        }

        public abstract void Register(GbsExecutor scriptExecutor, Entity entity);

        public abstract void Unregister(GbsExecutor executor, Entity entity);

        public void Compile()
        {
            var compiledActions = new List<Action>();
            foreach (var action in _actions)
            {
                compiledActions.AddRange(action.Compile());
            }
            _actions.Clear();
            _actions.AddRange(compiledActions);
        }
    }
}