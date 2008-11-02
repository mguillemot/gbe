using System.Collections.Generic;

namespace Gbe.Engine
{
    public class Gear
    {
        private readonly int _id;
        private readonly Dictionary<string, object> _properties = new Dictionary<string, object>();

        public Gear(int _id)
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
            get { return GearProperties.GetPosition(this); }
            set { GearProperties.SetPosition(this, value); }
        }

        public float Speed
        {
            get { return GearProperties.GetSpeed(this); }
            set { GearProperties.SetSpeed(this, value); }
        }

        public string Animation
        {
            get { return GearProperties.GetAnimation(this); }
            set { GearProperties.SetAnimation(this, value); }
        }

        public Color Color
        {
            get { return GearProperties.GetColor(this); }
            set { GearProperties.SetColor(this, value); }
        }

        public float Direction
        {
            get { return GearProperties.GetDirection(this); }
            set { GearProperties.SetDirection(this, value); }
        }

        public bool HasProperty(string propertyName)
        {
            return _properties.ContainsKey(propertyName);
        }

        //public abstract EntityState ExtractState();

        //public abstract void RestoreState(EntityState state);
    }
}