using Leopotam.Ecs;
using SCPAREA;
using SCPAREA.ScriptableObjects;
using UnityEngine;
using Zenject;

namespace SCPAREA.Installers
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private Player_SO _player_SO;

        public override void InstallBindings()
        {
            Container.BindInstance(_player_SO)
                .AsSingle();

            Container.BindFactory<PlayerInit, PlayerInit.Factory>()
                .AsSingle();

            Container.BindInstance(new PlayerContols())
                .AsSingle();
        }
    }
}