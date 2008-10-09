using System;
using System.Collections.Generic;
using Gbe.Script.Entities;
using Gbe.Script.Entities;

namespace Gbe.Script
{
    public class Gbs
    {
        private readonly List<Entity> _entities;

        public Gbs(List<Entity> entities)
        {
            _entities = entities;
        }

        public List<Entity> Entities
        {
            get { return _entities; }
        }

        public CompiledGbs Compile()
        {
            // TODO trouver une manière plus élégante que l'accès aux fields en internal
            var compiled = new CompiledGbs();
            foreach (var entity in _entities)
            {
                if (!compiled.EntitiesByName.ContainsKey(entity.ClassName))
                {
                    compiled.EntitiesByName[entity.ClassName] = entity;
                    if (entity is EngineEntity)
                    {
                        compiled.EngineEntity = (EngineEntity)entity;
                    }
                    else if (entity is PlayerEntity)
                    {
                        compiled.PlayerEntities[entity.ClassName] = (PlayerEntity)entity;
                    }
                    else if (entity is BulletEntity)
                    {
                        compiled.BulletEntities[entity.ClassName] = (BulletEntity)entity;
                    }
                    else if (entity is EnemyEntity)
                    {
                        compiled.EnemyEntities[entity.ClassName] = (EnemyEntity)entity;
                    }
                    else if (entity is ScriptEntity)
                    {
                        compiled.ScriptEntities[entity.ClassName] = (ScriptEntity)entity;
                    }
                    else if (entity is StateEntity)
                    {
                        compiled.StateEntities[entity.ClassName] = (StateEntity)entity;
                    }
                    else if (entity is EventEntity)
                    {
                        compiled.EventEntities[entity.ClassName] = (EventEntity)entity;
                    }
                    if (!entity.Check())
                    {
                        return null;
                    }
                }
                else
                {
                    Console.Error.WriteLine("Duplicate entity: " + entity.ClassName);
                    return null;
                }
            }
            if (compiled.EngineEntity == null)
            {
                Console.Error.WriteLine("No ENGINE entity.");
                return null;
            }
            if (compiled.PlayerEntities.Count == 0)
            {
                Console.Error.WriteLine("No PLAYER entity.");
                return null;
            }
            _entities.Clear();
            return compiled;
        }
    }
}
