using System.Collections.Generic;

namespace Gbe.Engine.GearLibrary
{
    public class TrackingBulletGear : Gear
    {
        public TrackingBulletGear(int _id)
            : base(_id)
        {
            GearProperties.SetPosition(this, new Point2());
            GearProperties.SetSpeed(this, 0f);
            GearProperties.SetAnimation(this, "trainee");
            GearProperties.SetTrainee(this, new List<Point2>());
        }



        public override Point2 Position
        {
            get { return base.Position; }
            set
            {
                base.Position = value;
                var positions = GearProperties.GetTrainee(this);
                positions.Add(value);
            }
        }
    }
}
