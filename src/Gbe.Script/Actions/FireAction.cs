using System.Collections.Generic;
using Gbe.Script.Executor;
using Gbe.Script.Executor.Entities;
using Gbe.Script.Formulas;

namespace Gbe.Script.Actions
{
    public class FireAction : Action
    {
        private readonly Formula m_angle;
        private readonly string m_bulletClass;

        public static FireAction Create(string target, string bulletClass, Formula angle)
        {
            if (target == null)
            {
                throw new SyntaxException("FireAction", "target=null");
            }
            if (bulletClass == null)
            {
                throw new SyntaxException("FireAction", "bulletClass=null");
            }
            if (angle == null)
            {
                throw new SyntaxException("FireAction", "angle=null");
            }
            return new FireAction(target, bulletClass, angle);
        }

        private FireAction(string target, string bulletClass, Formula angle)
            : base(target)
        {
            m_bulletClass = bulletClass;
            m_angle = angle;
        }

        public override void Execute(GbsExecutor scriptExecutor, Entity entity)
        {
            var bulletEntity = scriptExecutor.Script.GetBulletClassdef(m_bulletClass).NewInstance();
            var evaluationContext = new EvaluationContext
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
            return new List<Action>(1)
                       {
                           new FireAction(Target, m_bulletClass, m_angle.Compile())
                       };
        }
    }
}