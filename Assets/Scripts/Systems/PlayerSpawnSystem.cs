using UnityEngine;
using Leopotam.Ecs;

public class PlayerSpawnSystem : IEcsPreInitSystem
{
    private Player_SO _player_SO;

    public GameObject SpawnedPlayer { get; private set; }

    public void PreInit()
    {
        SpawnedPlayer = Object.Instantiate(_player_SO.Prefab, _player_SO.StartPosition, _player_SO.StartRotation);
    }
}