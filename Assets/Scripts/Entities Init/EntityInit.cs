using Leopotam.Ecs;
using SCPAREA;
using Zenject;

public abstract class EntityInit<T>
{
    protected readonly EcsWorld _world;
    protected readonly EcsSystems _systems;

    public EntityInit(EcsWorld ecsWorld, EcsSystems ecsSystems)
    {
        _world = ecsWorld;
        _systems = ecsSystems;
    }

    public void Init()
    {
        InstantiateGameObject();

        if (!_world.HasEntity(GetType()))
        {
            AddSystems();
        }

        AddComponents();
    }

    protected abstract void InstantiateGameObject();
    protected abstract void AddSystems();
    protected abstract void AddComponents();

    public class Factory : PlaceholderFactory<T> { }
}