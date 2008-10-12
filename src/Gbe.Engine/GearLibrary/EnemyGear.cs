namespace Gbe.Engine.GearLibrary
{
    public class EnemyGear : Gear
    {
        public EnemyGear(int _id)
            : base(_id)
        {
            GearProperties.SetPosition(this, new Point2());
            GearProperties.SetSpeed(this, 0f);
            GearProperties.SetAnimation(this, "box");
        }
    }
}