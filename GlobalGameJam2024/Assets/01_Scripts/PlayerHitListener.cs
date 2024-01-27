using System;

namespace CeltaGames
{
    public class PlayerHitListener
    {
        readonly Action<bool> _onHit;

        public PlayerHitListener(Action<bool> onHit) => _onHit = onHit;
        public void OnHit(bool wasHitSuccessful) => _onHit.Invoke(wasHitSuccessful);
    }
}