using System;
using System.Collections;
using CeltaGames.ScriptableObjects;
using UnityEngine;

namespace CeltaGames
{
    public class CellAnimatorHandler : MonoBehaviour
    {
        [SerializeField] PlayerPosition _position;
        [SerializeField] PlayerGrid _grid;
        [SerializeField] PlayerHitEmitter _hitEmitter;
        
        [Header("Animation Sprites")]
        [SerializeField] Sprite _orangeAnim;
        [SerializeField] Sprite _blueAnim;
        [SerializeField] Sprite _greenAnim;
        [SerializeField] Sprite _yellowAnim;
        [SerializeField] Sprite _CyanAnim;

        PlayerHitListener _hitListener;

        void OnEnable() => _hitEmitter.RegisterListener(_hitListener);
        void OnDisable() => _hitEmitter.UnregisterListener(_hitListener);

        void Awake() => _hitListener = new PlayerHitListener(OnHit);

        void OnHit(bool wasHitSuccessful, HitBoxType type)
        {
            
        }

        IEnumerator AnimateMouse()
        {
            
            yield return new WaitForSeconds(0.5f);
        }
    }
}