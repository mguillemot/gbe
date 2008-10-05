using System.Collections.Generic;
using Gbe.Compiler.Actions;

namespace Gbe.Compiler.Triggers
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
    }
}
