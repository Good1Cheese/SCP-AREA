using Leopotam.Ecs;
using SCPAREA.ScriptableObjects;
using UnityEngine;

namespace SCPAREA.Components.Groups
{
    public class LookComponents : ComponentsGroup<LookComponents>
    {
        private readonly Player_SO _player_SO;

        public LookComponents(Player_SO player_SO)
        {
            _player_SO = player_SO;
        }

        public override void Add(in EcsEntity playerEntity, GameObject gameObject)
        {
            var lookable = _player_SO.LookableComponent;
            lookable.Body = gameObject.transform;
            lookable.Head = gameObject.GetComponentInChildren<Camera>().transform.parent;

            playerEntity.Add(lookable);
        }
    }
}