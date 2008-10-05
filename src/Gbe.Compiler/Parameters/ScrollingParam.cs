using Gbe.Engine;

namespace Gbe.Compiler.Parameters
{
    public class ScrollingParam : Param
    {
        private readonly Direction _direction;
        private readonly float _speed;

        public ScrollingParam(string directionRepr, float speed)
        {
            _direction = Direction.Parse(directionRepr);
            _speed = speed;
        }

        public Direction Direction
        {
            get { return _direction; }
        }

        public float Speed
        {
            get { return _speed; }
        }

        public override void Set(Entity engineEntity)
        {
            throw new System.NotImplementedException();
        }
    }
}
