namespace Gbe.Engine.Executor.Actions
{
    public class SetColorAction : ExecutorAction
    {
        private readonly Color _color;

        public SetColorAction(Color color)
        {
            _color = color;
        }

        public override void Execute(Gear gear, Gbe gbe)
        {
            gear.Color = _color;
        }
    }
}