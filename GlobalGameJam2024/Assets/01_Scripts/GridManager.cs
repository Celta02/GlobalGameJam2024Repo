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
        
        void Awake() => InitializeGrid();

        void InitializeGrid()
        {
            _playerGrid.Setup(_firstCellPosition, _gridLength, _spacing);
            for (int i = 1; i <= _gridLength; i++)
            {
                var go = new GameObject("Cell")
                {
                    transform =
                    {
                        position = _playerGrid.GetCellPosition(i) + (Vector3)_visualOffset,
                        parent = _cellsParent
                    }
                };

                var sr = go.AddComponent<SpriteRenderer>();
                sr.sprite = _cellVisuals[i-1].CellSprite;
            }
        }

        void OnValidate()
        {
            _gridLength = _cellVisuals.Count;
            Debug.Log($"Cells number: {_gridLength}");
        }
    }
}