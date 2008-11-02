using System.Collections.Generic;
using Gbe.Script.Classdefs;

namespace Gbe.Script.Executor.Entities
{
    public class ScriptEntity : Entity
    {
        private readonly Dictionary<string, float> m_variables = new Dictionary<string, float>();

        public ScriptEntity(Classdef classdef, string name)
            : base(classdef, name)
        {
        }

        public void Register(GbsExecutor scriptExecutor)
        {
            scriptExecutor.Register(this);
            foreach (var trigger in Classdef.Triggers)
            {
                trigger.Register(scriptExecutor, this);
            }
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
