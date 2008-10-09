using Gbe.Engine;
using Gbe.Script.Classdefs;

namespace Gbe.Script.Executor
{
    public class EntityInstance
    {
        private readonly Classdef _classdef;
        private readonly int _engineId;
        private readonly string _instanceName;

        private Entity _engineEntity;

        public EntityInstance(Classdef classdef, string instanceName, int engineId)
        {
            _classdef = classdef;
            _instanceName = instanceName;
            _engineId = engineId;
        }

        public Classdefs Classdef
        {
            get { return _classdef; }
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
            _engineEntity = _classdef.CreateEngineEntity(_engineId);
            engine.AddEntity(_engineEntity);
            foreach (var trigger in _classdef.Triggers)
            {
                trigger.Register(engine, context, this);
            }
        }
    }
}