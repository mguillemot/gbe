namespace Gbe.Engine.Entities
{
    public class BasicAnimatedEntityState : EntityState
    {
        private string _animation;
        private int _animationFrame;
        private Point2 _position;

        public Point2 Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public string Animation
        {
            get { return _animation; }
            set { _animation = value; }
        }

        public int AnimationFrame
        {
            get { return _animationFrame; }
            set { _animationFrame = value; }
        }

        public override object Clone()
        {
            var clone = new BasicAnimatedEntityState();
            clone._position = _position;
            clone._animation = _animation;
            clone._animationFrame = _animationFrame;
            return clone;
        }
    }
}