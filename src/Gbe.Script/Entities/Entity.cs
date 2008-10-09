using System;
using System.Collections.Generic;
using Gbe.Script.Triggers;
using Gbe.Script.Triggers;
using InitTrigger=Gbe.Script.Triggers.InitTrigger;
using Trigger=Gbe.Script.Triggers.Trigger;

namespace Gbe.Script.Entities
{
    public abstract class Entity
    {
        // Before check
        private readonly string _className;
        private readonly List<Entity> _subEntities;
        private readonly List<Trigger> _triggers;

        // After check
        private Triggers.InitTrigger _initTrigger = null;
        private Triggers.CleanupTrigger _cleanupTrigger = null;

        protected Entity(string className, List<Entity> subEntities, List<Trigger> triggers)
        {
            _className = className;
            _subEntities = subEntities;
            _triggers = triggers;
        }

        public string ClassName
        {
            get { return _className; }
        }

        public List<Entity> SubEntities
        {
            get { return _subEntities; }
        }

        public List<Trigger> Triggers
        {
            get { return _triggers; }
        }

        public Triggers.InitTrigger InitTrigger
        {
            get { return _initTrigger; }
        }

        public Triggers.CleanupTrigger CleanupTrigger
        {
            get { return _cleanupTrigger; }
        }

        public abstract string EntityType
        { 
            get;
        }

        public virtual bool Check()
        {
            if (_triggers != null)
            {
                foreach (var trigger in _triggers)
                {
                    if (trigger is Triggers.InitTrigger)
                    {
                        if (_initTrigger == null)
                        {
                            _initTrigger = (InitTrigger) trigger;
                        }
                        else
                        {
                            Console.Error.WriteLine("Multiple @init triggers for " + EntityType + " entity " + ClassName);
                            return false;
                        }
                    }
                    else if (trigger is Triggers.CleanupTrigger)
                    {
                        if (_cleanupTrigger == null)
                        {
                            _cleanupTrigger = (CleanupTrigger) trigger;
                        }
                        else
                        {
                            Console.Error.WriteLine("Multiple @cleanup triggers for " + EntityType + " entity " +
                                                    ClassName);
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public virtual Engine.Entity CreateEngineEntity(int id)
        {
            return new Engine.Entity(id);
        }
    }
}
