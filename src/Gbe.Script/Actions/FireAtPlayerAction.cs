using Gbe.Script.Executor;

namespace Gbe.Script.Actions
{
    public class FireAtPlayerAction : Action
    {
        private readonly string m_bulletClass;

        public FireAtPlayerAction(string target, string bulletClass)
            : base(target)
        {
            m_bulletClass = bulletClass;
        }

        public override void Execute(GbsExecutor scriptExecutor, Entity entity)
        {
        }
    }
}