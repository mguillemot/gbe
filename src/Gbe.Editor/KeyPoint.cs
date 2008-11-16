using Gbe.Engine;

namespace Gbe.Editor
{
    public class KeyPoint
    {
        private Point2 m_point;
        private bool m_hover;
        private bool m_selected;

        public KeyPoint(int x, int y)
        {
            m_point = new Point2(x, y);
        }

        public Point2 Point
        {
            get { return m_point; }
            set { m_point = value; }
        }

        public bool Hover
        {
            get { return m_hover; }
            set { m_hover = value; }
        }

        public bool Selected
        {
            get { return m_selected; }
            set { m_selected = value; }
        }

        public override string ToString()
        {
            return m_point.X + " : " + m_point.Y;
        }
    }
}
