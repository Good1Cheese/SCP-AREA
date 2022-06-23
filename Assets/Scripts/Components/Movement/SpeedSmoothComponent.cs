using System;
using UnityEngine;

namespace SCPAREA.Components
{
    [Serializable]
    public struct SpeedSmoothComponent
    {
        [SerializeField] private float _whileMove;
        [SerializeField] private float _whileStop;

        public float Target { get; set; }
        public float WhileMove => _whileMove;
        public float WhileStop => _whileStop;
    }
}