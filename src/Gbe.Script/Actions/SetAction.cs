using Gbe.Script.Parameters;
using Gbe.Engine.Executor;
using Gbe.Script.Parameters;

namespace Gbe.Script.Actions
{
    public class SetAction : Action
    {
        private readonly Parameters.Param _param;

        public SetAction(string target, Parameters.Param param) : base(target)
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
