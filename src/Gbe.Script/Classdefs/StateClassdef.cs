using System.Collections.Generic;
using Gbe.Script.Executor.Entities;
using Gbe.Script.Triggers;

namespace Gbe.Script.Classdefs
{
    public class StateClassdef : Classdef
    {
        private static int s_nextId = 1;

        public StateClassdef(string className, List<Classdef> subEntities, List<Trigger> triggers)
            : base(className, subEntities, triggers)
        {
        }

        public override string EntityType
        {
            get { return "STATE"; }
        }

        public StateEntity NewInstance(Entity appliedOn)
        {
            return new StateEntity(this, ClassName + "_" + (s_nextId++), appliedOn);
        }
    }
}