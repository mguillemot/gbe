using System.Collections.Generic;
using Gbe.Engine.Executor.Actions;

namespace Gbe.Engine.Executor.Rules
{
    public class DieWhenOutOfBoundsRule : ExecutorRule
    {
        public override int ComputeActions(Gear gear, GbeContext context, List<ExecutorAction> actions)
        {
            Point2 position = gear.Position;
            if (position.X < context.GameArea.TopLeftCorner.X || position.X > context.GameArea.BottomRightCorner.X
                || position.Y < context.GameArea.TopLeftCorner.Y || position.Y > context.GameArea.BottomRightCorner.Y)
            {
                actions.Add(new DieAction());
                return 1;
            }
            return 0;
        }
    }
}