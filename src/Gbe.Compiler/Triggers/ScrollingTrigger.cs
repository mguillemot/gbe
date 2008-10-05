using System.Collections.Generic;
using Gbe.Compiler.Actions;

namespace Gbe.Compiler.Triggers
{
    public class ScrollingTrigger : Trigger
    {
        private readonly float _scrolling;

        public ScrollingTrigger(float scrolling, List<Action> actions)
            : base(actions)
        {
            _scrolling = scrolling;
        }

        public float Scrolling
        {
            get { return _scrolling; }
        }
    }
}
