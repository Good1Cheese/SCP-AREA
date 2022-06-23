using System;
using UnityEngine;

namespace SCPAREA.Components
{
    [Serializable]
    public struct LookableComponent
    {
        [SerializeField] private float _rotationMultiplier;
        [SerializeField] private float _maxYRotationAngle;
        [SerializeField] private float _minYRotationAngle;

        public Transform Head { get; set; }
        public Transform Body { get; set; }
        public float YRotation { get; set; }

        public float RotationMultiplier => _rotationMultiplier;
        public float MaxYRotationAngle => _maxYRotationAngle;
        public float MinYRotationAngle => _minYRotationAngle;
    }
}