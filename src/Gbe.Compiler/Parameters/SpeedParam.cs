using Gbe.Engine;

namespace Gbe.Compiler.Parameters
{
    public class SpeedParam : Param
    {
        private readonly float _speed;

        public SpeedParam(float speed)
        {
            _speed = speed;
        }

        public float Speed
        {
            get { return _speed; }
        }

        public override void Set(Entity engineEntity)
        {
            engineEntity.Speed = _speed;
        }
    }
}
