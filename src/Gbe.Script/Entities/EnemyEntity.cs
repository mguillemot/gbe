using System.Collections.Generic;
using Gbe.Script.Triggers;
using Gbe.Script.Triggers;

namespace Gbe.Script.Entities
{
    public class EnemyEntity : Entity
    {
        public EnemyEntity(string className, List<Entity> subEntities, List<Trigger> triggers) : base(className, subEntities, triggers)
        {
        }

        public override string EntityType
        {
            get { return "ENEMY"; }
        }

        public override Engine.Entity CreateEngineEntity(int id)
        {
            return new Engine.Entities.EnemyEntity(id);
        }
    }
}
