using System;
using UnityEngine;

namespace SCPAREA.Components
{
    [Serializable]
    public struct MoveableComponent
    {
        public Vector3 Move { get; set; }
        public Vector2 NotNullInput { get; set; }
        public Vector2 Input { get; set; }
        public CharacterController CharacterController { get; set; }
    }
}