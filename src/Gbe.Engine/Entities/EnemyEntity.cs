namespace Gbe.Engine.Entities
{
    public class EnemyEntity : Entity
    {
        public EnemyEntity(int _id)
            : base(_id)
        {
            Position = new Point2();
            Speed = 0;
            Animation = "box";
        }
    }
}