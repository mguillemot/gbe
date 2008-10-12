using Gbe.Script.Classdefs;

namespace Gbe.Script.Executor.Entities
{
    public class ScriptEntity : Entity
    {
        public ScriptEntity(Classdef classdef, string name) : base(classdef, name)
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
    }
}
