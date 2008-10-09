using Gbe.Engine.Executor;

namespace Gbe.Script.Actions
{
    public class DieAction : Action
    {
        public DieAction(string target) : base(target)
        {
        }

        public override ExecutorAction ToExecutorAction(CompiledGbs context)
        {
            return new Engine.Executor.Actions.DieAction();
        }
    }
}
