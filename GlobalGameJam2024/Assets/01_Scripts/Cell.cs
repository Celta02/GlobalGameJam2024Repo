using UnityEngine;

namespace CeltaGames
{
    public class Cell
    {
        readonly Vector3 _position;

        public Vector3 Position => _position;

        public Cell(Vector3 position)
        {
            _position = position;
        }
    }
}