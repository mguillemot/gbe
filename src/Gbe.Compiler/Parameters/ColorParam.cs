using Gbe.Engine;

namespace Gbe.Compiler.Parameters
{
    public class ColorParam : Param
    {
        private readonly Color _color;

        public ColorParam(string colorRepr)
        {
            _color = Color.Parse(colorRepr);
        }

        public Color Color
        {
            get { return _color; }
        }

        public override void Set(Entity engineEntity)
        {
            engineEntity.Color = _color;
        }
    }
}
