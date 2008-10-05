using System.Collections.Generic;

namespace Gbe.Compiler.Actions
{
    public class PeriodicAction : Action
    {
        private readonly List<Action> _actions;

        public PeriodicAction(string target, List<Action> actions) : base(target)
        {
            _actions = actions;
        }

        public List<Action> Actions
        {
            get { return _actions; }
        }
    }
}
