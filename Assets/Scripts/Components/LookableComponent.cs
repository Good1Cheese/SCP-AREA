using System;
using UnityEngine;

namespace SCPAREA.Components
{
    [Serializable]
    public struct LookableComponent
    {
        [SerializeField] private float _rotationMultiplier;

        public float RotationMultiplier { get => _rotationMultiplier; }

        public Vector2 Input { get; set; }
        public Transform Head { get; set; }
        public Transform Body { get; set; }
    }
}