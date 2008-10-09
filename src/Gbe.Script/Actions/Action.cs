using Gbe.Engine.Executor;

namespace Gbe.Script.Actions
{
    public abstract class Action
    {
        private readonly string _target;

        protected Action(string target)
        {
            _target = target;
        }

        public string Target
        {
            get { return _target; }
        }

        public abstract ExecutorAction ToExecutorAction(CompiledGbs context);
    }
}
