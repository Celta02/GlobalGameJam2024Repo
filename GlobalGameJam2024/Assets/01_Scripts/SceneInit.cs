using CeltaGames.ScriptableObjects;
using UnityEngine;

namespace CeltaGames
{
    public class SceneInit : MonoBehaviour
    {
        [SerializeField] PlayerPosition _playerPosition;
        
        [Space,Header("Initialization Values")]
        [Tooltip("Initial cell value for the player (must be a valid cell number)")]
        [Range(1,10)]
        [SerializeField] int _initialPlayerPosition = 1;

        void Start()
        {
            _playerPosition.Move(_initialPlayerPosition);
        }
    }
}