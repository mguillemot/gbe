namespace Gbe.Engine.Executor.Actions
{
    public class AddRuleAction : ExecutorAction
    {
        private readonly ExecutorRule _rule;

        public AddRuleAction(ExecutorRule rule)
        {
            _rule = rule;
        }

        public override void Execute(Entity entity, Engine engine)
        {
            engine.Executor.AddRule(entity.Id, _rule);
        }
    }
}
