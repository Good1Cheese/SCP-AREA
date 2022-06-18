using Leopotam.Ecs;
using Zenject;

namespace SCPAREA.Installers
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            EcsWorld world = new();
            EcsSystems systems = new(world);

            Container.BindInstance(world)
                .AsSingle();

            Container.BindInstance(systems)
                .AsSingle();
        }
    }
}