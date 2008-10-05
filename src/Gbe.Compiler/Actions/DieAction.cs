using Gbe.Engine;

namespace Gbe.Compiler.Actions
{
    public class DieAction : Action
    {
        public DieAction(string target) : base(target)
        {
        }

        public override void Execute(Engine.Engine engine, Entity engineEntity)
        {
            // TODO passer par les Engine.Action ?
            //engine.RemoveEntity(engineEntity);
            //engine.Executor.AddPermanentRule(engineEntity, new Engine.Executor.Actions.DieAction());
        }
    }
}
