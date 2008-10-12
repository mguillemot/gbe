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

        public abstract void Unregister(GbsExecutor executor, StateEntity entity);
    }
}