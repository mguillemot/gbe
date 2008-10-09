using Gbe.Engine.Executor;

namespace Gbe.Script.Actions
{
    public class StartAction : Action
    {
        private readonly string _state;

        public StartAction(string target, string state) : base(target)
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