using UnityEngine;

namespace CeltaGames
{
    public class Cell
    {
        readonly Vector3 _position;
        HitBoxType _type;

        public Vector3 Position => _position;

        public HitBoxType Type
        {
            get => _type;
            set => _type = value;
        }

        public Cell(Vector3 position)
        {
            _position = position;
        }
    }
}