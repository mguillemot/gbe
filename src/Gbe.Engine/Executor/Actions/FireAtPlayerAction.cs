using Gbe.Engine.GearLibrary;
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

        public override void Execute(Gear gear, Gbe gbe)
        {
            /*
            var playerPosition = gbe.GetPlayer().Position;
            var bullet = new BulletGear(gbe.GenerateId()) {Position = gear.Position, Speed = _bulletSpeed};
            gbe.AddGear(bullet);
            gbe.Executor.AddRule(bullet,
                                             new LinearTrajectoryRule(MathHelper.GetAngleBetween(bullet.Position,
                                                                                                 playerPosition) + _initialAngle));
            gbe.Executor.AddRule(bullet, new DieWhenOutOfBoundsRule());
            */
            var trackingBullet = new TrackingBulletGear(gbe.GenerateId())
                                     {
                                         Position = gear.Position,
                                         Speed = _bulletSpeed
                                     };
            gbe.AddGear(trackingBullet);
            gbe.Executor.AddRule(trackingBullet.Id, new TrackingTrajectoryRule(gbe.GetPlayer().Id, _initialAngle));
            gbe.Executor.AddRule(trackingBullet.Id, new DieWhenOutOfBoundsRule());
        }
    }
}