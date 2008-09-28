using System.Collections.Generic;

namespace Gbe.Engine
{
    public class GameContext
    {
        public int CurrentFrame { get; set; }

        public Rectangle GameArea { get; set; }

        public float TotalElapsedSeconds { get; set; }

        public float PreviousUpdateElapsedSeconds { get; set; }

        public Dictionary<int, Entity> Entities { get; set; }
    }
}