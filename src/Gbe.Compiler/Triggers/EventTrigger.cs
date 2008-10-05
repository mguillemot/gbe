using System.Collections.Generic;
using Gbe.Compiler.Actions;

namespace Gbe.Compiler.Triggers
{
    public class EventTrigger : Trigger
    {
        private readonly string _eventName;

        public EventTrigger(string eventName, List<Action> actions) : base(actions)
        {
            _eventName = eventName;
        }

        public string EventName
        {
            get { return _eventName; }
        }
    }
}
