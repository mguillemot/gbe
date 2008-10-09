using System.Collections.Generic;
using Gbe.Engine.Executor.Rules;
using Gbe.Script.Actions;

namespace Gbe.Script.Triggers
{
    public class TimeTrigger : Trigger
    {
        private readonly float _time;

        public TimeTrigger(float time, List<Action> actions)
            : base(actions)
        {
            _time = time;
        }

        public float Time
        {
            get { return _time; }
        }

        public override void Register(Engine.Engine engine, CompiledGbs context, EntityInstance entityInstance)
        {
            foreach (var action in Actions)
            {
                var executorAction = action.ToExecutorAction(null);
                if (executorAction != null)
                {
                    engine.Executor.AddRule(entityInstance.EngineId,
                                            new ExecuteAtTimeRule(engine.Context.TotalElapsedSeconds + _time,
                                                                  new ExecuteActionOnceRule(executorAction)));
                }
            }
        }
    }
}