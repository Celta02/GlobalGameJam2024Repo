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
        float _levelSize;

        public CatMoodLevel CurrentMood => _currentMood;

        void OnEnable() => _catMood.RegisterListener(_moodListener);
        void OnDisable() => _catMood.UnregisterListener(_moodListener);

        void Awake() => _moodListener = new MoodListener(OnMoodChange);

        void Start()
        {
            _levelSize = _catMood.MaxMood / _amountOfLevels;
        }

        void OnMoodChange(float mood)
        {
            var newLevel = Mathf.Clamp((int)(mood / _levelSize),0,4) ;
            var newMood = (CatMoodLevel)newLevel;

            if (newMood == CurrentMood) return;
            _currentMood = newMood;
            OnMoodLevelChange.Invoke(CurrentMood);
        }
    }
}