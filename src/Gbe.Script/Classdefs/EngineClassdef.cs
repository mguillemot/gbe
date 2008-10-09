using System.Collections.Generic;
using Gbe.Script.Triggers;

namespace Gbe.Script.Classdefs
{
    public class EngineClassdef : Classdef
    {
        public const string ENGINE_CLASSNAME = "Engine";

        public EngineClassdef(List<Trigger> triggers)
            : base(ENGINE_CLASSNAME, null, triggers)
        {
        }

        public override string EntityType
        {
            get { return "ENGINE"; }
        }
    }
}