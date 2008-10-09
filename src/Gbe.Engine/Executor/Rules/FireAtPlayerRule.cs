using System.Collections.Generic;
using Gbe.Engine.Executor.Actions;

namespace Gbe.Engine.Executor.Rules
{
    public class FireAtPlayerRule : ExecutorRule
    {
        private readonly float _bulletSpeed;
        private readonly float _initialAngle;

        public FireAtPlayerRule(float bulletSpeed, float initialAngle)
        {
            _bulletSpeed = bulletSpeed;
            _initialAngle = initialAngle;
        }

        public FireAtPlayerRule(float bulletSpeed)
        {
            _bulletSpeed = bulletSpeed;
            _initialAngle = 0;
        }

        public override int ComputeActions(Entity entity, GameContext context, List<ExecutorAction> actions)
        {
            actions.Add(new FireAtPlayerAction(_bulletSpeed, _initialAngle));
            return 1;
        }
    }
}