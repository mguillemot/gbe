using System.Collections.Generic;
using Gbe.Script.Triggers;
using Gbe.Script.Triggers;

namespace Gbe.Script.Entities
{
    public class ScriptEntity : Entity
    {
        public ScriptEntity(string className, List<Entity> subEntities, List<Trigger> triggers) : base(className, subEntities, triggers)
        {
        }

        public override string EntityType
        {
            get { return "SCRIPT"; }
        }
    }
}