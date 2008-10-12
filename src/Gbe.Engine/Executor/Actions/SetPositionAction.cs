namespace Gbe.Engine.Executor.Actions
{
    public class SetPositionAction : ExecutorAction
    {
        private readonly Point2 _position;

        public SetPositionAction(Point2 position)
        {
            _position = position;
        }

        public override void Execute(Gear gear, Gbe gbe)
        {
            gear.Position = _position;
        }
    }
}