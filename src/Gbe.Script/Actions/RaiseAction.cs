using Gbe.Script.Executor;
using Gbe.Script.Executor.Entities;

namespace Gbe.Script.Actions
{
    public class RaiseAction : Action
    {
        private readonly string m_eventClass;

        public RaiseAction(string target, string eventClass) 
            : base(target)
        {
            m_eventClass = eventClass;
        }

        public override void Execute(GbsExecutor scriptExecutor, Entity entity)
        {
        }
    }
}
