using System.Collections.Generic;
using Gbe.Script.Actions;
using Gbe.Script.Executor;

namespace Gbe.Script.Triggers
{
    public class TimeTrigger : Trigger
    {
        private readonly float m_time;

        public TimeTrigger(float time, List<Action> actions)
            : base(actions)
        {
            m_time = time;
        }

        public float Time
        {
            get { return m_time; }
        }

        public override void Register(GbsExecutor scriptExecutor, Entity entity)
        {
            // TODO
        }
    }
}