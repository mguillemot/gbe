using Gbe.Engine.Executor;

namespace Gbe.Script.Actions
{
    public class StopAction : Action
    {
        private readonly string _state;

        public StopAction(string target, string state) : base(target)
        {
            _state = state;
        }

        public string State
        {
            get { return _state; }
        }

        public override ExecutorAction ToExecutorAction(CompiledGbs context)
        {
            // TODO
            return null;
        }
    }
}