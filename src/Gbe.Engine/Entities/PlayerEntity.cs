namespace Gbe.Engine.Entities
{
    public class PlayerEntity : Entity
    {
        public PlayerEntity(int _id)
            : base(_id)
        {
            Position = new Point2();
            Speed = 0;
            Animation = "triangle";
        }
    }
}