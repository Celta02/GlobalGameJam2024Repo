using System;
using CeltaGames.ScriptableObjects;
using UnityEngine;

namespace CeltaGames
{
    public class CatAnimationController : MonoBehaviour
    {
        [SerializeField] Animator _animator;
        [SerializeField] CatMoodLevelBroadcaster _catMood;
        
        static readonly int VeryAngry = Animator.StringToHash("VeryAngry");
        static readonly int Angry = Animator.StringToHash("Angry");
        static readonly int Neutral = Animator.StringToHash("Neutral");
        static readonly int Happy = Animator.StringToHash("Happy");
        static readonly int VeryHappy = Animator.StringToHash("VeryHappy");

        void OnEnable() => _catMood.OnMoodLevelChange += HandleMoodLevelChange;

        void OnDisable() => _catMood.OnMoodLevelChange -= HandleMoodLevelChange;

        void HandleMoodLevelChange(CatMoodLevel moodLevel)
        {
            switch (moodLevel)
            {
                case CatMoodLevel.VeryAngry:
                    _animator.SetTrigger(VeryAngry);
                    break;
                case CatMoodLevel.Angry:
                    _animator.SetTrigger(Angry);
                    break;
                case CatMoodLevel.Neutral:
                    _animator.SetTrigger(Neutral);
                    break;
                case CatMoodLevel.Happy:
                    _animator.SetTrigger(Happy);
                    break;
                case CatMoodLevel.VeryHappy:
                    _animator.SetTrigger(VeryHappy);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(moodLevel), moodLevel, null);
            }
            
            Debug.Log($"MOOD Level: {moodLevel.ToString()}");
        }
    }
}