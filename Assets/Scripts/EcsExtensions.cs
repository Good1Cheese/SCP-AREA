using Leopotam.Ecs;
using SCPAREA.Components;
using System;
using System.Linq;

namespace SCPAREA
{
    public static class EcsExtensions
    {
        private static EcsEntity[] _entities;

        public static bool HasEntity(this EcsWorld ecsWorld, Type type)
        {
            ecsWorld.GetAllEntities(ref _entities);

            return _entities.Any(entity => entity.GetType() == type);
        }

        public static void Add<T>(this EcsEntity ecsEntity, T component) where T : struct
        {
            ref var newComponent = ref ecsEntity.Get<T>();
            newComponent = component;
        }
    }

    public static class Player
    {
        public static bool IsMoving(MoveableComponent moveable)
        {
            return moveable.Input.sqrMagnitude != 0;
        }
    }
}