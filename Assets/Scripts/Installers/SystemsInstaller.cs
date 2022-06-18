using SCPAREA.SystemsListAdders;
using Zenject;

namespace SCPAREA.Installers
{
    public class SystemsInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindFactory<MovementSystemsAdd, MovementSystemsAdd.Factory>()
                .AsSingle();

            Container.BindFactory<LookSystemsAdd, LookSystemsAdd.Factory>()
                .AsSingle();
        }
    }
}