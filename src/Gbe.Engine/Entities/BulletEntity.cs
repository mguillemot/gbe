namespace Gbe.Engine.Entities
{
    public class BulletEntity : Entity
    {
        public BulletEntity(int _id)
            : base(_id)
        {
            Position = new Point2();
            Speed = 0;
            Animation = "circle";
        }
    }
}