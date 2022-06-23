using Leopotam.Ecs;
using SCPAREA.Components;
using UnityEngine;

namespace SCPAREA.Systems
{
    public class TargetSpeedGetSystem : IEcsRunSystem
    {
        private readonly EcsFilter<MoveableComponent, SpeedComponent, SpeedSmoothComponent> _ecsFilter;

        public void Run()
        {
            foreach (int i in _ecsFilter)
            {
                ref MoveableComponent moveable = ref _ecsFilter.Get1(i);
                ref SpeedComponent speed = ref _ecsFilter.Get2(i);
                ref SpeedSmoothComponent speedSmooth = ref _ecsFilter.Get3(i);

                bool isMoving = Player.IsMoving(moveable);

                speed.Target = GetTarget(isMoving, speed.Walk, speed.Min);
                speedSmooth.Target = GetTarget(isMoving, speedSmooth.WhileMove, speedSmooth.WhileStop);
            }
        }

        public float GetTarget(bool condition, float max, float min)
        {
            return condition ? max : min;
        }
    }
}