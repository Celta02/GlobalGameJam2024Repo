using System;
using UnityEngine;
using CeltaGames.ScriptableObjects;

namespace CeltaGames
{
    public class PlayerVisualMovement : MonoBehaviour
    {
        [SerializeField] PlayerGrid _playerGrid;
        [SerializeField] PlayerPosition _playerPosition;

        PositionListener _positionListener;

        void OnEnable() => _playerPosition.RegisterListener(_positionListener);
        void OnDisable() => _playerPosition.UnregisterListener(_positionListener);

        void Awake()
        {
            _positionListener = new PositionListener(UpdatePosition);
        }

        void Start()
        {
            UpdatePosition(_playerPosition.CurrentPosition);
        }

        void UpdatePosition(int newPos)
        {
            transform.position = _playerGrid.GetCellPosition(newPos);
        }
    }
}
