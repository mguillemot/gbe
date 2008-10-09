using Gbe.Engine;
using Gbe.Engine.Executor;

namespace Gbe.Script.Parameters
{
    public abstract class Param
    {
        public abstract ExecutorAction ToExecutorAction();
    }
}
