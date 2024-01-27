using System;

namespace CeltaGames
{
    public class PositionListener
    {
        readonly Action<int> _updatePosition;

        public PositionListener(Action<int> updatePosition) => _updatePosition = updatePosition;
        public void UpdatePosition(int newPos) => _updatePosition.Invoke(newPos);
    }
}