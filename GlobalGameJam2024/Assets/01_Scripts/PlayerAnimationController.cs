using System;
using CeltaGames.ScriptableObjects;
using UnityEngine;

namespace CeltaGames
{
    public class PlayerAnimationController : MonoBehaviour
    {
        [SerializeField] Animator _animator;
        [SerializeField] PlayerHitEmitter _hitEmitter;

        PlayerHitListener _hitListener;
        static readonly int SuccessfulHit = Animator.StringToHash("SuccessfulHit");
        static readonly int FailedHit = Animator.StringToHash("FailedHit");

        void OnEnable() => _hitEmitter.RegisterListener(_hitListener);
        void OnDisable() => _hitEmitter.UnregisterListener(_hitListener);
        void Awake() => _hitListener = new PlayerHitListener(OnHit);


        void OnHit(bool wasHitSuccessful, HitBoxType hitBoxType)
        {
            _animator.SetTrigger(wasHitSuccessful ? SuccessfulHit : FailedHit);
        }
    }
}