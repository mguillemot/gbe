using System.Collections.Generic;

namespace Gbe.Script.Executor
{
    public class GbsExecutor
    {
        private readonly Engine.Gbe m_engine;
        private readonly CompiledGbs m_script;
        
        private readonly Dictionary<string, List<Entity>> m_entitiesByClass = new Dictionary<string, List<Entity>>();
        private readonly Dictionary<string, Entity> m_entitiesByName = new Dictionary<string, Entity>();

        public GbsExecutor(Engine.Gbe engine, CompiledGbs script)
        {
            m_engine = engine;
            m_script = script;
        }

        public Engine.Gbe Engine
        {
            get { return m_engine; }
        }

        public CompiledGbs Script
        {
            get { return m_script; }
        }

        public void Update()
        {
        }

        public Entity GenerateNamedEntity(string entityClass, string entityName)
        {
            var classdef = m_script.GetClassdef(entityClass);
            var entity = new Entity(classdef, entityName, m_engine.GenerateId());
            m_entitiesByName[entityName] = entity;
            List<Entity> entitiesOfThisClass;
            if (!m_entitiesByClass.TryGetValue(entityClass, out entitiesOfThisClass))
            {
                entitiesOfThisClass = new List<Entity>();
                m_entitiesByClass[entityClass] = entitiesOfThisClass;
            }
            entitiesOfThisClass.Add(entity);
            return entity;
        }

        /*
        public Entity GenerateAnonymousEntity(string entityClass)
        {
            var classdef = m_script.GetClassdef(entityClass);

        }
         */
    }
}
