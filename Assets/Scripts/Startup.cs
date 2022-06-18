using Leopotam.Ecs;
using UnityEngine;
using Zenject;

namespace SCPAREA
{
    public class Startup : MonoBehaviour
    {
        private EcsWorld _world;
        private EcsSystems _systems;
        private PlayerInit.Factory _playerFactory;

        [Inject]
        public void Construct(EcsWorld ecsWorld, EcsSystems ecsSystems, PlayerInit.Factory playerFactory)
        {
            _world = ecsWorld;
            _systems = ecsSystems;
            _playerFactory = playerFactory;
        }

        private void Awake()
        {
            PlayerInit playerInit = _playerFactory.Create();
            playerInit.Init();
        }

        private void Start()
        {
            _systems.Init();
        }

        private void Update()
        {
            _systems.Run();
        }

        private void OnDestroy()
        {
            _world.Destroy();
            _systems.Destroy();
        }
    }
}