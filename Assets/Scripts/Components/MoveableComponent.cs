using System;
using UnityEngine;

namespace SCPAREA.Components
{
    [Serializable]
    public struct MoveableComponent
    {
        [SerializeField] private float _speed;

        public float Speed => _speed;

        public CharacterController CharacterController { get; set; }
    }
}