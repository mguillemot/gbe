namespace Gbe.Engine.Executor.Actions
{
    public class SetAnimationAction : ExecutorAction
    {
        private readonly string _animation;

        public SetAnimationAction(string animation)
        {
            _animation = animation;
        }

        public override void Execute(Gear gear, Gbe gbe)
        {
            gear.Animation = _animation;
        }
    }
}