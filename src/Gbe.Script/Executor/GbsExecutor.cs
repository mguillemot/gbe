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

    internal struct EventTriggerInstance
    {
        private readonly string m_eventClass;
        private readonly List<Action> m_actions;
        private readonly Entity m_entity;

        public EventTriggerInstance(string eventClass, List<Action> actions, Entity entity)
        {
            m_eventClass = eventClass;
            m_actions = actions;
            m_entity = entity;
        }

        public string EventClass
        {
            get { return m_eventClass; }
        }

        public List<Action> Actions
        {
            get { return m_actions; }
        }

        public Entity Entity
        {
            get { return m_entity; }
        }
    }

    public class GbsExecutor
    {
        private readonly Engine.Gbe m_engine;

        private readonly Dictionary<string, List<Entity>> m_entitiesByClass = new Dictionary<string, List<Entity>>();
        private readonly Dictionary<string, Entity> m_entitiesByName = new Dictionary<string, Entity>();
        private readonly CompiledGbs m_script;

        private readonly List<TimeTriggerInstance> m_timeTriggers = new List<TimeTriggerInstance>();
        private readonly Dictionary<string, List<EventTriggerInstance>> m_eventTriggers = new Dictionary<string, List<EventTriggerInstance>>();

        private readonly List<string> m_raisedEvents = new List<string>();

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
            // Update time triggers
            var timeTriggersToExecute = new List<TimeTriggerInstance>();
            foreach (var trigger in m_timeTriggers)
            {
                if (trigger.Time <= Engine.Context.TotalElapsedSeconds)
                {
                    timeTriggersToExecute.Add(trigger);
                }
                else
                {
                    break;
                }
            }
            foreach (var trigger in timeTriggersToExecute)
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

            // Update event triggers
            var eventTriggersToExecute = new List<EventTriggerInstance>();
            foreach (var raisedEvent in m_raisedEvents)
            {
                List<EventTriggerInstance> triggers;
                if (m_eventTriggers.TryGetValue(raisedEvent, out triggers))
                {
                    eventTriggersToExecute.AddRange(triggers);
                }
            }
            m_raisedEvents.Clear();
            foreach (var trigger in eventTriggersToExecute)
            {
                foreach (var action in trigger.Actions)
                {
                    action.Execute(this, trigger.Entity);
                }
            }

            // Update entities (trajectories)
            foreach(var entity in m_entitiesByName.Values)
            {
                entity.Update(Engine.Context.PreviousUpdateElapsedSeconds);
            }
        }

        public void Raise(string eventClass)
        {
            m_raisedEvents.Add(eventClass);
        }

        public void RegisterTimeTrigger(float time, Entity entity, List<Action> actions, float autoRegisterTime)
        {
            m_timeTriggers.Add(new TimeTriggerInstance(time, entity, actions, autoRegisterTime));
            m_timeTriggers.Sort();
        }

        public void UnregisterTimeTrigger(Entity entity, List<Action> actions, float autoRegisterTime)
        {
            var index = m_timeTriggers.FindIndex(
                trigger => trigger.Actions == actions && trigger.AutoRegisterTime == autoRegisterTime && trigger.Entity == entity);
            if (index != -1)
            {
                m_timeTriggers.RemoveAt(index);
            }
        }

        public void RegisterEventTrigger(Entity entity, List<Action> actions, string eventClass)
        {
            List<EventTriggerInstance> triggers;
            if (!m_eventTriggers.TryGetValue(eventClass, out triggers))
            {
                triggers = new List<EventTriggerInstance>();
                m_eventTriggers[eventClass] = triggers;
            }
            triggers.Add(new EventTriggerInstance(eventClass, actions, entity));
        }

        public void UnregisterEventTrigger(Entity entity, List<Action> actions, string eventClass)
        {
            List<EventTriggerInstance> triggers;
            if (m_eventTriggers.TryGetValue(eventClass, out triggers))
            {
                var index = triggers.FindIndex(trigger => trigger.Entity == entity && trigger.Actions == actions);
                if (index != -1)
                {
                    triggers.RemoveAt(index);
                }
                if (triggers.Count == 0)
                {
                    m_eventTriggers.Remove(eventClass);
                }
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

        public void Unregister(Entity entity)
        {
            m_entitiesByName.Remove(entity.Name);
            List<Entity> entitiesOfThisClass;
            m_entitiesByClass.TryGetValue(entity.Classdef.ClassName, out entitiesOfThisClass);
            entitiesOfThisClass.Remove(entity);
        }
    }
}