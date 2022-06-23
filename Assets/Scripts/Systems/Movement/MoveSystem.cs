using Leopotam.Ecs;
using SCPAREA.Components;
using UnityEngine;

namespace SCPAREA.Systems
{
    public class MoveSystem : IEcsRunSystem
    {
        private const float MOVE_MAGNUTUDE_MAX_LENGHT = 1.6f;

        private readonly EcsFilter<MoveableComponent, LookableComponent, SpeedComponent> _ecsFilter;

        public void Run()
        {
            foreach (int i in _ecsFilter)
            {
                ref MoveableComponent moveable = ref _ecsFilter.Get1(i);
                ref LookableComponent lookable = ref _ecsFilter.Get2(i);
                ref SpeedComponent speed = ref _ecsFilter.Get3(i);

                Vector2 move = GetMove(moveable, speed);

                moveable.Move = ConvertInputToVector3(move, lookable.Head);
                moveable.Move = Vector3.ClampMagnitude(moveable.Move, MOVE_MAGNUTUDE_MAX_LENGHT);

                moveable.CharacterController.Move(moveable.Move);
            }
        }

        private Vector2 GetMove(MoveableComponent moveable, SpeedComponent speed)
        {
            return Time.deltaTime * speed.Current * moveable.NotNullInput;
        }

        private Vector3 ConvertInputToVector3(in Vector2 input, Transform Head)
        {
            Vector3 result = input.x * Head.right + input.y * Head.forward;
            result.y = 0;

            return result;
        }
    }
}