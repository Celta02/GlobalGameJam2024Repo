using System.Collections.Generic;
using CeltaGames.ScriptableObjects;
using UnityEngine;

namespace CeltaGames
{
    public class GridManager : MonoBehaviour
    {
        [SerializeField] PlayerGrid _playerGrid;
        [SerializeField] Transform _cellsParent;
        [Space, Header("Grid Setup")]
        [SerializeField] Vector2 _firstCellPosition = Vector2.zero;
        [SerializeField] float _spacing = 1f;
        [SerializeField] List<CellVisual> _cellVisuals = new ();
        [SerializeField] Vector2 _visualOffset = Vector2.zero; 
        
        int _gridLength = 4;

        public List<CellVisual> CellVisuals => _cellVisuals;


        void Awake() => InitializeGrid();

        void InitializeGrid()
        {
            _playerGrid.Setup(_firstCellPosition, _gridLength, _spacing);
            for (int i = 1; i <= _gridLength; i++)
            {
                var go = Instantiate(CellVisuals[i - 1].Prefab,
                    _playerGrid.GetCellPosition(i) + (Vector3)_visualOffset,
                    Quaternion.identity, 
                    _cellsParent);
                
                var hitBoxType = go.AddComponent<HitBoxTypeComponent>();
                hitBoxType.Type = CellVisuals[i - 1].Type;
                _playerGrid.GetCellAtPosition(i).Type = hitBoxType.Type;
                
                if (!go.TryGetComponent(out SpriteRenderer sr)) return;
                sr.sprite = CellVisuals[i-1].CellSprite;
                sr.color = CellVisuals[i-1].Color;
            }
        }

        void OnValidate()
        {
            _gridLength = CellVisuals.Count;
        }
    }
}