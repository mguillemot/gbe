using Gbe.Engine;

namespace Gbe.Script.Parameters
{
    public class FpsParam : Param
    {
        private readonly float m_fps;

        public FpsParam(float fps)
        {
            m_fps = fps;
        }

        public override void Execute(Gear gear)
        {
            // TODO
        }
    }
}