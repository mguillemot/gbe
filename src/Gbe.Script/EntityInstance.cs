using Gbe.Script.Entities;
using Gbe.Script.Entities;

namespace Gbe.Script
{
    public class EntityInstance
    {
        private readonly Entities.Entity _entity;
        private readonly string _instanceName;
        private readonly int _engineId;

        private Engine.Entity _engineEntity;

        public EntityInstance(Entities.Entity entity, string instanceName, int engineId)
        {
            _entity = entity;
            _instanceName = instanceName;
            _engineId = engineId;
        }

        public Entity Entity
        {
            get { return _entity; }
        }

        public string InstanceName
        {
            get { return _instanceName; }
        }

        public int EngineId
        {
            get { return _engineId; }
        }

        public void Register(Engine.Engine engine, CompiledGbs context)
        {
            _engineEntity = _entity.CreateEngineEntity(_engineId);
            engine.AddEntity(_engineEntity);
            foreach (var trigger in _entity.Triggers)
            {
                trigger.Register(engine, context, this);
            }
        }
    }
}
