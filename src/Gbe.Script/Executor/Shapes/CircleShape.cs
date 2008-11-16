using Gbe.Engine;
using Gbe.Script.Formulas;
using Gbe.Script.Shapedefs;
using Gbe.Script.Shapes;

namespace Gbe.Script.Executor.Shapes
{
    public class CircleShape : Shape
    {
        private readonly CircleShapedef m_def;
        private readonly float m_radius;
        private float m_currentAngle;

        public CircleShape(CircleShapedef def, EvaluationContext context)
        {
            m_def = def;
            m_currentAngle = def.InitialAngle.Evaluate(context);
            m_radius = def.Radius.Evaluate(context);
        }

        public override Point2 CurrentPosition
        {
            get
            {
                return new Point2(m_def.Center.X + m_radius * MathHelper.Cos(m_currentAngle),
                                  m_def.Center.Y + m_radius * MathHelper.Sin(m_currentAngle));
            }
        }

        public override bool Ended
        {
            get { return false; }
        }

        public override void Advance(float distance)
        {
            m_currentAngle += distance/m_radius;
            m_currentAngle.NormalizeAngle();
        }
    }
}