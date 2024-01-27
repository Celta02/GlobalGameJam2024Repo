using CeltaGames.ScriptableObjects;
using UnityEngine;

namespace CeltaGames
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] PlayerPosition _playerPosition;
        
        PlayerInput _controls;

        void OnEnable() => _controls.Enable();
        void OnDisable() => _controls.Disable();
        
        void Awake()
        {
            _controls = new PlayerInput();
        }

        void Start()
        {
            _controls.Player.Cell_1.started += x=> Move(1);
            _controls.Player.Cell_2.started += x=> Move(2);
            _controls.Player.Cell_3.started += x=> Move(3);
            _controls.Player.Cell_4.started += x=> Move(4);
        }

        void Move(int cellPosition)
        {
            _playerPosition.Move(cellPosition);
        }
    }
}