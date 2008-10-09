using System.Collections.Generic;
using Gbe.Script.Actions;
using Gbe.Engine.Executor.Rules;
using Gbe.Script.Actions;

namespace Gbe.Script.Triggers
{
    public class InitTrigger : Trigger
    {
        public InitTrigger(List<Action> actions) : base(actions)
        {
        }

        public override void Register(Engine.Engine engine, CompiledGbs context, EntityInstance entityInstance)
        {
            foreach (var action in Actions)
            {
                var executorAction = action.ToExecutorAction(context);
                if (executorAction != null)
                {
                    engine.Executor.AddRule(entityInstance.EngineId,
                                            new ExecuteActionOnceRule(executorAction));
                }
            }
 
        }
    }
}
