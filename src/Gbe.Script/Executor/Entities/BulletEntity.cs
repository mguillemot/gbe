using System.Collections.Generic;
using Gbe.Engine;
using Gbe.Engine.Executor.Rules;
using Gbe.Engine.GearLibrary;
using Gbe.Script.Classdefs;

namespace Gbe.Script.Executor.Entities
{
    public class BulletEntity : Entity
    {
        private Gear m_gear;
        private readonly List<StateEntity> m_states = new List<StateEntity>();

        public BulletEntity(Classdef classdef, string name) 
            : base(classdef, name)
        {
        }

        public void Spawn(GbsExecutor scriptExecutor, Point2 initialPosition, float angle)
        {
            scriptExecutor.Register(this);
            m_gear = new BulletGear(scriptExecutor.Engine.GenerateId())
                         {
                             Position = initialPosition,
                             Direction = angle
                         };
            scriptExecutor.Engine.AddGear(m_gear);
            scriptExecutor.Engine.Executor.AddRule(m_gear.Id, new LinearTrajectoryRule(angle));
            scriptExecutor.Engine.Executor.AddRule(m_gear.Id, new DieWhenOutOfBoundsRule());
            foreach (var trigger in Classdef.Triggers)
            {
                trigger.Register(scriptExecutor, this);
            }
        }

        public override void Die(GbsExecutor scriptExecutor)
        {
            scriptExecutor.Engine.RemoveGear(m_gear);
            foreach (var trigger in Classdef.Triggers)
            {
                trigger.Unregister(scriptExecutor, this);
            }
        }

        public override Gear Gear
        {
            get { return m_gear; }
        }
    }
}
