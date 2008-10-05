namespace Gbe.Compiler.Actions
{
    public class FireAtPlayerAction : Action
    {
        private readonly string _bullet;

        public FireAtPlayerAction(string target, string bullet) : base(target)
        {
            _bullet = bullet;
        }

        public string Bullet
        {
            get { return _bullet; }
        }
    }
}
