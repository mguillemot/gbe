using System.Collections.Generic;
using Gbe.Script.Executor;
using Gbe.Script.Executor.Entities;
using Gbe.Script.Triggers;

namespace Gbe.Script.Classdefs
{
    public class EnemyClassdef : Classdef
    {
        public EnemyClassdef(string className, List<Classdef> subEntities, List<Trigger> triggers)
            : base(className, subEntities, triggers)
        {
        }

        public override string EntityType
        {
            get { return "ENEMY"; }
        }

        public EnemyEntity NewInstance(string name)
        {
            return new EnemyEntity(this, name);
        }
    }
}