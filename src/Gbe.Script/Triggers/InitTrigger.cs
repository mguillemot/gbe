using System.Collections.Generic;
using Gbe.Script.Actions;
using Gbe.Script.Executor;

namespace Gbe.Script.Triggers
{
    public class InitTrigger : Trigger
    {
        public InitTrigger(List<Action> actions) : base(actions)
        {
        }

        public override void Register(GbsExecutor scriptExecutor, Entity entity)
        {
            foreach (var action in Actions)
            {
                action.Execute(scriptExecutor, entity);
            }
        }
    }
}