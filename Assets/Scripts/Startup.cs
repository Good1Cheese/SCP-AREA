using Leopotam.Ecs;
using UnityEngine;

[RequireComponent(typeof(GameInit))]
public class Startup : MonoBehaviour
{
    private EcsWorld _world;
    private EcsSystems _systems;

    private GameInit _gameInit;

    private void Awake()
    {
        _world = new EcsWorld();
        _systems = new EcsSystems(_world);

        _gameInit = GetComponent<GameInit>();
        _gameInit.Init(_systems);
    }

    private void Start() => _systems?.Init();

    private void Update() => _systems?.Run();

    private void OnDestroy()
    {
        _world.Destroy();
        _systems.Destroy();
    }
}