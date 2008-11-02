using System.Collections.Generic;
using System.Diagnostics;
using Gbe.Script.Executor;
using Gbe.Script.Executor.Entities;
using Gbe.Script.Formulas;

namespace Gbe.Script.Actions
{
    public class FireMultipleAction : Action
    {
        private readonly string m_bulletClass;
        private readonly Formula m_baseDir;
        private readonly Range m_range;
        private readonly Formula m_increment;

        public FireMultipleAction(string target, string bulletClass, Formula baseDir, Range range, Formula increment)
            : base(target)
        {
            Debug.Assert(bulletClass != null, "FireMultipleAction: bulletClass is null");
            Debug.Assert(baseDir != null, "FireMultipleAction: baseDir is null");
            Debug.Assert(range != null, "FireMultipleAction: range is null");
            Debug.Assert(increment != null, "FireMultipleAction: increment is null");
            m_bulletClass = bulletClass;
            m_baseDir = baseDir;
            m_range = range;
            m_increment = increment;
        }

        public override void Execute(GbsExecutor scriptExecutor, Entity entity)
        {
            var evaluationContext = new EvaluationContext
                                        {
                                            EvaluationEntity = entity,
                                            PlayerPosition = scriptExecutor.Engine.GetPlayer().Position
                                        };
            var baseAngle = m_baseDir.Evaluate(evaluationContext);
            var increment = m_increment.Evaluate(evaluationContext);
            foreach (float rangeValue in m_range.EnumerateRange())
            {
                var bulletEntity = scriptExecutor.Script.GetBulletClassdef(m_bulletClass).NewInstance();
                bulletEntity.Spawn(scriptExecutor, entity.Gear.Position, baseAngle + rangeValue * increment);
                foreach (var trigger in bulletEntity.Classdef.Triggers)
                {
                    trigger.Register(scriptExecutor, bulletEntity);
                }
            }
        }

        public override List<Action> Compile()
        {
            return new List<Action>(1)
                       {
                           new FireMultipleAction(Target, m_bulletClass, m_baseDir.Compile(), m_range, m_increment.Compile())
                       };
        }
    }
}