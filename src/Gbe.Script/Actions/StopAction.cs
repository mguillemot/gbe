using Gbe.Script.Executor;

namespace Gbe.Script.Actions
{
    public class StopAction : Action
    {
        private readonly string m_stateClass;

        public StopAction(string target, string state) 
            : base(target)
        {
            m_stateClass = state;
        }

        public override void Execute(GbsExecutor scriptExecutor, Entity entity)
        {
        }
    }
}