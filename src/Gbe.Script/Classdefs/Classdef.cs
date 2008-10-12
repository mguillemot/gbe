using System;
using System.Collections.Generic;
using Gbe.Engine;
using Gbe.Script.Executor;
using Gbe.Script.Executor.Entities;
using Gbe.Script.Triggers;

namespace Gbe.Script.Classdefs
{
    public abstract class Classdef
    {
        // Before check
        private readonly string _className;
        private readonly List<Classdef> _subEntities;
        private readonly List<Trigger> _triggers;

        // After check
        private CleanupTrigger _cleanupTrigger;
        private InitTrigger _initTrigger;

        protected Classdef(string className, List<Classdef> subEntities, List<Trigger> triggers)
        {
            _className = className;
            _subEntities = subEntities;
            _triggers = triggers;
        }

        public string ClassName
        {
            get { return _className; }
        }

        public List<Classdef> SubEntities
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

        public abstract string EntityType { get; }

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