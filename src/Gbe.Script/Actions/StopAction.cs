using Gbe.Script.Executor;
using Gbe.Script.Executor.Entities;

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
            var state = entity.GetState(scriptExecutor.Script.GetStateClassdef(m_stateClass));
            if (state != null)
            {
                entity.RemoveState(scriptExecutor, state);
            }
        }
    }
}