using Leopotam.Ecs;
using SCPAREA.Systems;

namespace SCPAREA.SystemsListAdders
{
    public class MovementSystemsAdd : SystemsListAdd<MovementSystemsAdd>
    {
        public MovementSystemsAdd(EcsSystems ecsSystems)
            : base(ecsSystems)
        {
        }

        public override void Add()
        {
            _systems.Add(new MoveSystem());
        }
    }
}