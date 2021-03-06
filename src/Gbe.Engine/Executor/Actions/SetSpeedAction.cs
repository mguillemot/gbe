namespace Gbe.Engine.Executor.Actions
{
    public class SetSpeedAction : ExecutorAction
    {
        private readonly float _speed;

        public SetSpeedAction(float speed)
        {
            _speed = speed;
        }

        public override void Execute(Gear gear, Gbe gbe)
        {
            gear.Speed = _speed;
        }
    }
}