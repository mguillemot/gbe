using System.Collections.Generic;
using Gbe.Script.Executor;
using Gbe.Script.Executor.Entities;
using Gbe.Script.Formulas;
using Gbe.Script.Parameters;

namespace Gbe.Script.Actions
{
    public class SetAction : Action
    {
        private readonly Param m_param;

        public SetAction(string target, Param param) 
            : base(target)
        {
            m_param = param;
        }

        public override void Execute(GbsExecutor scriptExecutor, Entity entity)
        {
            if (entity.Gear != null)
            {
                var context = new EvaluationContext
                    {
                        EvaluationEntity = entity,
                        PlayerPosition = scriptExecutor.Engine.GetPlayer().Position
                    };
                m_param.Execute(context);
            }
        }

        public override List<Action> Compile()
        {
            return new List<Action>(1) {new SetAction(Target, m_param.Compile())};
        }
    }
}