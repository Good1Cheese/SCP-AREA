using SCPAREA.Components;
using UnityEngine;

namespace SCPAREA.ScriptableObjects
{
    [CreateAssetMenu(fileName = "new Player_SO", menuName = "Player ScriptableObject")]
    public class Player_SO : ScriptableObject
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private Vector3 _startPosition;
        [SerializeField] private Quaternion _startRotation;

        [SerializeField] private MoveableComponent _moveableComponent;
        [SerializeField] private LookableComponent _lookableComponent;
        [SerializeField] private SpeedComponent _speedComponent;
        [SerializeField] private SpeedSmoothComponent _speedSmoothComponent;

        public GameObject Prefab => _prefab;
        public Vector3 StartPosition => _startPosition;
        public Quaternion StartRotation => _startRotation;
        public MoveableComponent MoveableComponent { get => _moveableComponent; }
        public LookableComponent LookableComponent { get => _lookableComponent; }
        public SpeedComponent SpeedComponent { get => _speedComponent; }
        public SpeedSmoothComponent SpeedSmoothComponent { get => _speedSmoothComponent; }
    }
}