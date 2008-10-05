using System.Collections.Generic;
using Gbe.Compiler.Actions;

namespace Gbe.Compiler.Triggers
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
    }
}
