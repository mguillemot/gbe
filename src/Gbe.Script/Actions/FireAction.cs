using System.Collections.Generic;
using Gbe.Script.Executor;
using Gbe.Script.Executor.Entities;
using Gbe.Script.Formulas;

namespace Gbe.Script.Actions
{
    public class FireAction : Action
    {
        private readonly string m_bulletClass;
        private readonly Formula m_angle;

        public FireAction(string target, string bulletClass, Formula angle)
            : base(target)
        {
            m_bulletClass = bulletClass;
            m_angle = angle;
        }

        public override void Execute(GbsExecutor scriptExecutor, Entity entity)
        {
            var bulletEntity = scriptExecutor.Script.GetBulletClassdef(m_bulletClass).NewInstance();
            var evaluationContext = new EvaluationContext()
                                        {
                                            EvaluationEntity = entity,
                                            PlayerPosition = scriptExecutor.Engine.GetPlayer().Position
                                        };
            var angle = m_angle.Evaluate(evaluationContext);
            bulletEntity.Spawn(scriptExecutor, entity.Gear.Position, angle);
            foreach (var trigger in bulletEntity.Classdef.Triggers)
            {
                trigger.Register(scriptExecutor, bulletEntity);
            }
        }

        public override List<Action> Compile()
        {
            var angles = m_angle.Compile();
            var compiled = new List<Action>(angles.Count);
            foreach (var angle in angles)
            {
                compiled.Add(new FireAction(Target, m_bulletClass, angle));
            }
            return compiled;
        }
    }
}