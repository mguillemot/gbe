using System.Collections.Generic;
using Gbe.Engine.GearLibrary;
using Gbe.Script.Executor;

namespace Gbe.Script.Actions
{
    public class SummonAction : Action
    {
        private readonly string m_enemyClass;
        private readonly string m_enemyName;
        private readonly List<Action> m_summonActions;

        public SummonAction(string target, string enemyClass, string enemyName, List<Action> summonActions)
            : base(target)
        {
            m_enemyClass = enemyClass;
            m_enemyName = enemyName;
            m_summonActions = summonActions;
        }

        public override void Execute(GbsExecutor scriptExecutor, Entity entity)
        {
            var enemyEntity = scriptExecutor.GenerateNamedEntity(m_enemyClass, m_enemyName);
            var enemyGear = new EnemyGear(enemyEntity.EngineId);
            scriptExecutor.Engine.AddGear(enemyGear);
            if (m_summonActions != null)
            {
                foreach (var enemyInitAction in m_summonActions)
                {
                    enemyInitAction.Execute(scriptExecutor, enemyEntity);
                }
            }
        }
    }
}