using Gbe.Engine;

namespace Gbe.Compiler.Parameters
{
    public class GameAreaParam : Param
    {
        private Rectangle _area;

        public GameAreaParam(string areaRepr)
        {
            _area = Rectangle.Parse(areaRepr);
        }

        public Rectangle Area
        {
            get { return _area; }
        }

        public override void Set(Entity engineEntity)
        {
            throw new System.NotImplementedException();
        }
    }
}
