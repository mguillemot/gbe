using System.Collections.Generic;
using Gbe.Script.Classdefs;
using Gbe.Script.Executor;

namespace Gbe.Script
{
    public class CompiledGbs
    {
        private readonly Dictionary<string, BulletClassdef> _bulletEntities = new Dictionary<string, BulletClassdef>();
        private readonly Dictionary<string, EnemyClassdef> _enemyEntities = new Dictionary<string, EnemyClassdef>();
        private readonly Dictionary<string, Classdef> _entitiesByName = new Dictionary<string, Classdef>();
        private readonly Dictionary<string, EventClassdef> _eventEntities = new Dictionary<string, EventClassdef>();
        private readonly Dictionary<string, PlayerClassdef> _playerEntities = new Dictionary<string, PlayerClassdef>();
        private readonly Dictionary<string, ScriptClassdef> _scriptEntities = new Dictionary<string, ScriptClassdef>();
        private readonly Dictionary<string, StateClassdef> _stateEntities = new Dictionary<string, StateClassdef>();

        private Engine.Engine _engine;
        private EngineClassdef _engineClassdef;

        internal CompiledGbs()
        {
            // This is created by Gbs.Compile() only
        }

        public Dictionary<string, Classdef> EntitiesByName
        {
            get { return _entitiesByName; }
        }

        public EngineClassdef EngineClassdef
        {
            get { return _engineClassdef; }
            internal set { _engineClassdef = value; }
        }

        public Dictionary<string, PlayerClassdef> PlayerEntities
        {
            get { return _playerEntities; }
        }

        public Dictionary<string, BulletClassdef> BulletEntities
        {
            get { return _bulletEntities; }
        }

        public Dictionary<string, EnemyClassdef> EnemyEntities
        {
            get { return _enemyEntities; }
        }

        public Dictionary<string, ScriptClassdef> ScriptEntities
        {
            get { return _scriptEntities; }
        }

        public Dictionary<string, StateClassdef> StateEntities
        {
            get { return _stateEntities; }
        }

        public Dictionary<string, EventClassdef> EventEntities
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