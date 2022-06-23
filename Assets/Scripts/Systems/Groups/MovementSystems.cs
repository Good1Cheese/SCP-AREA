using Leopotam.Ecs;

namespace SCPAREA.Systems.Groups
{
    public class MovementSystems : SystemsGroup<MovementSystems>
    {
        public MovementSystems(EcsSystems ecsSystems)
            : base(ecsSystems)
        {
        }

        public override void Add()
        {
            _systems.Add(new MovementInputGetSystem());
            _systems.Add(new TargetSpeedGetSystem());
            _systems.Add(new RunSystem());
            _systems.Add(new SneakSystem());
            _systems.Add(new SmoothSpeedSystem());
            _systems.Add(new MoveSystem());
        }
    }
}