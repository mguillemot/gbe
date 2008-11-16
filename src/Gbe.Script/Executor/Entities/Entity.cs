using System;
using Gbe.Engine;
using Gbe.Script.Classdefs;
using Gbe.Script.Shapes;

namespace Gbe.Script.Executor.Entities
{
    public abstract class Entity
    {
        private readonly Classdef m_classdef;
        private readonly string m_name;

        protected Entity(Classdef classdef, string name)
        {
            m_classdef = classdef;
            m_name = name;
        }

        public Classdef Classdef
        {
            get { return m_classdef; }
        }

        public string Name
        {
            get { return m_name; }
        }

        public virtual Gear Gear
        {
            get { return null; }
        }

        public virtual void Update(float deltaTime)
        {
        }

        public virtual void AddState(GbsExecutor scriptExecutor, StateEntity stateEntity)
        {
            throw new NotImplementedException();
        }

        public virtual void RemoveState(GbsExecutor scriptExecutor, StateEntity stateEntity)
        {
            throw new NotImplementedException();
        }

        public virtual StateEntity GetState(StateClassdef stateClass)
        {
            throw new NotImplementedException();
        }

        public virtual void Die(GbsExecutor scriptExecutor)
        {
            throw new NotImplementedException();
        }

        public virtual float GetVariable(string variableName)
        {
            throw new NotImplementedException();
        }

        public virtual void SetVariable(string variableName, float value)
        {
            throw new NotImplementedException();
        }

        public virtual void SetTrajectory(Shape trajectory)
        {
            throw new NotImplementedException();
        }

        public virtual Shape GetTrajectory()
        {
            throw new NotImplementedException();
        }
    }
}