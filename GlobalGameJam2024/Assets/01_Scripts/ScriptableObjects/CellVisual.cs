using UnityEngine;

namespace CeltaGames.ScriptableObjects
{
    [CreateAssetMenu(fileName = "CellVisual", menuName = "ScriptableObjects/CellVisual", order = 0)]
    public class CellVisual : ScriptableObject
    {
        [SerializeField] GameObject _prefab;
        [SerializeField] Sprite _sprite;
        [SerializeField] Sprite _hitSprite;
        [SerializeField] Color _color;
        [SerializeField] HitBoxType _type;

        public GameObject Prefab => _prefab;
        public Sprite CellSprite => _sprite;
        public Sprite HitSprite => _hitSprite;
        public Color Color => _color;
        public HitBoxType Type => _type;

    }
}