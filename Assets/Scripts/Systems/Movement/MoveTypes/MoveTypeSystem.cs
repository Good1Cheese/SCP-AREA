using Leopotam.Ecs;
using SCPAREA.Components;
using UnityEngine.InputSystem;

namespace SCPAREA.Systems
{
    public abstract class MoveTypeSystem : IEcsRunSystem
    {
        protected readonly EcsFilter<MoveableComponent, SpeedComponent> _ecsFilter;
        protected readonly PlayerContols _contols;

        public abstract InputAction InputAction { get; }
        public abstract float GetSpeed(SpeedComponent speed);

        public void Run()
        {
            foreach (int i in _ecsFilter)
            {
                ref MoveableComponent moveable = ref _ecsFilter.Get1(i);

                if (!InputAction.IsPressed() || !Player.IsMoving(moveable)) { return; }

                ref SpeedComponent speed = ref _ecsFilter.Get2(i);

                speed.Target = GetSpeed(speed);
            }
        }
    }
}