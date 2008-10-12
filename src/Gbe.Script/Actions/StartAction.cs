using Gbe.Script.Executor;

namespace Gbe.Script.Actions
{
    public class StartAction : Action
    {
        private readonly string _stateClass;

        public StartAction(string target, string state) 
            : base(target)
        {
            _stateClass = state;
        }

        public string State
        {
            get { return _stateClass; }
        }

        public override void Execute(GbsExecutor scriptExecutor, Entity entity)
        {
        }
    }
}