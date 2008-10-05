namespace Gbe.Engine.Entities
{
    public class BulletEntity : Entity
    {
        public BulletEntity(int _id)
            : base(_id)
        {
            EntityProperties.SetPosition(this, new Point2());
            EntityProperties.SetSpeed(this, 0f);
            EntityProperties.SetAnimation(this, "circle");
        }
    }
}