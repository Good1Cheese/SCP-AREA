using Leopotam.Ecs;
using SCPAREA.Components;
using UnityEngine;

namespace SCPAREA.Systems
{
    public class LookSystem : IEcsInitSystem, IEcsRunSystem
    {
        private readonly EcsFilter<LookableComponent> _ecsFilter;
        private readonly PlayerContols _contols;

        public void Init()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        public void Run()
        {
            foreach (int i in _ecsFilter)
            {
                ref LookableComponent lookable = ref _ecsFilter.Get1(i);

                var input = _contols.Main.Mouse.ReadValue<Vector2>();
                input *= Time.deltaTime * lookable.RotationMultiplier;

                lookable.YRotation += input.y;
                lookable.YRotation = Mathf.Clamp(lookable.YRotation, lookable.MinYRotationAngle, lookable.MaxYRotationAngle);
                Quaternion newRotation = Quaternion.Euler(lookable.YRotation, 0, 0);
                lookable.Head.localRotation = newRotation;

                lookable.Body.Rotate(0, input.x, 0);
            }
        }
    }
}