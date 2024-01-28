using System;
using UnityEngine;

namespace CeltaGames.ScriptableObjects
{
    public class CatMoodLevelBroadcaster : MonoBehaviour
    {
        public event Action<CatMoodLevel> OnMoodLevelChange = delegate{ };
        [SerializeField] CatMood _catMood;

        MoodListener _moodListener;
        CatMoodLevel _currentMood;
        float _amountOfLevels = 5f;
        float _levelsize;
        
        void OnEnable() => _catMood.RegisterListener(_moodListener);
        void OnDisable() => _catMood.UnregisterListener(_moodListener);

        void Awake() => _moodListener = new MoodListener(OnMoodChange);

        void Start()
        {
            _levelsize = _catMood.MaxMood / _amountOfLevels;
        }

        void OnMoodChange(float mood)
        {
            var newLevel = (int)(mood / _levelsize);
            var newMood = (CatMoodLevel)newLevel;

            if (newMood == _currentMood) return;
            _currentMood = newMood;
            OnMoodLevelChange.Invoke(_currentMood);
        }
    }
}