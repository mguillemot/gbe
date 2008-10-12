using System.Collections.Generic;
using Gbe.Engine.Executor.Actions;

namespace Gbe.Engine.Executor.Rules
{
    public class LinearTrajectoryRule : ExecutorRule
    {
        private readonly float _angle;

        public LinearTrajectoryRule(float angle)
        {
            _angle = angle;
        }

        public float Angle
        {
            get { return _angle; }
        }

        public override int ComputeActions(Gear gear, GbeContext context, List<ExecutorAction> actions)
        {
            var entitySpeed = GearProperties.GetSpeed(gear);
            var dx = entitySpeed*MathHelper.Cos(_angle)*context.PreviousUpdateElapsedSeconds;
            var dy = entitySpeed*MathHelper.Sin(_angle)*context.PreviousUpdateElapsedSeconds;
            actions.Add(new MoveAction(dx, dy));
            return 1;
        }
    }
}