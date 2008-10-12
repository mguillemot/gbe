using Gbe.Script.Executor;
using Gbe.Script.Parameters;

namespace Gbe.Script.Actions
{
    public class SetAction : Action
    {
        private readonly Param m_param;

        public SetAction(string target, Param param) 
            : base(target)
        {
            m_param = param;
        }

        public override void Execute(GbsExecutor scriptExecutor, Entity entity)
        {
            m_param.Execute(scriptExecutor.Engine.GetGear(entity.EngineId));
        }
    }
}