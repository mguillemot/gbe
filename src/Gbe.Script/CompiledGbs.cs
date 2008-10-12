using System.Collections.Generic;
using Gbe.Script.Classdefs;
using Gbe.Script.Executor;

namespace Gbe.Script
{
    public class CompiledGbs
    {
        private readonly Dictionary<string, BulletClassdef> m_bulletClassdefs = new Dictionary<string, BulletClassdef>();
        private readonly Dictionary<string, EnemyClassdef> m_enemyClassdefs = new Dictionary<string, EnemyClassdef>();
        private readonly Dictionary<string, Classdef> m_classdefsByName = new Dictionary<string, Classdef>();
        private readonly Dictionary<string, EventClassdef> m_eventClassdefs = new Dictionary<string, EventClassdef>();
        private readonly Dictionary<string, PlayerClassdef> m_playerClassdefs = new Dictionary<string, PlayerClassdef>();
        private readonly Dictionary<string, ScriptClassdef> m_scriptClassdefs = new Dictionary<string, ScriptClassdef>();
        private readonly Dictionary<string, StateClassdef> m_stateClassdefs = new Dictionary<string, StateClassdef>();

        private EngineClassdef m_engineClassdef;

        internal CompiledGbs()
        {
            // This is created by Gbs.Compile() only
        }

        public Classdef GetClassdef(string name)
        {
            Classdef classdef;
            if (m_classdefsByName.TryGetValue(name, out classdef))
            {
                return classdef;
            }
            return null;
        }

        public EnemyClassdef GetEnemyClassdef(string name)
        {
            EnemyClassdef classdef;
            if (m_enemyClassdefs.TryGetValue(name, out classdef))
            {
                return classdef;
            }
            return null;
        }

        public BulletClassdef GetBulletClassdef(string name)
        {
            BulletClassdef classdef;
            if (m_bulletClassdefs.TryGetValue(name, out classdef))
            {
                return classdef;
            }
            return null;
        }

        public StateClassdef GetStateClassdef(string name)
        {
            StateClassdef classdef;
            if (m_stateClassdefs.TryGetValue(name, out classdef))
            {
                return classdef;
            }
            return null;
        }

        public EngineClassdef GetEngineClassdef()
        {
            return m_engineClassdef;
        }

        internal int GetPlayerClassdefCount()
        {
            return m_playerClassdefs.Count;
        }

        internal void AddClassdef(Classdef classdef)
        {
            m_classdefsByName[classdef.ClassName] = classdef;
            if (classdef is EngineClassdef)
            {
                m_engineClassdef = (EngineClassdef) classdef;
            }
            else if (classdef is PlayerClassdef)
            {
                m_playerClassdefs[classdef.ClassName] = (PlayerClassdef)classdef;
            }
            else if (classdef is BulletClassdef)
            {
                m_bulletClassdefs[classdef.ClassName] = (BulletClassdef)classdef;
            }
            else if (classdef is EnemyClassdef)
            {
                m_enemyClassdefs[classdef.ClassName] = (EnemyClassdef)classdef;
            }
            else if (classdef is ScriptClassdef)
            {
                m_scriptClassdefs[classdef.ClassName] = (ScriptClassdef)classdef;
            }
            else if (classdef is StateClassdef)
            {
                m_stateClassdefs[classdef.ClassName] = (StateClassdef)classdef;
            }
            else if (classdef is EventClassdef)
            {
                m_eventClassdefs[classdef.ClassName] = (EventClassdef)classdef;
            }
        }

        public GbsExecutor Run(Engine.Gbe gbe, string scriptClass)
        {
            var executor = new GbsExecutor(gbe, this);
            var scriptClassdef = m_scriptClassdefs[scriptClass];
            var scriptEntity = scriptClassdef.NewInstance();
            scriptEntity.Register(executor);
            return executor;
        }
    }
}