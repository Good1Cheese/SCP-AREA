using SCPAREA.Systems.Groups;
using Zenject;

namespace SCPAREA.Installers
{
    public class SystemsGroupFactoriesInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindFactory<MovementSystems, MovementSystems.Factory>()
                .AsSingle();

            Container.BindFactory<LookSystems, LookSystems.Factory>()
                .AsSingle();
        }
    }
}