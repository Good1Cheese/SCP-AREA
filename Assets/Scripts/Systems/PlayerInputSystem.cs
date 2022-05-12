using Leopotam.Ecs;
using UnityEngine.InputSystem;

public class PlayerInputSystem : IEcsPreInitSystem, IEcsDestroySystem
{
    private PlayerContols _controls;

    public InputAction Movement => _controls.Main.Movement;
    public InputAction Mouse => _controls.Main.Mouse;

    public void PreInit()
    {
        _controls = new PlayerContols();

        _controls.Enable();
    }

    public void Destroy()
    {
        _controls.Disable();
    }
}