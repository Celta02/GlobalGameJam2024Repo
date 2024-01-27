using UnityEngine;
using CeltaGames.ScriptableObjects;
using UnityEngine.UI;

namespace CeltaGames
{
    public class MoodUI : MonoBehaviour
    {
        [SerializeField] CatMood _catMood;
        [SerializeField] Image _image;

        MoodListener _moodListener;
        float _maxMood;

        void OnEnable() => _catMood.RegisterListener(_moodListener);
        void OnDisable() => _catMood.UnregisterListener(_moodListener);

        void Awake() => _moodListener = new MoodListener(OnMoodChange);

        void Start()
        {
            _maxMood = _catMood.MaxMood;
            OnMoodChange(_catMood.CurrentMood);
        }

        void OnMoodChange(float moodAmount)
        {
            _image.fillAmount = 1 - ((_maxMood - moodAmount) / _maxMood);
        }
    }
}