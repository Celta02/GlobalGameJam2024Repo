using System;
using CeltaGames.ScriptableObjects;
using UniRx;
using UnityEngine;

namespace CeltaGames
{
    public class GameTimer : MonoBehaviour
    {
        [SerializeField] GameTime _time;
        float _startingTime = 83f;
        IDisposable _timerDisposable;

        void Awake()
        {
            _time.Time = _startingTime;
            _timerDisposable = Observable.Interval(TimeSpan.FromSeconds(0.1f)).Subscribe(UpdateTime).AddTo(this);
        }

        void UpdateTime(long l)
        {
            _time.Time -= 0.1f;
        }
    }   
}