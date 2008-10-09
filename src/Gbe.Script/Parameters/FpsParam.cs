using Gbe.Engine;
using Gbe.Engine.Executor;

namespace Gbe.Script.Parameters
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

        public override ExecutorAction ToExecutorAction()
        {
            return null;
        }
    }
}
