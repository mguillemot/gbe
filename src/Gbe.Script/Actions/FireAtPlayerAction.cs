using Gbe.Engine;
using Gbe.Engine.Executor.Rules;
using Gbe.Engine.GearLibrary;
using Gbe.Script.Executor;
using Gbe.Script.Executor.Entities;

namespace Gbe.Script.Actions
{
    public class FireAtPlayerAction : Action
    {
        private readonly string m_bulletClass;

        public FireAtPlayerAction(string target, string bulletClass)
            : base(target)
        {
            m_bulletClass = bulletClass;
        }

        public override void Execute(GbsExecutor scriptExecutor, Entity entity)
        {
            var bulletEntity = scriptExecutor.Script.GetBulletClassdef(m_bulletClass).NewInstance();
            bulletEntity.Register(scriptExecutor, entity.Gear.Position);
            foreach (var trigger in bulletEntity.Classdef.Triggers)
            {
                trigger.Register(scriptExecutor, bulletEntity);
            }
        }
    }
}