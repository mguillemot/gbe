using Gbe.Engine;

namespace Gbe.Script.Parameters
{
    public class ColorParam : Param
    {
        private readonly Color m_color;

        public ColorParam(string colorRepr)
        {
            m_color = Color.Parse(colorRepr);
        }

        public override void Execute(Gear gear)
        {
            gear.Color = m_color;
        }
    }
}