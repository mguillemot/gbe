using System.Collections.Generic;

namespace Gbe.Engine.Executor
{
    public abstract class ExecutorRule
    {
        public abstract int ComputeActions(Entity entity, GameContext context, List<ExecutorAction> actions);
    }
}