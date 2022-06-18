using Leopotam.Ecs;

namespace SCPAREA.Systems
{
    public class InputSystem : IEcsPreInitSystem, IEcsDestroySystem
    {
        private readonly PlayerContols _controls;

        public void PreInit()
        {
            _controls.Enable();
        }

        public void Destroy()
        {
            _controls.Disable();
        }
    }
}