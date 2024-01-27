using System.Collections.Generic;
using UnityEngine;

namespace CeltaGames.ScriptableObjects
{
    [CreateAssetMenu(fileName = "Position", menuName = "ScriptableObjects/PlayerPosition", order = 0)]
    public class PlayerPosition : ScriptableObject
    {
        [SerializeField] int _currentPosition;

        readonly List<PositionListener> _listeners = new List<PositionListener>();

        public int CurrentPosition => _currentPosition;

        public void Move(int newPos)
        {
            if(newPos == CurrentPosition) return;
            
            foreach (var listener in _listeners) listener.UpdatePosition(newPos);
            _currentPosition = newPos;
        }

        public void RegisterListener(PositionListener listener) => _listeners.Add(listener);
        public void UnregisterListener(PositionListener listener) => _listeners.Remove(listener);
    }
}