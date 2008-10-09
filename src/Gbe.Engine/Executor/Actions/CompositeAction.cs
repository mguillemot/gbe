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

        public override void Execute(Entity entity, Engine engine)
        {
            foreach (var action in _actions)
            {
                action.Execute(entity, engine);
            }
        }
    }
}
