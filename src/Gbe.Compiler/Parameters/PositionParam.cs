using Gbe.Engine;

namespace Gbe.Compiler.Parameters
{
    public class PositionParam : Param
    {
        private readonly Point2 _position;

        public PositionParam(string positionRepr)
        {
            _position = Point2.Parse(positionRepr);
        }

        public Point2 Position
        {
            get { return _position; }
        }

        public override void Set(Entity engineEntity)
        {
            engineEntity.Position = _position;
        }
    }
}
