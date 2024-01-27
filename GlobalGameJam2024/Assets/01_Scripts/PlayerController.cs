using CeltaGames.ScriptableObjects;
using UnityEngine;
using UnityEngine.InputSystem;

namespace CeltaGames
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] PlayerHitEmitter _hitEmitter;
        [SerializeField] PlayerPosition _playerPosition;
        [SerializeField] PlayerGrid _playerGrid;
        [SerializeField] HitBoxQueue _hitBoxQueue;
        
        PlayerInput _controls;

        void OnEnable() => _controls.Enable();
        void OnDisable() => _controls.Disable();
        void Awake() => _controls = new PlayerInput();

        void Start()
        {
            _controls.Player.Hit.started += ctx => OnHit();
            _controls.Player.Cell_1.started += ctx=> Move(1);
            _controls.Player.Cell_2.started += ctx=> Move(2);
            _controls.Player.Cell_3.started += ctx=> Move(3);
            _controls.Player.Cell_4.started += ctx=> Move(4);
            _controls.Player.Cell_5.started += ctx=> Move(5);
        }

        void OnHit()
        {
            var cell =_playerGrid.GetCellAtPosition(_playerPosition.CurrentPosition);
            _hitEmitter.BroadcastHit(cell.Type == _hitBoxQueue.CurrentHitBoxType, cell.Type);
        }

        void Move(int cellPosition)
        {
            _playerPosition.Move(cellPosition);
        }
    }
}