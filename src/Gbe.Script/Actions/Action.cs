using Gbe.Script.Executor;
using Gbe.Script.Executor.Entities;

namespace Gbe.Script.Actions
{
    public abstract class Action
    {
        private readonly string m_target;

        protected Action(string target)
        {
            m_target = target;
        }

        public string Target
        {
            get { return m_target; }
        }

        public abstract void Execute(GbsExecutor scriptExecutor, Entity entity);

    }
}