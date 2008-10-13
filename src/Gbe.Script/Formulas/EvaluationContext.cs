using Gbe.Engine;
using Gbe.Script.Executor.Entities;

namespace Gbe.Script.Formulas
{
    public class EvaluationContext
    {
        private Entity m_evaluationEntity;
        private Point2 m_playerPosition;

        public Entity EvaluationEntity
        {
            get { return m_evaluationEntity; }
            set { m_evaluationEntity = value; }
        }

        public Point2 PlayerPosition
        {
            get { return m_playerPosition; }
            set { m_playerPosition = value; }
        }
    }
}
