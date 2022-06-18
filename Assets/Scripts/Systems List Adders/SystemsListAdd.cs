using Leopotam.Ecs;
using Zenject;

namespace SCPAREA.SystemsListAdders
{
    public abstract class SystemsListAdd<T>
    {
        protected readonly EcsSystems _systems;

        public SystemsListAdd(EcsSystems ecsSystems)
        {
            _systems = ecsSystems;
        }

        public abstract void Add();

        public class Factory : PlaceholderFactory<T> { }
    }
}