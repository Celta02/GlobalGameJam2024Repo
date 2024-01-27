using System;

namespace CeltaGames
{
    public class PlayerHitListener
    {
        readonly Action<bool, HitBoxType> _onHit;

        public PlayerHitListener(Action<bool, HitBoxType> onHit) => _onHit = onHit;
        public void OnHit(bool wasHitSuccessful, HitBoxType hitBoxType) => _onHit.Invoke(wasHitSuccessful, hitBoxType);
    }
}