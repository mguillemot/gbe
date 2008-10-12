namespace Gbe.Engine.Executor.Actions
{
    public class DieAction : ExecutorAction
    {
        public override void Execute(Gear gear, Gbe gbe)
        {
            gbe.RemoveGear(gear);
        }
    }
}