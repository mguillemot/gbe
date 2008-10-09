using System.Collections.Generic;
using Gbe.Script.Actions;

namespace Gbe.Script.Triggers
{
    public class AnimationEndTrigger : Trigger
    {
        private readonly string _animation;

        public AnimationEndTrigger(string animation, List<Action> actions)
            : base(actions)
        {
            _animation = animation;
        }

        public override void Register(Engine.Engine engine, CompiledGbs context, EntityInstance entityInstance)
        {
        }
    }
}