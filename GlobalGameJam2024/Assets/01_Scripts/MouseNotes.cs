using System;
using CeltaGames.ScriptableObjects;
using FMODUnity;
using UnityEngine;

namespace CeltaGames
{
    public class MouseNotes : MonoBehaviour
    {
        [SerializeField] PlayerHitEmitter _hitEmitter;
        
        [SerializeField] StudioEventEmitter _mouse_note_1;
        [SerializeField] StudioEventEmitter _mouse_note_2;
        [SerializeField] StudioEventEmitter _mouse_note_3;
        [SerializeField] StudioEventEmitter _mouse_note_4;
        [SerializeField] StudioEventEmitter _mouse_note_5;
        [SerializeField] StudioEventEmitter _mouse_fail;

        PlayerHitListener _hitListener;

        void OnEnable() => _hitEmitter.RegisterListener(_hitListener);
        void OnDisable() => _hitEmitter.UnregisterListener(_hitListener);

        void Awake() => _hitListener = new PlayerHitListener(OnPlayerHit);

        void OnPlayerHit(bool wasSuccessful, HitBoxType hitBoxType)
        {
            if (!wasSuccessful) _mouse_fail.Play();
            switch (hitBoxType)
            {
                case HitBoxType.Orange:
                    _mouse_note_1.Play();
                    break;
                case HitBoxType.Blue:
                    _mouse_note_2.Play();
                    break;
                case HitBoxType.Yellow:
                    _mouse_note_3.Play();
                    break;
                case HitBoxType.Green:
                    _mouse_note_4.Play();
                    break;
                case HitBoxType.Cyan:
                    _mouse_note_5.Play();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(hitBoxType), hitBoxType, null);
            }
        }
    }
}