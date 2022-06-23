using SCPAREA.Components.Groups;
using Zenject;

namespace SCPAREA.Installers
{
    public class ComponentsGroupFactoriesInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindFactory<MovementComponents, MovementComponents.Factory>()
                .AsSingle();

            Container.BindFactory<LookComponents, LookComponents.Factory>()
                .AsSingle();
        }
    }
}