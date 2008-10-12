using System.Collections.Generic;
using Gbe.Engine;
using Gbe.Engine.GearLibrary;
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

        public override Gear CreateEngineEntity(int id)
        {
            return new EnemyGear(id);
        }
    }
}