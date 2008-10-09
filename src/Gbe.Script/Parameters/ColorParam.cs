using Gbe.Engine;
using Gbe.Engine.Executor;
using Gbe.Engine.Executor.Actions;

namespace Gbe.Script.Parameters
{
    public class ColorParam : Param
    {
        private readonly Color _color;

        public ColorParam(string colorRepr)
        {
            _color = Color.Parse(colorRepr);
        }

        public override ExecutorAction ToExecutorAction()
        {
            return new SetColorAction(_color);
        }
    }
}
