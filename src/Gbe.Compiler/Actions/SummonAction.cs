using System.Collections.Generic;

namespace Gbe.Compiler.Actions
{
    public class SummonAction : Action
    {
        private readonly string _enemyClass;
        private readonly string _enemyName;
        private readonly List<Action> _summonActions;

        public SummonAction(string target, string enemyClass, string enemyName, List<Action> summonActions) 
            : base(target)
        {
            _enemyClass = enemyClass;
            _enemyName = enemyName;
            _summonActions = summonActions;
        }

        public string EnemyClass
        {
            get { return _enemyClass; }
        }

        public string EnemyName
        {
            get { return _enemyName; }
        }

        public List<Action> SummonActions
        {
            get { return _summonActions; }
        }
    }
}
