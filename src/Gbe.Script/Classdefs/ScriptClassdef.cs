using System.Collections.Generic;
using Gbe.Script.Executor.Entities;
using Gbe.Script.Triggers;

namespace Gbe.Script.Classdefs
{
    public class ScriptClassdef : Classdef
    {
        public ScriptClassdef(string className, List<Classdef> subEntities, List<Trigger> triggers)
            : base(className, subEntities, triggers)
        {
        }

        public override string EntityType
        {
            get { return "SCRIPT"; }
        }

        public ScriptEntity NewInstance()
        {
            return new ScriptEntity(this, ClassName + "_instance");
        }
    }
}