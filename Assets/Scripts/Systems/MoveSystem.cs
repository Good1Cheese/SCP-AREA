using Leopotam.Ecs;
using SCPAREA.Components;
using UnityEngine;

namespace SCPAREA.Systems
{
    public class MoveSystem : IEcsRunSystem
    {
        private const float MOVE_MAGNUTUDE_MAX_LENGHT = 1.6f;

        private Vector3 _move = new();

        private readonly EcsFilter<MoveableComponent, LookableComponent> _ecsFilter;
        private readonly PlayerContols _contols;

        public void Run()
        {
            foreach (int i in _ecsFilter)
            {
                ref MoveableComponent moveable = ref _ecsFilter.Get1(i);
                ref LookableComponent lookable = ref _ecsFilter.Get2(i);

                Vector2 input = _contols.Main.Movement.ReadValue<Vector2>();
                input *= Time.deltaTime * moveable.Speed;

                _move = ConvertInputToVector3(input, lookable.Head);
                _move = Vector3.ClampMagnitude(_move, MOVE_MAGNUTUDE_MAX_LENGHT);

                moveable.CharacterController.Move(_move);
            }
        }

        private Vector3 ConvertInputToVector3(in Vector2 input, Transform Head)
        {
           return input.x * Head.right + input.y * Head.forward;
        }
    }
}