using System.Collections.Generic;

namespace Gbe.Engine
{
    public class Entity
    {
        private readonly int _id;
        private readonly Dictionary<string, object> _properties = new Dictionary<string, object>();

        protected Entity(int _id)
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
            get { return (Point2) this[EntityProperties.PROP_POSITION]; }
            set { this[EntityProperties.PROP_POSITION] = value; }
        }

        public float Speed
        {
            get { return (float) this[EntityProperties.PROP_SPEED]; }
            set { this[EntityProperties.PROP_SPEED] = value; }
        }

        public string Animation
        {
            get { return (string) this[EntityProperties.PROP_ANIMATION]; }
            set { this[EntityProperties.PROP_ANIMATION] = value; }
        }

        public bool HasProperty(string propertyName)
        {
            return _properties.ContainsKey(propertyName);
        }

        //public abstract EntityState ExtractState();

        //public abstract void RestoreState(EntityState state);
    }
}