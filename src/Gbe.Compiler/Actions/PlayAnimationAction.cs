namespace Gbe.Compiler.Actions
{
    public class PlayAnimationAction : Action
    {
        private readonly string _animation;

        public PlayAnimationAction(string target, string animation) : base(target)
        {
            _animation = animation;
        }

        public string Animation
        {
            get { return _animation; }
        }
    }
}
