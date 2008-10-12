namespace Gbe.Engine.GearLibrary
{
    public class BulletGear : Gear
    {
        public BulletGear(int _id)
            : base(_id)
        {
            GearProperties.SetPosition(this, new Point2());
            GearProperties.SetSpeed(this, 0f);
            GearProperties.SetAnimation(this, "circle");
        }
    }
}