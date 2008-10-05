using System;
using System.Collections.Generic;
using Gbe.Compiler.Triggers;

namespace Gbe.Compiler.Entities
{
    public abstract class Entity
    {
        // Before check
        private readonly string _className;
        private readonly List<Entity> _subEntities;
        private readonly List<Trigger> _triggers;

        // After check
        private InitTrigger _initTrigger = null;
        private CleanupTrigger _cleanupTrigger = null;

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

        public InitTrigger InitTrigger
        {
            get { return _initTrigger; }
        }

        public CleanupTrigger CleanupTrigger
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
                    if (trigger is InitTrigger)
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
                    else if (trigger is CleanupTrigger)
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
    }
}
