using System.Collections.Generic;
using Gbe.Script.Actions;
using Gbe.Script.Executor;

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

        public abstract void Register(Engine.Engine engine, CompiledGbs context, EntityInstance entityInstance);
    }
}