using Gbe.Engine;
using Gbe.Script.Classdefs;

namespace Gbe.Script.Executor
{
    public class Entity
    {
        private readonly Classdef m_classdef;
        private readonly int m_engineId;
        private readonly string m_name;

        // Can be created by GbsExecutor only
        internal Entity(Classdef classdef, string name, int engineId)
        {
            m_classdef = classdef;
            m_name = name;
            m_engineId = engineId;
        }

        // Can be created by GbsExecutor only
        internal Entity(Classdef classdef, string name)
            : this(classdef, name, -1)
        {
        }

        public Classdef Classdef
        {
            get { return m_classdef; }
        }

        public string Name
        {
            get { return m_name; }
        }

        public int EngineId
        {
            get { return m_engineId; }
        }
    }
}