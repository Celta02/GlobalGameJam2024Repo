using System.Collections.Generic;
using UnityEngine;

namespace CeltaGames.ScriptableObjects
{
    [CreateAssetMenu(fileName = "PlayerHitEmitter", menuName = "ScriptableObjects/PlayerHitEmitter", order = 0)]
    public class PlayerHitEmitter : ScriptableObject
    {
        readonly List<PlayerHitListener> _listeners = new ();

        public void BroadcastHit(bool wasHitSuccessful)
        {
            foreach (var listener in _listeners) listener.OnHit(wasHitSuccessful);
        }

        public void RegisterListener(PlayerHitListener listener) => _listeners.Add(listener);
        public void UnregisterListener(PlayerHitListener listener) => _listeners.Remove(listener);
    }
}