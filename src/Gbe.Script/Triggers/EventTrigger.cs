using System.Collections.Generic;
using Gbe.Script.Actions;

namespace Gbe.Script.Triggers
{
    public class EventTrigger : Trigger
    {
        private readonly string _eventName;

        public EventTrigger(string eventName, List<Action> actions) : base(actions)
        {
            _eventName = eventName;
        }

        public override void Register(Engine.Engine engine, CompiledGbs context, EntityInstance entityInstance)
        {
        }
    }
}