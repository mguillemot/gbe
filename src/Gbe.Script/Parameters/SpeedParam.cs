using Gbe.Engine;
using Gbe.Engine.Executor;
using Gbe.Engine.Executor.Actions;

namespace Gbe.Script.Parameters
{
    public class SpeedParam : Param
    {
        private readonly float _speed;

        public SpeedParam(float speed)
        {
            _speed = speed;
        }

        public override ExecutorAction ToExecutorAction()
        {
            return new SetSpeedAction(_speed);
        }
    }
}
