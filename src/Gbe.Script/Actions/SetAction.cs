using Gbe.Engine.Executor;
using Gbe.Script.Parameters;

namespace Gbe.Script.Actions
{
    public class SetAction : Action
    {
        private readonly Param _param;

        public SetAction(string target, Param param) : base(target)
        {
            _param = param;
        }

        public Param Param
        {
            get { return _param; }
        }

        public override ExecutorAction ToExecutorAction(CompiledGbs context)
        {
            return _param.ToExecutorAction();
        }
    }
}