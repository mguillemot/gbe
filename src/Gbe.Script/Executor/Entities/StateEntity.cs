using System.Collections.Generic;
using Gbe.Engine;
using Gbe.Script.Classdefs;

namespace Gbe.Script.Executor.Entities
{
    public class StateEntity : Entity
    {
        private readonly Entity m_appliedOn;
        private readonly Dictionary<string, float> m_variables = new Dictionary<string, float>();

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

        public override float GetVariable(string variableName)
        {
            return m_variables[variableName];
        }

        public override void SetVariable(string variableName, float value)
        {
            m_variables[variableName] = value;
        }
    }
}
