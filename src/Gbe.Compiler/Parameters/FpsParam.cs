using Gbe.Engine;

namespace Gbe.Compiler.Parameters
{
    public class FpsParam : Param
    {
        private readonly float _fps;

        public FpsParam(float fps)
        {
            _fps = fps;
        }

        public float Fps
        {
            get { return _fps; }
        }

        public override void Set(Entity engineEntity)
        {
            throw new System.NotImplementedException();
        }
    }
}
