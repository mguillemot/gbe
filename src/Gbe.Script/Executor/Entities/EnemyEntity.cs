using System.Collections.Generic;
using Gbe.Engine;
using Gbe.Engine.GearLibrary;
using Gbe.Script.Classdefs;

namespace Gbe.Script.Executor.Entities
{
    public class EnemyEntity : Entity
    {
        private Gear m_gear;
        private readonly List<StateEntity> m_states = new List<StateEntity>();

        public EnemyEntity(Classdef classdef, string name) 
            : base(classdef, name)
        {
        }

        public void Register(GbsExecutor scriptExecutor)
        {
            scriptExecutor.Register(this);
            m_gear = new EnemyGear(scriptExecutor.Engine.GenerateId());
            scriptExecutor.Engine.AddGear(m_gear);
            foreach (var trigger in Classdef.Triggers)
            {
                trigger.Register(scriptExecutor, this);
            }
        }

        public override Gear Gear
        {
            get { return m_gear; }
        }

        public override void AddState(GbsExecutor scriptExecutor, StateEntity stateEntity)
        {
            m_states.Add(stateEntity);
            foreach (var trigger in stateEntity.Classdef.Triggers)
            {
                trigger.Register(scriptExecutor, stateEntity);
            }
        }

        public override void RemoveState(GbsExecutor scriptExecutor, StateEntity stateEntity)
        {
            m_states.Remove(stateEntity);
            foreach (var trigger in stateEntity.Classdef.Triggers)
            {
                trigger.Unregister(scriptExecutor, stateEntity);
            }
        }

        public override StateEntity GetState(StateClassdef stateClass)
        {
            return m_states.Find(state => state.Classdef == stateClass);
        }
    }
}
