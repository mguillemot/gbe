using Gbe.Engine.Executor;

namespace Gbe.Script.Actions
{
    public class FireAtPlayerAction : Action
    {
        private readonly string _bullet;

        public FireAtPlayerAction(string target, string bullet) 
            : base(target)
        {
            _bullet = bullet;
        }

        public override ExecutorAction ToExecutorAction(CompiledGbs context)
        {
            // TODO mettre les vraies valeurs
            return new Engine.Executor.Actions.FireAtPlayerAction(100, 0);
        }
    }
}
