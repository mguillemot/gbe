using System.Collections.Generic;
using Gbe.Engine.Executor;

namespace Gbe.Engine
{
    public class Gbe
    {
        private readonly GbeContext m_context = new GbeContext();
        private readonly Dictionary<int, Gear> m_gearsById = new Dictionary<int, Gear>();
        private readonly Executor.Executor m_executor = new Executor.Executor();
        private readonly PlayField m_playField = new PlayField();
        private int m_nextId;
        private int m_playerEntityId = -1;

        public int Fps { get; set; }

        public PlayField PlayField
        {
            get { return m_playField; }
        }

        public Executor.Executor Executor
        {
            get { return m_executor; }
        }

        public GbeContext Context
        {
            get { return m_context; }
        }

        public ICollection<Gear> Gears
        {
            get { return m_gearsById.Values; }
        }

        public Gear GetGear(int id)
        {
            Gear gear;
            if (m_gearsById.TryGetValue(id, out gear))
            {
                return gear;
            }
            return null;
        }

        public void AddPlayer(Gear gear)
        {
            m_playerEntityId = gear.Id;
            AddGear(gear);
        }

        public void AddGear(Gear gear)
        {
            m_gearsById.Add(gear.Id, gear);
        }

        public void RemoveGear(Gear gear)
        {
            if (m_gearsById.Remove(gear.Id))
            {
                m_executor.RemoveAllRulesFor(gear.Id);
            }
        }

        public int GenerateId()
        {
            return m_nextId++;
        }

        public void Update(float elapsedTime)
        {
            m_context.CurrentFrame++;
            m_context.PreviousUpdateElapsedSeconds = elapsedTime;
            m_context.TotalElapsedSeconds += elapsedTime;
            m_context.Gears = m_gearsById;
            var actionsByEntity = new Dictionary<Gear, List<ExecutorAction>>(m_gearsById.Count);
            foreach (var entity in m_gearsById.Values)
            {
                List<ExecutorAction> actions = m_executor.ComputeActions(entity, m_context);
                actionsByEntity.Add(entity, actions);
            }
            foreach (var pair in actionsByEntity)
            {
                if (pair.Value != null)
                {
                    foreach (var action in pair.Value)
                    {
                        action.Execute(pair.Key, this);
                    }
                }
            }
        }

        public Gear GetPlayer()
        {
            return m_gearsById[m_playerEntityId];
        }
    }
}