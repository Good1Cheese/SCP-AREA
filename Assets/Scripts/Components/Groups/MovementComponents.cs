using Leopotam.Ecs;
using SCPAREA.ScriptableObjects;
using UnityEngine;

namespace SCPAREA.Components.Groups
{
    public class MovementComponents : ComponentsGroup<MovementComponents>
    {
        private readonly Player_SO _player_SO;

        public MovementComponents(Player_SO player_SO)
        {
            _player_SO = player_SO;
        }

        public override void Add(in EcsEntity playerEntity, GameObject gameObject)
        {
            var moveable = _player_SO.MoveableComponent;
            moveable.CharacterController = gameObject.GetComponent<CharacterController>();
            playerEntity.Add(moveable);

            playerEntity.Add(_player_SO.SpeedComponent);
            playerEntity.Add(_player_SO.SpeedSmoothComponent);
        }
    }
}