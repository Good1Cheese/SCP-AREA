using Leopotam.Ecs;
using SCPAREA.Components;
using UnityEngine;

namespace SCPAREA.Systems
{
    public class SmoothSpeedSystem : IEcsRunSystem
    {
        private readonly EcsFilter<SpeedComponent, SpeedSmoothComponent> _ecsFilter;

        public void Run()
        {
            foreach (int i in _ecsFilter)
            {
                ref SpeedComponent speed = ref _ecsFilter.Get1(i);
                ref SpeedSmoothComponent speedSmooth = ref _ecsFilter.Get2(i);

                speed.Current = Mathf.SmoothDamp(speed.Current,
                                                 speed.Target,
                                                 ref speed.velocity,
                                                 speedSmooth.Target);
                Debug.Log(speed.Current);
            }
        }
    }
}