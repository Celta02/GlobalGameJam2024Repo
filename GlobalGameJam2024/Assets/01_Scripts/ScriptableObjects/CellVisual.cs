using UnityEngine;

namespace CeltaGames.ScriptableObjects
{
    [CreateAssetMenu(fileName = "CellVisual", menuName = "ScriptableObjects/CellVisual", order = 0)]
    public class CellVisual : ScriptableObject
    {
        [SerializeField] Sprite _sprite;

        public Sprite CellSprite => _sprite;
    }
}