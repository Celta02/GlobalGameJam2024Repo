using System;
using CeltaGames.ScriptableObjects;
using UniRx;
using UnityEngine;

namespace CeltaGames
{
    public class MoodTimer : MonoBehaviour
    {
        [SerializeField] CatMood _catMood;
        [SerializeField] float _reductionAmount = 15f;
        IDisposable _disposableTimer;

        void OnEnable()
        {
            _disposableTimer = Observable.Interval(TimeSpan.FromSeconds(1f)).Subscribe(ReduceMood).AddTo(this);
        }

        void ReduceMood(long l)
        {
            _catMood.ChangeMood(-_reductionAmount);
        }

        void OnDisable()
        {
            _disposableTimer.Dispose();
        }
    }
}