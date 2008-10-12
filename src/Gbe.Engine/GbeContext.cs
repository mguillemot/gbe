using System.Collections.Generic;

namespace Gbe.Engine
{
    public class GbeContext
    {
        private readonly List<string> m_raisedEvents = new List<string>();

        public int CurrentFrame { get; set; }

        public Rectangle GameArea { get; set; }

        public float TotalElapsedSeconds { get; set; }

        public float PreviousUpdateElapsedSeconds { get; set; }

        public List<string> RaisedEvents
        {
            get { return m_raisedEvents; }
        }

        public Dictionary<int, Gear> Gears { get; set; }
    }
}