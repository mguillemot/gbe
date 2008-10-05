using System;
using System.Collections.Generic;
using Gbe.Compiler.Actions;
using Gbe.Compiler.Entities;
using Gbe.Compiler.Parameters;
using Gbe.Compiler.Triggers;

namespace Gbe.Compiler
{
    public class Gbs
    {
        // Before check
        private readonly List<Entity> _entities;

        // After check
        private bool _checked = false;
        private readonly Dictionary<string, Entity> _entitiesByName = new Dictionary<string, Entity>();
        private EngineEntity _engineEntity;
        private readonly Dictionary<string, PlayerEntity> _playerEntities = new Dictionary<string, PlayerEntity>();
        private readonly Dictionary<string, BulletEntity> _bulletEntities = new Dictionary<string, BulletEntity>();
        private readonly Dictionary<string, EnemyEntity> _enemyEntities = new Dictionary<string, EnemyEntity>();
        private readonly Dictionary<string, ScriptEntity> _scriptEntities = new Dictionary<string, ScriptEntity>();
        private readonly Dictionary<string, StateEntity> _stateEntities = new Dictionary<string, StateEntity>();
        private readonly Dictionary<string, EventEntity> _eventEntities = new Dictionary<string, EventEntity>();

        public Gbs(List<Entity> entities)
        {
            _entities = entities;
        }

        public bool Check()
        {
            if (_checked) return true;
            foreach (var entity in _entities)
            {
                if (!_entitiesByName.ContainsKey(entity.ClassName))
                {
                    _entitiesByName[entity.ClassName] = entity;
                    if (entity is EngineEntity)
                    {
                        _engineEntity = (EngineEntity) entity;
                    }
                    else if (entity is PlayerEntity)
                    {
                        _playerEntities[entity.ClassName] = (PlayerEntity) entity;
                    }
                    else if (entity is BulletEntity)
                    {
                        _bulletEntities[entity.ClassName] = (BulletEntity) entity;
                    }
                    else if (entity is EnemyEntity)
                    {
                        _enemyEntities[entity.ClassName] = (EnemyEntity) entity;
                    }
                    else if (entity is ScriptEntity)
                    {
                        _scriptEntities[entity.ClassName] = (ScriptEntity) entity;
                    }
                    else if (entity is StateEntity)
                    {
                        _stateEntities[entity.ClassName] = (StateEntity) entity;
                    }
                    else if (entity is EventEntity)
                    {
                        _eventEntities[entity.ClassName] = (EventEntity) entity;
                    }
                    if (!entity.Check())
                    {
                        return false;
                    }
                }
                else
                {
                    Console.Error.WriteLine("Duplicate entity: " + entity.ClassName);
                    return false;
                }
            }
            if (_engineEntity == null)
            {
                Console.Error.WriteLine("No ENGINE entity.");
                return false;
            }
            if (_playerEntities.Count == 0)
            {
                Console.Error.WriteLine("No PLAYER entity.");
                return false;
            }
            _entities.Clear();
            _checked = true;
            return true;
        }

        public bool Checked
        {
            get { return _checked; }
        }

        // TODO à virer
        public List<Entity> Entities
        {
            get { return _entities; }
        }

        public void Run(Engine.Engine engine, string scriptClass)
        {
            var script = _scriptEntities[scriptClass];
            foreach (var trigger in script.Triggers)
            {
                if (trigger is InitTrigger)
                {
                    foreach (var action in trigger.Actions)
                    {
                        if (action is SummonAction)
                        {
                            var summonAction = (SummonAction) action;
                            var enemyEntity = _enemyEntities[summonAction.EnemyClass];
                            var engineEntity = new Engine.Entities.EnemyEntity(engine.GenerateId());
                            if (enemyEntity.InitTrigger != null)
                            {
                                foreach (var enemyInitAction in enemyEntity.InitTrigger.Actions)
                                {
                                    if (enemyInitAction is SetAction)
                                    {
                                        var setAction = (SetAction) enemyInitAction;
                                        setAction.Param.Set(engineEntity);
                                    }
                                }
                            }
                            if (summonAction.SummonActions != null)
                            {
                                foreach (var enemyInitAction in summonAction.SummonActions)
                                {
                                    //!!!code dupliqué
                                    if (enemyInitAction is SetAction)
                                    {
                                        var setAction = (SetAction) enemyInitAction;
                                        setAction.Param.Set(engineEntity);
                                    }
                                }
                            }
                            engine.AddEntity(engineEntity);
                        }
                    }
                }
            }
        }
    }
}
