using SCPAREA.Components;
using UnityEngine.InputSystem;

namespace SCPAREA.Systems
{
    public class RunSystem : MoveTypeSystem
    {
        public override InputAction InputAction => _contols.Main.Run;

        public override float GetSpeed(SpeedComponent speed) => speed.Run;
    }
}