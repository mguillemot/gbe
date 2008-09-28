namespace Gbe.Engine.Executor
{
    public abstract class ExecutorAction
    {
        public abstract void Execute(Entity entity, Engine engine);
    }
}