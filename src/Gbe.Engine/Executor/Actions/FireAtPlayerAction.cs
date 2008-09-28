using Gbe.Engine.Entities;
using Gbe.Engine.Executor.Rules;

namespace Gbe.Engine.Executor.Actions
{
    public class FireAtPlayerAction : ExecutorAction
    {
        private readonly float _bulletSpeed;
        private readonly float _initialAngle;

        public FireAtPlayerAction(float bulletSpeed, float initialAngle)
        {
            _bulletSpeed = bulletSpeed;
            _initialAngle = initialAngle;
        }

        public override void Execute(Entity entity, Engine engine)
        {
            /*
            var playerPosition = engine.GetPlayer().Position;
            var bullet = new BulletEntity(engine.GenerateId()) {Position = entity.Position, Speed = _bulletSpeed};
            engine.AddEntity(bullet);
            engine.Executor.AddPermanentRule(bullet,
                                             new LinearTrajectoryRule(MathHelper.GetAngleBetween(bullet.Position,
                                                                                                 playerPosition) + _initialAngle));
            engine.Executor.AddPermanentRule(bullet, new DieWhenOutOfBoundsRule());
            */
            var trackingBullet = new TrackingBulletEntity(engine.GenerateId())
                                     {
                                         Position = entity.Position,
                                         Speed = _bulletSpeed
                                     };
            engine.AddEntity(trackingBullet);
            engine.Executor.AddPermanentRule(trackingBullet, new TrackingTrajectoryRule(engine.GetPlayer().Id, _initialAngle));
            engine.Executor.AddPermanentRule(trackingBullet, new DieWhenOutOfBoundsRule());
        }
    }
}