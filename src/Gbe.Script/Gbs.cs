using System;
using System.Collections.Generic;
using Gbe.Script.Classdefs;

namespace Gbe.Script
{
    public class Gbs
    {
        private readonly List<Classdefs> _entities;

        public Gbs(List<Classdefs> entities)
        {
            _entities = entities;
        }

        public List<Classdefs> Entities
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
                    if (entity is EngineClassdef)
                    {
                        compiled.EngineClassdef = (EngineClassdef) entity;
                    }
                    else if (entity is PlayerClassdef)
                    {
                        compiled.PlayerEntities[entity.ClassName] = (PlayerClassdef) entity;
                    }
                    else if (entity is BulletClassdef)
                    {
                        compiled.BulletEntities[entity.ClassName] = (BulletClassdef) entity;
                    }
                    else if (entity is EnemyClassdef)
                    {
                        compiled.EnemyEntities[entity.ClassName] = (EnemyClassdef) entity;
                    }
                    else if (entity is ScriptClassdef)
                    {
                        compiled.ScriptEntities[entity.ClassName] = (ScriptClassdef) entity;
                    }
                    else if (entity is StateClassdef)
                    {
                        compiled.StateEntities[entity.ClassName] = (StateClassdef) entity;
                    }
                    else if (entity is EventClassdef)
                    {
                        compiled.EventEntities[entity.ClassName] = (EventClassdef) entity;
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
            if (compiled.EngineClassdef == null)
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