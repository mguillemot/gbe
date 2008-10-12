using System.Collections.Generic;
using Gbe.Engine.Executor.Actions;

namespace Gbe.Engine.Executor.Rules
{
    public class TrackingTrajectoryRule : ExecutorRule
    {
        private readonly float _initialAngle;
        private readonly int _targetId;
        private float _deltaPrime;
        private bool _initialized;
        private float _previousAngle;
        private float _turnEndTime;

        public TrackingTrajectoryRule(int targetId, float initialAngle)
        {
            _targetId = targetId;
            _initialAngle = initialAngle;
        }

        public TrackingTrajectoryRule(int targetId)
        {
            _targetId = targetId;
            _initialAngle = 0;
        }

        public override int ComputeActions(Gear gear, GbeContext context, List<ExecutorAction> actions)
        {
            Gear target;
            if (context.Gears.TryGetValue(_targetId, out target))
            {
                if (!_initialized)
                {
                    var requiredAngle = MathHelper.GetAngleBetween(gear.Position, target.Position);
                    var distance = Point2.Distance(gear.Position, target.Position);
                    _previousAngle = requiredAngle + _initialAngle;
                    _turnEndTime = context.TotalElapsedSeconds + 1.2f*distance/gear.Speed;
                    _initialized = true;
                }

                if (context.TotalElapsedSeconds < _turnEndTime)
                {
                    var requiredAngle = MathHelper.GetAngleBetween(gear.Position, target.Position);
                    var deltaAngle = (requiredAngle - _previousAngle).NormalizeAngle();
                    _deltaPrime = deltaAngle*4f;
                }
                else
                {
                    _deltaPrime *= 57*context.PreviousUpdateElapsedSeconds;
                }
                _previousAngle += _deltaPrime*context.PreviousUpdateElapsedSeconds;

                var entitySpeed = GearProperties.GetSpeed(gear);
                var dx = entitySpeed*MathHelper.Cos(_previousAngle)*context.PreviousUpdateElapsedSeconds;
                var dy = entitySpeed*MathHelper.Sin(_previousAngle)*context.PreviousUpdateElapsedSeconds;
                actions.Add(new MoveAction(dx, dy));
                return 1;
            }
            return 0;
        }
    }
}