using CeltaGames.ScriptableObjects;
using UnityEngine;

namespace CeltaGames
{
    public class CatHappiness : MonoBehaviour
    {
        [SerializeField] CatMood _catMood;
        [SerializeField] PlayerHitEmitter _hitEmitter;
        [SerializeField] float _startingHappiness = 700f;
        [SerializeField] float _successReward = 20f;
        [SerializeField] float _failurePunishment = -200f;

        PlayerHitListener _hitListener;

        void OnEnable() => _hitEmitter.RegisterListener(_hitListener);
        void OnDisable() => _hitEmitter.UnregisterListener(_hitListener);

        void Awake()
        {
            _hitListener = new PlayerHitListener(OnHit);
            _catMood.SetMood(_startingHappiness);
        }

        void OnHit(bool wasHitSuccessful)
        {
            _catMood.ChangeMood(wasHitSuccessful? _successReward:_failurePunishment);
        }
    }
}