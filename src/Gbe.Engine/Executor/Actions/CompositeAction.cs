using System.Collections.Generic;

namespace Gbe.Engine.Executor.Actions
{
    public class CompositeAction : ExecutorAction
    {
        private readonly List<ExecutorAction> _actions;

        public CompositeAction(List<ExecutorAction> actions)
        {
            _actions = actions;
        }

        public override void Execute(Gear gear, Gbe gbe)
        {
            foreach (var action in _actions)
            {
                action.Execute(gear, gbe);
            }
        }
    }
}
