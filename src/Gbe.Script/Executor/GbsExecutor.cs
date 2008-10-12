using System;
using System.Collections.Generic;
using Gbe.Script.Executor.Entities;
using Action=Gbe.Script.Actions.Action;

namespace Gbe.Script.Executor
{
    internal struct TimeTriggerInstance : IComparable<TimeTriggerInstance>
    {
        private readonly List<Action> m_actions;
        private readonly float m_autoRegisterTime;
        private readonly Entity m_entity;
        private readonly float m_time;

        public TimeTriggerInstance(float time, Entity entity, List<Action> actions, float autoRegisterTime)
        {
            m_time = time;
            m_entity = entity;
            m_actions = actions;
            m_autoRegisterTime = autoRegisterTime;
        }

        public TimeTriggerInstance(float time, Entity entity, List<Action> actions)
            : this(time, entity, actions, -1)
        {
        }

        public float Time
        {
            get { return m_time; }
        }

        public Entity Entity
        {
            get { return m_entity; }
        }

        public List<Action> Actions
        {
            get { return m_actions; }
        }

        public float AutoRegisterTime
        {
            get { return m_autoRegisterTime; }
        }

        #region IComparable<TimeTriggerInstance> Members

        public int CompareTo(TimeTriggerInstance other)
        {
            var deltaTime = Time - other.Time;
            if (deltaTime > 0)
            {
                return 1;
            }
            if (deltaTime < 0)
            {
                return -1;
            }
            return 0;
        }

        #endregion
    }

    public class GbsExecutor
    {
        private readonly Engine.Gbe m_engine;

        private readonly Dictionary<string, List<Entity>> m_entitiesByClass = new Dictionary<string, List<Entity>>();
        private readonly Dictionary<string, Entity> m_entitiesByName = new Dictionary<string, Entity>();
        private readonly CompiledGbs m_script;

        private readonly List<TimeTriggerInstance> m_timeTriggers = new List<TimeTriggerInstance>();

        public GbsExecutor(Engine.Gbe engine, CompiledGbs script)
        {
            m_engine = engine;
            m_script = script;
        }

        public Engine.Gbe Engine
        {
            get { return m_engine; }
        }

        public CompiledGbs Script
        {
            get { return m_script; }
        }

        public void Update()
        {
            var triggersToExecute = new List<TimeTriggerInstance>();
            foreach (var trigger in m_timeTriggers)
            {
                if (trigger.Time <= Engine.Context.TotalElapsedSeconds)
                {
                    triggersToExecute.Add(trigger);
                }
                else
                {
                    break;
                }
            }
            foreach (var trigger in triggersToExecute)
            {
                foreach (var action in trigger.Actions)
                {
                    action.Execute(this, trigger.Entity);
                }
                m_timeTriggers.Remove(trigger);
                if (trigger.AutoRegisterTime > 0)
                {
                    RegisterTimeTrigger(trigger.Time + trigger.AutoRegisterTime, trigger.Entity, trigger.Actions,
                                        trigger.AutoRegisterTime);
                }
            }
        }

        public void RegisterTimeTrigger(float time, Entity entity, List<Action> trigger, float autoRegisterTime)
        {
            m_timeTriggers.Add(new TimeTriggerInstance(time, entity, trigger, autoRegisterTime));
            m_timeTriggers.Sort();
        }

        public void UnregisterTimeTrigger(StateEntity entity, List<Action> actions, float autoRegisterTime)
        {
            var index = m_timeTriggers.FindIndex(
                trigger => trigger.Actions == actions && trigger.AutoRegisterTime == autoRegisterTime && trigger.Entity == entity);
            if (index != -1)
            {
                m_timeTriggers.RemoveAt(index);
            }
        }

        public void Register(Entity entity)
        {
            m_entitiesByName[entity.Name] = entity;
            List<Entity> entitiesOfThisClass;
            if (!m_entitiesByClass.TryGetValue(entity.Classdef.ClassName, out entitiesOfThisClass))
            {
                entitiesOfThisClass = new List<Entity>();
                m_entitiesByClass[entity.Classdef.ClassName] = entitiesOfThisClass;
            }
            entitiesOfThisClass.Add(entity);
        }
    }
}