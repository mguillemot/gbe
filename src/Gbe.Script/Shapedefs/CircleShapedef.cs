using Gbe.Engine;
using Gbe.Script.Executor.Shapes;
using Gbe.Script.Formulas;
using Gbe.Script.Shapes;

namespace Gbe.Script.Shapedefs
{
    public class CircleShapedef : Shapedef
    {
        private readonly Point2 m_center;
        private readonly Formula m_radius;
        private readonly Formula m_initialAngle;

        public CircleShapedef(Point2 center, Formula radius, Formula initialAngle)
        {
            m_center = center;
            m_radius = radius;
            m_initialAngle = initialAngle;
        }

        public Formula InitialAngle
        {
            get { return m_initialAngle; }
        }

        public Point2 Center
        {
            get { return m_center; }
        }

        public Formula Radius
        {
            get { return m_radius; }
        }

        public override Shape NewInstance(EvaluationContext context)
        {
            return new CircleShape(this, context);
        }

        public override Shapedef Compile()
        {
            return new CircleShapedef(m_center, m_radius.Compile(), m_initialAngle.Compile());
        }
    }
}
