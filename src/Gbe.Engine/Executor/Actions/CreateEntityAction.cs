namespace Gbe.Engine.Executor.Actions
{
    public class CreateEntityAction : ExecutorAction
    {
        public override void Execute(Entity entity, Engine engine)
        {
            var summonedEntity = new Entity(engine.GenerateId());
            engine.AddEntity(summonedEntity);
        }
    }
}
