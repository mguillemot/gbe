using System.Collections.Generic;

namespace Gbe.Engine
{
    public class Entity
    {
        private readonly int _id;
        private readonly Dictionary<string, object> _properties = new Dictionary<string, object>();

        public Entity(int _id)
        {
            this._id = _id;
        }

        public int Id
        {
            get { return _id; }
        }

        public object this[string property]
        {
            get { return _properties[property]; }
            set { _properties[property] = value; }
        }

        public virtual Point2 Position
        {
            get { return EntityProperties.GetPosition(this); }
            set { EntityProperties.SetPosition(this, value); }
        }

        public float Speed
        {
            get { return EntityProperties.GetSpeed(this); }
            set { EntityProperties.SetSpeed(this, value); }
        }

        public string Animation
        {
            get { return EntityProperties.GetAnimation(this); }
            set { EntityProperties.SetAnimation(this, value); }
        }

        public Color Color
        {
            get { return EntityProperties.GetColor(this); }
            set { EntityProperties.SetColor(this, value); }
        }

        public bool HasProperty(string propertyName)
        {
            return _properties.ContainsKey(propertyName);
        }

        //public abstract EntityState ExtractState();

        //public abstract void RestoreState(EntityState state);
    }
}