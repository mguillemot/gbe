namespace Gbe.Engine.Executor.Actions
{
    public class DieAction : ExecutorAction
    {
        public override void Execute(Entity entity, Engine engine)
        {
            engine.RemoveEntity(entity);
        }
    }
}