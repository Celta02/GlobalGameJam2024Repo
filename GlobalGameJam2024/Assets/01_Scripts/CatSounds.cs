using CeltaGames.ScriptableObjects;
using FMODUnity;
using UnityEngine;

namespace CeltaGames
{
    public class CatSounds : MonoBehaviour
    {
        [SerializeField] CatMoodLevelBroadcaster _catMood;
        [SerializeField] StudioEventEmitter _catSound;

        void OnEnable() => _catMood.OnMoodLevelChange += ChangeMoodHandler;
        void OnDisable() => _catMood.OnMoodLevelChange -= ChangeMoodHandler;

        void ChangeMoodHandler(CatMoodLevel moodLevel)
        {
            _catSound.Play();
        }
    }
}