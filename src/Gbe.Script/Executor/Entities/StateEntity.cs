using Gbe.Engine;
using Gbe.Script.Classdefs;

namespace Gbe.Script.Executor.Entities
{
    public class StateEntity : Entity
    {
        private readonly Entity m_appliedOn;

        public StateEntity(Classdef classdef, string name, Entity appliedOn) 
            : base(classdef, name)
        {
            m_appliedOn = appliedOn;
        }

        public Entity AppliedOn
        {
            get { return m_appliedOn; }
        }

        public override Gear Gear
        {
            get { return AppliedOn.Gear; }
        }
    }
}
