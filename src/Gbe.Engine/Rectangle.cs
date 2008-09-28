namespace Gbe.Engine
{
    public struct Rectangle
    {
        public Point2 BottomRightCorner;
        public Point2 TopLeftCorner;

        public Rectangle(Point2 topLeftCorner, Point2 bottomRightCorner)
        {
            TopLeftCorner = topLeftCorner;
            BottomRightCorner = bottomRightCorner;
        }

        public Rectangle(float x1, float y1, float x2, float y2)
        {
            TopLeftCorner = new Point2(x1, y1);
            BottomRightCorner = new Point2(x2, y2);
        }
    }
}