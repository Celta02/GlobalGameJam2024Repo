using System.Collections.Generic;
using UnityEngine;

namespace CeltaGames.ScriptableObjects
{
    [CreateAssetMenu(fileName = "CatMood", menuName = "ScriptableObjects/Mood", order = 0)]
    public class CatMood : ScriptableObject
    {
        [SerializeField] float _maxMood = 1000f;
        float _currentMood;
        
        readonly List<MoodListener> _listeners = new ();

        public float CurrentMood => _currentMood;

        public float MaxMood => _maxMood;

        public void ChangeMood(float amountChanged)
        {
            _currentMood += amountChanged;
            _currentMood = Mathf.Clamp(_currentMood, 0, _maxMood);
            foreach (var listener in _listeners) listener.UpdateMood(_currentMood);
        }

        public void SetMood(float moodAmount) => _currentMood = Mathf.Clamp(moodAmount, 0, _maxMood);

        public void RegisterListener(MoodListener listener) => _listeners.Add(listener);
        public void UnregisterListener(MoodListener listener) => _listeners.Remove(listener);


    }
}