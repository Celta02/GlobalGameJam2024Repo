using System;
using System.Collections.Generic;
using CeltaGames.ScriptableObjects;
using UnityEngine;
using UnityEngine.Pool;

namespace CeltaGames
{
    public class HitBoxQueue : MonoBehaviour
    {

        [SerializeField] PlayerHitEmitter _hitEmitter;
        [SerializeField] HitBoxPool _hitBoxPooling;
        [SerializeField] int _queueSize;
        [SerializeField] float _spacing;
        [SerializeField] Vector2 _firstHitBoxPosition = Vector2.zero;
        
        readonly List<HitBox> _hitBoxes = new ();
        HitBox _currentHitBox;
        PlayerHitListener _hitListener;
        ObjectPool<HitBox> _pool;
        Vector3 _lastPosition;

        public HitBoxType CurrentHitBoxType => _currentHitBox.Type.Type;
        public Vector3 LastPosition => _lastPosition;



        void OnEnable() => _hitEmitter.RegisterListener(_hitListener);
        void OnDisable() => _hitEmitter.UnregisterListener(_hitListener);

        void Awake()
        {
            _hitListener = new PlayerHitListener(OnHit);
        }

        void Start()
        {
            _pool = _hitBoxPooling.GetPool();
            
            _lastPosition = new Vector3(_firstHitBoxPosition.x + (_queueSize - 1) * _spacing,
                _firstHitBoxPosition.y,
                0f);
            
            for (int i = 0; i < _queueSize; i++)
            {
                var hitBox = _pool.Get();
                hitBox.transform.position =
                    new Vector3(_firstHitBoxPosition.x + i * _spacing, _firstHitBoxPosition.y, 0f);
                _hitBoxes.Add(hitBox);
            }

            _currentHitBox = _hitBoxes[0];
        }


        void OnHit(bool wasHitSuccessful, HitBoxType hitBoxType)
        {
            _hitBoxes[0].GotHit();
            _hitBoxes.RemoveAt(0);
            _currentHitBox = _hitBoxes[0];
            foreach (var hitBox in _hitBoxes) hitBox.transform.Translate(Vector3.left * _spacing);
            _hitBoxes.Add(_pool.Get());
        }
    }
}