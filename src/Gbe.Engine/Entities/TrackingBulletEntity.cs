using System.Collections.Generic;

namespace Gbe.Engine.Entities
{
    public class TrackingBulletEntity : Entity
    {
        public TrackingBulletEntity(int _id)
            : base(_id)
        {
            Speed = 0;
            Animation = "trainee";
            this[EntityProperties.PROP_TRAINEE] = new List<Point2>();
            Position = new Point2();
        }

        public override Point2 Position
        {
            get { return base.Position; }
            set
            {
                base.Position = value;
                var positions = (List<Point2>) this[EntityProperties.PROP_TRAINEE];
                positions.Add(value);
            }
        }
    }
}
