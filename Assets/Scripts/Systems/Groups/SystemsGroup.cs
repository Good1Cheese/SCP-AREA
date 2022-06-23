using Leopotam.Ecs;
using Zenject;

namespace SCPAREA.Systems.Groups
{
    public abstract class SystemsGroup<T>
    {
        protected readonly EcsSystems _systems;

        public SystemsGroup(EcsSystems ecsSystems)
        {
            _systems = ecsSystems;
        }

        public abstract void Add();

        public class Factory : PlaceholderFactory<T> { }
    }
}