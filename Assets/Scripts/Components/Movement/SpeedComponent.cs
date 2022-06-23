using System;
using UnityEngine;

namespace SCPAREA.Components
{
    [Serializable]
    public struct SpeedComponent
    {
        [SerializeField] private float _sneak;
        [SerializeField] private float _walk;
        [SerializeField] private float _run;

        [NonSerialized] public float velocity;

        public float Current { get; set; }
        public float Target { get; set; }
        public float Sneak => _sneak;
        public float Walk => _walk;
        public float Run => _run;
        public float Min => 0;
    }
}