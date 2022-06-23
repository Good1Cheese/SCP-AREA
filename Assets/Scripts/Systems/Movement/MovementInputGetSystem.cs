using Leopotam.Ecs;
using SCPAREA.Components;
using UnityEngine;

namespace SCPAREA.Systems
{
    public class MovementInputGetSystem : IEcsRunSystem
    {
        private readonly EcsFilter<MoveableComponent> _ecsFilter;
        private readonly PlayerContols _contols;

        public void Run()
        {
            foreach (int i in _ecsFilter)
            {
                ref MoveableComponent moveable = ref _ecsFilter.Get1(i);

                Vector2 input = _contols.Main.Movement.ReadValue<Vector2>();

                moveable.Input = input;

                if (input.sqrMagnitude > 0)
                {
                    moveable.NotNullInput = input;
                }
            }
        }
    }
}