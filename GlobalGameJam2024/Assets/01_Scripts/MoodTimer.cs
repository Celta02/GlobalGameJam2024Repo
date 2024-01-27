using CeltaGames.ScriptableObjects;
using UnityEngine;

namespace CeltaGames
{
    public class MoodTimer : MonoBehaviour
    {
        [SerializeField] CatMood _catMood;
        [SerializeField] float _reductionAmount = 0.5f;

        void FixedUpdate()
        {
            _catMood.ChangeMood(-_reductionAmount);
        }
    }
}