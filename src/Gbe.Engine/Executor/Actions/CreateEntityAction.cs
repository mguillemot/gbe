namespace Gbe.Engine.Executor.Actions
{
    public class CreateEntityAction : ExecutorAction
    {
        public override void Execute(Gear gear, Gbe gbe)
        {
            var summonedEntity = new Gear(gbe.GenerateId());
            gbe.AddGear(summonedEntity);
        }
    }
}
