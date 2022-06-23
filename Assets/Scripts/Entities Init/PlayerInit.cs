using Leopotam.Ecs;
using SCPAREA.Components.Groups;
using SCPAREA.ScriptableObjects;
using SCPAREA.Systems;
using SCPAREA.Systems.Groups;
using UnityEngine;
using Zenject;

public class PlayerInit : EntityInit<PlayerInit>
{
    private GameObject _gameObject;
    private readonly Player_SO _player_SO;
    private readonly EcsEntity _playerEntity;
    
    private MovementComponents _movementComponents;
    private LookComponents _lookComponents;

    private MovementSystems _movementSystems;
    private LookSystems _lookSystems;

    public PlayerInit(EcsSystems ecsSystems, EcsWorld ecsWorld, Player_SO player_SO)
        : base(ecsWorld, ecsSystems)
    {
        _player_SO = player_SO;
        _playerEntity = _world.NewEntity();
    }

    [Inject]
    public void GetSystemsGroupsFactories(MovementSystems.Factory movementSystemsFactory, LookSystems.Factory lookSystemsFactory)
    {
        _movementSystems = movementSystemsFactory.Create();
        _lookSystems = lookSystemsFactory.Create();
    }

    [Inject]
    public void GetComponentsGroupsFactories(MovementComponents.Factory movementComponentsFactory, LookComponents.Factory lookComponentsFactory)
    {
        _movementComponents = movementComponentsFactory.Create();
        _lookComponents = lookComponentsFactory.Create();
    }

    protected override void InstantiateGameObject()
    {
        _gameObject = Object.Instantiate(_player_SO.Prefab, _player_SO.StartPosition, _player_SO.StartRotation);
    }

    protected override void AddSystems()
    {
        _systems.Add(new InputSystem());

        _movementSystems.Add();
        _lookSystems.Add();
    }

    protected override void AddComponents()
    {
        _movementComponents.Add(_playerEntity, _gameObject);
        _lookComponents.Add(_playerEntity, _gameObject);
    }
}