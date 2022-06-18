using Leopotam.Ecs;
using SCPAREA.Systems;

namespace SCPAREA.SystemsListAdders
{
    public class LookSystemsAdd : SystemsListAdd<LookSystemsAdd>
    {
        public LookSystemsAdd(EcsSystems ecsSystems)
            : base(ecsSystems)
        {
        }

        public override void Add()
        {
            _systems.Add(new LookSystem());
        }
    }
}
