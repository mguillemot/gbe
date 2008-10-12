using Gbe.Script.Executor;
using Gbe.Script.Executor.Entities;

namespace Gbe.Script.Actions
{
    public class StartAction : Action
    {
        private readonly string m_stateClass;

        public StartAction(string target, string state) 
            : base(target)
        {
            m_stateClass = state;
        }

        public override void Execute(GbsExecutor scriptExecutor, Entity entity)
        {
            var stateClassdef = scriptExecutor.Script.GetStateClassdef(m_stateClass);
            var stateEntity = stateClassdef.NewInstance(entity);
            entity.AddState(scriptExecutor, stateEntity);
        }
    }
}