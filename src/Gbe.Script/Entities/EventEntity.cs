namespace Gbe.Script.Entities
{
    public class EventEntity : Entity
    {
        public EventEntity(string className) : base(className, null, null)
        {
        }

        public override string EntityType
        {
            get { return "EVENT"; }
        }
    }
}
