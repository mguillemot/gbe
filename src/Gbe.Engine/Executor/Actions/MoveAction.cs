namespace Gbe.Engine.Executor.Actions
{
    public class MoveAction : ExecutorAction
    {
        private readonly float _dx;
        private readonly float _dy;

        public MoveAction(float _dx, float _dy)
        {
            this._dx = _dx;
            this._dy = _dy;
        }

        public float Dx
        {
            get { return _dx; }
        }

        public float Dy
        {
            get { return _dy; }
        }

        public override void Execute(Entity entity, Engine engine)
        {
            Point2 currentPosition = entity.Position;
            entity.Position = new Point2(currentPosition.X + _dx, currentPosition.Y + _dy);
        }
    }
}