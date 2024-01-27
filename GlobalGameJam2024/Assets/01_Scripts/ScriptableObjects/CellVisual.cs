using UnityEngine;

namespace CeltaGames.ScriptableObjects
{
    [CreateAssetMenu(fileName = "CellVisual", menuName = "ScriptableObjects/CellVisual", order = 0)]
    public class CellVisual : ScriptableObject
    {
        [SerializeField] Sprite _sprite;
        [SerializeField] Color _color;
        [SerializeField] HitBoxType _type;

        public Sprite CellSprite => _sprite;
        public Color Color => _color;
        public HitBoxType Type => _type;
    }
}