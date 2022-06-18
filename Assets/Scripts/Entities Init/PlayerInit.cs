using Leopotam.Ecs;
using SCPAREA.Components;
using SCPAREA.Systems;
using SCPAREA.SystemsListAdders;
using SCPAREA.ScriptableObjects;
using UnityEngine;

namespace SCPAREA
{
    public class PlayerInit : EntityInit<PlayerInit>
    {
        private GameObject _gameObject;
        private readonly Player_SO _player_SO;
        private readonly MovementSystemsAdd _movementSystems;
        private readonly LookSystemsAdd _lookSystems;

        public PlayerInit(EcsSystems ecsSystems, EcsWorld ecsWorld, Player_SO player_SO, MovementSystemsAdd.Factory movementSystemsFactory, LookSystemsAdd.Factory lookSystemsFactory)
            : base(ecsWorld, ecsSystems)
        {
            _player_SO = player_SO;

            _movementSystems = movementSystemsFactory.Create();
            _lookSystems = lookSystemsFactory.Create();
        }

        protected override void AddSystems()
        {
            _systems.Add(new InputSystem());

            _movementSystems.Add();
            _lookSystems.Add();
        }

        protected override void InstantiateGameObject()
        {
            _gameObject = Object.Instantiate(_player_SO.Prefab,
                                             _player_SO.StartPosition,
                                             _player_SO.StartRotation);
        }

        protected override void AddComponents()
        {
            EcsEntity playerEntity = _world.NewEntity();

            var moveable = _player_SO.MoveableComponent;
            moveable.CharacterController = _gameObject.GetComponent<CharacterController>();
            playerEntity.Add(moveable);

            var lookable = _player_SO.LookableComponent;
            lookable.Body = _gameObject.transform;
            lookable.Head = _gameObject.GetComponentInChildren<Camera>().transform.parent;
            playerEntity.Add(lookable);
        }
    }
}