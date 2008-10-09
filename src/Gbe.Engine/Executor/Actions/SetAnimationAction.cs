namespace Gbe.Engine.Executor.Actions
{
    public class SetAnimationAction : ExecutorAction
    {
        private readonly string _animation;

        public SetAnimationAction(string animation)
        {
            _animation = animation;
        }

        public override void Execute(Entity entity, Engine engine)
        {
            entity.Animation = _animation;
        }
    }
}