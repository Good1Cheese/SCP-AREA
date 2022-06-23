using SCPAREA.Components;
using UnityEngine.InputSystem;

namespace SCPAREA.Systems
{
    public class SneakSystem : MoveTypeSystem
    {
        public override InputAction InputAction => _contols.Main.Sneak;

        public override float GetSpeed(SpeedComponent speed) => speed.Sneak;
    }
}