using Leopotam.Ecs;
using UnityEngine;

public class GameInit : MonoBehaviour
{
    [SerializeField] private Player_SO _player_SO;
    [SerializeField] private Transform _spawnPoint;

    public void Init(EcsSystems systems)
    {
        systems.Add(new PlayerInputSystem());
        systems.Add(new PlayerSpawnSystem());

        systems.Inject(_player_SO);
    }
}