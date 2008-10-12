using System.Collections.Generic;

namespace Gbe.Engine.Executor
{
    public abstract class ExecutorRule
    {
        public abstract int ComputeActions(Gear gear, GbeContext context, List<ExecutorAction> actions);
    }
}