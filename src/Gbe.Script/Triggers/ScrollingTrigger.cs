using System.Collections.Generic;
using Gbe.Script.Actions;

namespace Gbe.Script.Triggers
{
    public class ScrollingTrigger : Trigger
    {
        private readonly float _scrolling;

        public ScrollingTrigger(float scrolling, List<Action> actions)
            : base(actions)
        {
            _scrolling = scrolling;
        }

        public override void Register(Engine.Engine engine, CompiledGbs context, EntityInstance entityInstance)
        {
        }
    }
}