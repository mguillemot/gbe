using System.Collections.Generic;
using Gbe.Script.Executor.Entities;
using Gbe.Script.Triggers;

namespace Gbe.Script.Classdefs
{
    public class BulletClassdef : Classdef
    {
        private static int s_nextId = 1;

        public BulletClassdef(string className, List<Classdef> subEntities, List<Trigger> triggers)
            : base(className, subEntities, triggers)
        {
        }

        public override string EntityType
        {
            get { return "BULLET"; }
        }

        public BulletEntity NewInstance()
        {
            return new BulletEntity(this, ClassName + "_" + (s_nextId++));
        }
    }
}