using Gbe.Engine;

namespace Gbe.Compiler.Actions
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

        public abstract void Execute(Engine.Engine engine, Entity engineEntity);
    }
}
