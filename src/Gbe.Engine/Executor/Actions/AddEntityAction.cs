namespace Gbe.Engine.Executor.Actions
{
    public class AddEntityAction : ExecutorAction
    {
        private readonly int _id;

        public AddEntityAction(int id)
        {
            _id = id;
        }

        public override void Execute(Entity entity, Engine engine)
        {
            engine.AddEntity(new Entity(_id));
        }
    }
}
