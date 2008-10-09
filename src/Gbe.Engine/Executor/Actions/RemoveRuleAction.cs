namespace Gbe.Engine.Executor.Actions
{
    public class RemoveRuleAction : ExecutorAction
    {
        private readonly ExecutorRule _rule;

        public RemoveRuleAction(ExecutorRule rule)
        {
            _rule = rule;
        }

        public ExecutorRule Rule
        {
            get { return _rule; }
        }

        public override void Execute(Entity entity, Engine engine)
        {
            engine.Executor.RemoveRule(entity.Id, _rule);
        }
    }
}