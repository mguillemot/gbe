using System.Collections.Generic;
using Gbe.Engine.Entities;
using Gbe.Engine.Executor;

namespace Gbe.Engine
{
    public class Engine
    {
        private readonly GameContext _context = new GameContext();
        private readonly Entity _engineEntity;
        private readonly Dictionary<int, Entity> _entities = new Dictionary<int, Entity>();
        private readonly Executor.Executor _executor = new Executor.Executor();
        private readonly PlayField _playField = new PlayField();
        private int _nextId;
        private int _playerEntityId = -1;

        public Engine()
        {
            _engineEntity = new Entity(GenerateId());
        }

        public Entity EngineEntity
        {
            get { return _engineEntity; }
        }

        public int Fps { get; set; }

        public PlayField PlayField
        {
            get { return _playField; }
        }

        public Executor.Executor Executor
        {
            get { return _executor; }
        }

        public GameContext Context
        {
            get { return _context; }
        }

        public ICollection<Entity> Entities
        {
            get { return _entities.Values; }
        }

        public void AddPlayer(PlayerEntity entity)
        {
            _playerEntityId = entity.Id;
            AddEntity(entity);
        }

        public void AddEntity(Entity entity)
        {
            _entities.Add(entity.Id, entity);
        }

        public void RemoveEntity(Entity entity)
        {
            if (_entities.Remove(entity.Id))
            {
                _executor.RemoveAllRulesFor(entity.Id);
            }
        }

        public int GenerateId()
        {
            return _nextId++;
        }

        public void Update(float elapsedTime)
        {
            _context.CurrentFrame++;
            _context.PreviousUpdateElapsedSeconds = elapsedTime;
            _context.TotalElapsedSeconds += elapsedTime;
            _context.Entities = _entities;
            var actionsByEntity = new Dictionary<Entity, List<ExecutorAction>>(_entities.Count);
            foreach (var entity in _entities.Values)
            {
                List<ExecutorAction> actions = _executor.ComputeActions(entity, _context);
                actionsByEntity.Add(entity, actions);
            }
            foreach (var pair in actionsByEntity)
            {
                if (pair.Value != null)
                {
                    foreach (var action in pair.Value)
                    {
                        action.Execute(pair.Key, this);
                    }
                }
            }
        }

        public PlayerEntity GetPlayer()
        {
            return (PlayerEntity) _entities[_playerEntityId];
        }
    }
}