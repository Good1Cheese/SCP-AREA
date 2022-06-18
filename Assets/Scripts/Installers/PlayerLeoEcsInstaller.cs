using Leopotam.Ecs;
using SCPAREA.ScriptableObjects;
using Zenject;

namespace SCPAREA.Installers
{
    public class PlayerLeoEcsInstaller : MonoInstaller
    {
        private EcsSystems _systems;
        private PlayerContols _playerControls;
        private Player_SO _player_SO;

        [Inject]
        public void Construct(EcsSystems ecsSystems, PlayerContols playerControls, Player_SO player_SO)
        {
            _systems = ecsSystems;
            _playerControls = playerControls;
            _player_SO = player_SO;
        }

        public override void InstallBindings()
        {
            _systems.Inject(_playerControls);
            _systems.Inject(_player_SO);
        }
    }
}