using System.Collections.Generic;

namespace Gbe.Engine.Entities
{
    public class TrackingBulletEntity : Entity
    {
        public TrackingBulletEntity(int _id)
            : base(_id)
        {
            EntityProperties.SetPosition(this, new Point2());
            EntityProperties.SetSpeed(this, 0f);
            EntityProperties.SetAnimation(this, "trainee");
            EntityProperties.SetTrainee(this, new List<Point2>());
        }



        public override Point2 Position
        {
            get { return base.Position; }
            set
            {
                base.Position = value;
                var positions = EntityProperties.GetTrainee(this);
                positions.Add(value);
            }
        }
    }
}
