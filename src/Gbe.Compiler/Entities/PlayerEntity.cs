using System.Collections.Generic;
using Gbe.Compiler.Triggers;

namespace Gbe.Compiler.Entities
{
    public class PlayerEntity : Entity
    {
        public PlayerEntity(string className, List<Entity> subEntities, List<Trigger> triggers) : base(className, subEntities, triggers)
        {
        }

        public override string EntityType
        {
            get { return "EVENT"; }
        }
    }
}
