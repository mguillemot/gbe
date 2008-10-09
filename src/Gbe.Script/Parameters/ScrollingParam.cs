using Gbe.Engine;
using Gbe.Engine.Executor;

namespace Gbe.Script.Parameters
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

        public override ExecutorAction ToExecutorAction()
        {
            return null;
        }
    }
}