using System.Collections.Generic;
using Gbe.Script.Entities;
using Gbe.Script.Entities;
using BulletEntity=Gbe.Script.Entities.BulletEntity;
using EnemyEntity=Gbe.Script.Entities.EnemyEntity;
using Entity=Gbe.Script.Entities.Entity;
using EventEntity=Gbe.Script.Entities.EventEntity;
using PlayerEntity=Gbe.Script.Entities.PlayerEntity;
using ScriptEntity=Gbe.Script.Entities.ScriptEntity;
using StateEntity=Gbe.Script.Entities.StateEntity;

namespace Gbe.Script
{
    public class CompiledGbs
    {
        private readonly Dictionary<string, Entity> _entitiesByName = new Dictionary<string, Entity>();
        private Entities.EngineEntity _engineEntity;
        private readonly Dictionary<string, PlayerEntity> _playerEntities = new Dictionary<string, PlayerEntity>();
        private readonly Dictionary<string, BulletEntity> _bulletEntities = new Dictionary<string, BulletEntity>();
        private readonly Dictionary<string, EnemyEntity> _enemyEntities = new Dictionary<string, EnemyEntity>();
        private readonly Dictionary<string, ScriptEntity> _scriptEntities = new Dictionary<string, ScriptEntity>();
        private readonly Dictionary<string, StateEntity> _stateEntities = new Dictionary<string, StateEntity>();
        private readonly Dictionary<string, EventEntity> _eventEntities = new Dictionary<string, EventEntity>();

        private Engine.Engine _engine;

        internal CompiledGbs()
        {
            // This is created by Gbs.Compile() only
        }

        public Dictionary<string, Entity> EntitiesByName
        {
            get { return _entitiesByName; }
        }

        public EngineEntity EngineEntity
        {
            get { return _engineEntity; }
            internal set { _engineEntity = value; }
        }

        public Dictionary<string, PlayerEntity> PlayerEntities
        {
            get { return _playerEntities; }
        }

        public Dictionary<string, BulletEntity> BulletEntities
        {
            get { return _bulletEntities; }
        }

        public Dictionary<string, EnemyEntity> EnemyEntities
        {
            get { return _enemyEntities; }
        }

        public Dictionary<string, ScriptEntity> ScriptEntities
        {
            get { return _scriptEntities; }
        }

        public Dictionary<string, StateEntity> StateEntities
        {
            get { return _stateEntities; }
        }

        public Dictionary<string, EventEntity> EventEntities
        {
            get { return _eventEntities; }
        }

        public void Run(Engine.Engine engine, string scriptClass)
        {
            _engine = engine;
            // TODO catch script inconnu ?
            var script = _scriptEntities[scriptClass];
            var scriptInstance = new EntityInstance(script, "script", engine.EngineEntity.Id);
            foreach (var trigger in script.Triggers)
            {
                trigger.Register(engine, this, scriptInstance);
            }
        }

        internal EntityInstance GenerateInstance(string instanceClass, string instanceName)
        {
            var instance = new EntityInstance(_entitiesByName[instanceClass], instanceName, _engine.GenerateId());
            instance.Register(_engine, this);
            return instance;
        }
    }
}
