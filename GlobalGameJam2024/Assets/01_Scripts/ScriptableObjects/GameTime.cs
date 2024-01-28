using UnityEngine;

namespace CeltaGames.ScriptableObjects
{
    [CreateAssetMenu(fileName = "Time", menuName = "ScriptableObjects/Timer", order = 0)]
    public class GameTime : ScriptableObject
    {
        public float Time;
    }
}