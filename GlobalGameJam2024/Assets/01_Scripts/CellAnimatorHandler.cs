using System;
using System.Collections.Generic;
using CeltaGames.ScriptableObjects;
using UniRx;
using UnityEngine;

namespace CeltaGames
{
    public class CellAnimatorHandler : MonoBehaviour
    {
        [SerializeField] PlayerPosition _position;
        [SerializeField] GridManager _gridManager;
        [SerializeField] PlayerHitEmitter _hitEmitter;
        [Tooltip("Duration of the animation in Milliseconds")]
        [SerializeField] double _animationDuration = 1000;

        PlayerHitListener _hitListener;
        SpriteRenderer _spriteRenderer;
        Sprite _originalSprite;
        List<CellVisual> _visuals = new();
        List<GameObject> _gameObjects = new();
        IDisposable _disposable;

        void OnEnable() => _hitEmitter.RegisterListener(_hitListener);
        void OnDisable() => _hitEmitter.UnregisterListener(_hitListener);

        void Awake() => _hitListener = new PlayerHitListener(OnHit);

        void Start()
        {
            _visuals = _gridManager.CellVisuals;
            _gameObjects = _gridManager.CellGameObjects;
        }

        void OnHit(bool wasHitSuccessful, HitBoxType type)
        {
            if(!_gameObjects[_position.CurrentPosition-1].TryGetComponent(out _spriteRenderer)) return;
            _originalSprite = _visuals[_position.CurrentPosition-1].CellSprite;
            AnimateMouse();
        }

        void AnimateMouse()
        {
            _disposable?.Dispose();
            _spriteRenderer.sprite = _visuals[_position.CurrentPosition-1].HitSprite;
            _disposable = Observable.Timer(TimeSpan.FromMilliseconds(_animationDuration))
                .Subscribe(FinishAnimation).AddTo(this);
        }

        void FinishAnimation(long l) => _spriteRenderer.sprite = _originalSprite;
    }
}