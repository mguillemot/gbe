using Gbe.Engine;
using Gbe.Engine.Executor;
using Gbe.Engine.Executor.Actions;

namespace Gbe.Script.Parameters
{
    public class PositionParam : Param
    {
        private readonly Point2 _position;

        public PositionParam(string positionRepr)
        {
            _position = Point2.Parse(positionRepr);
        }

        public override ExecutorAction ToExecutorAction()
        {
            return new SetPositionAction(_position);
        }
    }
}