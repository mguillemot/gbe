using System.Collections.Generic;

namespace Gbe.Script.Formulas
{
    public class Range
    {
        private readonly float m_start;
        private readonly float m_end;

        public Range(float start, float end)
        {
            m_start = start;
            m_end = end;
        }

        public IEnumerable<float> EnumerateRange()
        {
            float cursor = m_start;
            while (cursor <= m_end)
            {
                yield return cursor;
                cursor += 1;
            }
        }
    }
}
