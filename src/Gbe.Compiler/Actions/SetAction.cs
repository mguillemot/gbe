using Gbe.Compiler.Parameters;

namespace Gbe.Compiler.Actions
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
    }
}
