using System.Collections.Generic;
using Gbe.Engine.Executor;

namespace Gbe.Script.Actions
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

        public override ExecutorAction ToExecutorAction(CompiledGbs context)
        {
            // TODO
            return null;
        }
    }
}