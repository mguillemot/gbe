using Gbe.Script.Executor;
using Gbe.Script.Executor.Entities;

namespace Gbe.Script.Classdefs
{
    public class EventClassdef : Classdef
    {
        public EventClassdef(string className) : base(className, null, null)
        {
        }

        public override string EntityType
        {
            get { return "EVENT"; }
        }
    }
}