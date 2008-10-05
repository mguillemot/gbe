namespace Gbe.Engine.Entities
{
    public class EnemyEntity : Entity
    {
        public EnemyEntity(int _id)
            : base(_id)
        {
            EntityProperties.SetPosition(this, new Point2());
            EntityProperties.SetSpeed(this, 0f);
            EntityProperties.SetAnimation(this, "box");
        }
    }
}