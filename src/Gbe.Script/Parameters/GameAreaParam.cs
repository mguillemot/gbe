using Gbe.Engine;
using Gbe.Engine.Executor;

namespace Gbe.Script.Parameters
{
    public class GameAreaParam : Param
    {
        private readonly Rectangle _area;

        public GameAreaParam(string areaRepr)
        {
            _area = Rectangle.Parse(areaRepr);
        }

        public Rectangle Area
        {
            get { return _area; }
        }

        public override ExecutorAction ToExecutorAction()
        {
            return null;
        }
    }
}