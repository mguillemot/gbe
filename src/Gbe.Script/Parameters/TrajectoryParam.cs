using Gbe.Script.Formulas;
using Gbe.Script.Shapedefs;

namespace Gbe.Script.Parameters
{
    public class TrajectoryParam : Param
    {
        private readonly Shapedef m_trajectory;

        public TrajectoryParam(Shapedef trajectory)
        {
            m_trajectory = trajectory;
        }

        public override void Execute(EvaluationContext context)
        {
            context.EvaluationEntity.SetTrajectory(m_trajectory.NewInstance(context));
        }

        public override Param Compile()
        {
            return new TrajectoryParam(m_trajectory.Compile());
        }
    }
}