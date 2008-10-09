using System.Collections.Generic;

namespace Gbe.Engine
{
    public class GameContext
    {
        private readonly List<string> _raisedEvents = new List<string>();

        public int CurrentFrame { get; set; }

        public Rectangle GameArea { get; set; }

        public float TotalElapsedSeconds { get; set; }

        public float PreviousUpdateElapsedSeconds { get; set; }

        public List<string> RaisedEvents
        {
            get { return _raisedEvents;  }
        }

        public Dictionary<int, Entity> Entities { get; set; }
    }
}