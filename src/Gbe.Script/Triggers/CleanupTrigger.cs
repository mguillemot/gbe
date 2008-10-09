using System.Collections.Generic;
using Gbe.Script.Actions;
using Gbe.Script.Executor;

namespace Gbe.Script.Triggers
{
    public class CleanupTrigger : Trigger
    {
        public CleanupTrigger(List<Action> actions) : base(actions)
        {
        }

        public override void Register(Engine.Engine engine, CompiledGbs context, EntityInstance entityInstance)
        {
        }
    }
}