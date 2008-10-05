using System.Collections.Generic;
using Gbe.Compiler.Actions;

namespace Gbe.Compiler.Triggers
{
    public class AnimationEndTrigger : Trigger
    {
        private readonly string _animation;

        public AnimationEndTrigger(string animation, List<Action> actions)
            : base(actions)
        {
            _animation = animation;
        }

        public string Animation
        {
            get { return _animation; }
        }
    }
}
