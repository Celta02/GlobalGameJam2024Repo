using System.Collections.Generic;
using CeltaGames.ScriptableObjects;
using UnityEngine;
using UnityEngine.Pool;

namespace CeltaGames
{
    public class HitBoxPool : MonoBehaviour
    {
        [SerializeField] GridManager _gridManager;
        [SerializeField] HitBox _prefab;
        [SerializeField] HitBoxQueue _hitBoxQueue;
        [SerializeField] Transform _hitBoxParent;
        [SerializeField] int _defaultPoolCapacity = 15;
        [SerializeField] int _poolMaxSize = 25;
        [SerializeField] int _initialPoolAmount = 12;
        
        ObjectPool<HitBox> _pool;
        List<CellVisual> _availableVisuals;

        void Awake()
        {
            _availableVisuals = _gridManager.CellVisuals;
            _pool = new ObjectPool<HitBox>(CreateHitBox,
                GetHitBox,
                ReleaseHitBox,
                DestroyHitBox,
                defaultCapacity: _defaultPoolCapacity,
                maxSize: _poolMaxSize);
        }

        void Start()
        {
            for (int i = 0; i < _initialPoolAmount; i++) CreateHitBox();
        }

        HitBox CreateHitBox()
        {
            HitBox hitBox = Instantiate(_prefab, _hitBoxParent,true);
            hitBox.disable += instance => _pool.Release(instance);
            
            var cellVisual = GetRandomVisual();
            
            var go = hitBox.gameObject;
            var sr = go.AddComponent<SpriteRenderer>();
            sr.sprite = cellVisual.CellSprite;
            sr.color = cellVisual.Color;
            var hitBoxType = go.AddComponent<HitBoxTypeComponent>();
            hitBoxType.Type = cellVisual.Type;
            
            go.SetActive(false);
            return hitBox;
        }

        void GetHitBox(HitBox hitBox)
        {
            hitBox.transform.position = _hitBoxQueue.LastPosition; //TODO Move to HitBoxQueue
            hitBox.gameObject.SetActive(true);
        }

        void ReleaseHitBox(HitBox hitBox)
        {
            hitBox.transform.position = _hitBoxQueue.LastPosition;
            hitBox.gameObject.SetActive(false);
        }
        void DestroyHitBox(HitBox hitBox)
        {
            Destroy(hitBox.gameObject);
        }

        public ObjectPool<HitBox> GetPool() => _pool;
        
        CellVisual GetRandomVisual()
        {
            var randomIndex = Random.Range(0, _availableVisuals.Count);
            return _availableVisuals[randomIndex];
        }
    }
}