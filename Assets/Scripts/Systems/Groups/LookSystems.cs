using Leopotam.Ecs;
using SCPAREA.Systems;

namespace SCPAREA.Systems.Groups
{
    public class LookSystems : SystemsGroup<LookSystems>
    {
        public LookSystems(EcsSystems ecsSystems)
            : base(ecsSystems)
        {
        }

        public override void Add()
        {
            _systems.Add(new LookSystem());
        }
    }
}
