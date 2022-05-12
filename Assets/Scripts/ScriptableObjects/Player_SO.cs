using UnityEngine;

[CreateAssetMenu(fileName = "new Player_SO", menuName = "Player ScriptableObject")]
public class Player_SO : ScriptableObject
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private Quaternion _startRotation;

    public GameObject Prefab => _prefab;
    public Vector3 StartPosition => _startPosition;
    public Quaternion StartRotation => _startRotation;
}