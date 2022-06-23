using Leopotam.Ecs;
using UnityEngine;
using Zenject;

namespace SCPAREA.Components.Groups
{
    public abstract class ComponentsGroup<T>
    {
        public abstract void Add(in EcsEntity playerEntity, GameObject gameObject);

        public class Factory : PlaceholderFactory<T> { }
    }
}