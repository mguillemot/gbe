namespace Gbe.Engine.Executor.Actions
{
    public class AddRuleAction : ExecutorAction
    {
        private readonly ExecutorRule _rule;

        public AddRuleAction(ExecutorRule rule)
        {
            _rule = rule;
        }

        public override void Execute(Gear gear, Gbe gbe)
        {
            gbe.Executor.AddRule(gear.Id, _rule);
        }
    }
}
